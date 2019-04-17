using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDA
{
    class ArchivoRegistros : Archivo
    {
        public long firstReg = 0;
        List<List<string>> registros;
        Entidad entidad;

        public ArchivoRegistros(string fullname, Entidad e ) : base(fullname)
        {
            registros = new List<List<string>>();
            entidad = e;
            if (!File.Exists(fullname) )
            {
                nuevoArch();
            }
            else
            {
                leerArch(e.Dir_Datos);
            }
            //indices();
        }

        public void sobreescribirArch()
        {
            foreach(List<string> reg in entidad.Registros)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(base.Fullname, FileMode.Open)))
                {
                    long var = Convert.ToInt64(reg[0]);
                    writer.Seek(Convert.ToInt32(var), SeekOrigin.Begin);
                    writer.Write(var);
                    for (int i = 1; i < reg.Count - 1; i++)
                    { 
                        if (entidad.Atrib[i -1].Tipo == 'E')
                        {
                            //while(reg[i].Length < entidad.Atrib[i - 1].Longitud) { reg[i].Insert(0, "0"); }
                            int val = Convert.ToInt32(reg[i]);
                            writer.Write(val);
                        }
                        else
                        {
                            //if (reg[i].Contains("/t")) reg[i].Replace("/t", "");
                            while (reg[i].Length < entidad.Atrib[i - 1].Longitud ) { reg[i] += " "; }
                            string val = reg[i].Substring(0, entidad.Atrib[i - 1].Longitud -1 );
                            writer.Write(val);
                        }
                    }
                    var = Convert.ToInt64(reg.Last());
                    writer.Write(var);
                } 
            }
        }
        public void leerArch(long dir)
        {
            entidad.Registros = new List<List<string>>(); 
            using(BinaryReader reader = new BinaryReader(File.Open(base.Fullname, FileMode.Open), Encoding.ASCII))
            {                
                try
                { 
                    reader.BaseStream.Seek(dir, SeekOrigin.Begin);
                    Console.WriteLine(reader.PeekChar());
                    while (reader.PeekChar() != -1)
                    {
                        List<string> r = new List<string>();
                        r.Add(reader.ReadInt64().ToString());
                        foreach (var atrib in entidad.Atrib)
                        {
                            if (atrib.Tipo == 'C')
                            {
                                var a = reader.ReadChars(atrib.Longitud);
                                string s = "";
                                List<char> aux = a.ToList();
                                while (aux.First() == '\t' || aux.First() == '\u0003' || aux.First() == '\u0013')
                                {
                                    aux.RemoveAt(0);
                                }
                                if (a[0] != '\t' && a[0] != '\u0013'  && a[0] != '"')
                                    foreach (char c in aux) { s += c; }
                                else
                                    for (int i = 1; i < a.Length; i++) s += a[i];
                                r.Add(s);
                            }
                            else 
                                r.Add(reader.ReadInt32().ToString());
                        }
                        r.Add(reader.ReadInt64().ToString());
                        entidad.Registros.Add(r);
                        dir = Convert.ToInt64(r.Last());
                        if (dir == -1) break;
                        reader.BaseStream.Seek(dir, SeekOrigin.Begin);
                        Console.WriteLine(reader.PeekChar());
                    }
                }
                catch { }
            }
            entidad.ordenaReg();
        }
    }
}
