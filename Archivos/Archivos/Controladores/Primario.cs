using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos.Controladores
{
    public class Primario : Indice
    {
        List<Cajon_Primario> subCajones;
        Cajon_Primario primario;
        int Long_CB;
        //Atributo atrib;

        //nuevo arch. 
        public Primario(Atributo a, bool letras, string Nombre, int i, int long_CB) : base(Nombre, i, a)
        {
            //atrib = a;
            if ((File.Exists(Fullname) && Longitud > 0 )|| a.DirAtributo < 0)
            {
                //lee el cajon primario de la A a la Z
                leePrimario();
            }
            else
            {
                nuevoArch();
                a.DirIndice = 0;
                int inicia = (letras) ? 49 : 65;
                if (letras) primario = new Cajon_Primario(0);
                else primario = new Cajon_Primario(1);
                Long_CB = long_CB;
                //atrib = a;
                escribePrimario();
            }
            Long_CB = a.Longitud;
        }
        public Primario(Atributo a, int i, string Nombre): base(Nombre , i, a)
        {
            //atrib = a;
            if (File.Exists(Fullname) && Longitud > 0)
            {
                //lee el cajon primario de la A a la Z
                leePrimario();
            }
            else
            {
                nuevoArch();
                a.DirIndice = 0;
            }
            Long_CB = a.Longitud;

        }
        public Cajon_Primario prim { get => primario; set => primario = value; }
        public List<Cajon_Primario> SubCajones { get => subCajones; set => subCajones = value; }
        internal void inserta(string claveBusq, long apuntador)
        {
            for(int i = 0; i < prim.Longitud; i++)
            {
                var cha = claveBusq.ToList().Find(o => o != '0');
                if(prim.Ind[i] == char.ToUpper(cha))
                {
                    if (prim.Ap[i] == -1)
                    {
                        //crea nueva caja tipo primaria 2 (1)
                        //agregaremos la clave de busqueda y el apuntador al registro el tamaño del archivo sera igual a
                        //prim.Ap[i]
                        Cajon_Primario c = new Cajon_Primario(claveBusq, apuntador, Long_CB);
                        prim.Ap[i] = Longitud;
                        escribePrimario_Cajon(prim.Ap[i], c);
                    }
                    else
                    {
                        var c = ElCajon(prim.Ap[i]);
                       
                        c.inserta(claveBusq, apuntador);
                        ordenaCajon(c);
                        escribePrimario_Cajon(prim.Ap[i], c );
                    }
                    i = prim.Longitud;
                }
            }
        }

        public void elimina(string val)
        {
            char inicial = val.ToList().Find(o => o != '\u001d');
            int fin = val.ToList().FindIndex(o => o == ' ');
            string s = "";
            s = (fin < 0)? val.Substring(val.IndexOf(inicial)): val.Substring(val.IndexOf(inicial), fin);
            
             
            for (int i = 0; i < prim.Longitud; i++)
            {
                if (prim.Ind[i] == char.ToUpper(inicial)) 
                {
                    if (prim.Ap[i] != -1)
                    {
                        Cajon_Primario c = ElCajon(prim.Ap[i]);
                        for (int j = 0; j < c.Longitud; j++)
                        {
                            if (c.Cb[j].Contains(s))
                            {
                                c.Cb[j] = "";
                                if (atrib.Tipo == 'C') while (c.Cb[j].Length < Long_CB) c.Cb[j] += " ";
                                else c.Cb[j] = "0";
                                c.Ap[j] = -1;
                                j = c.Longitud;
                            }
                        }
                        c = ordenaCajon(c);

                        escribePrimario_Cajon(prim.Ap[i], c);
                        if (c.Cb[0].All(o=>o == ' ') || c.Cb[0].First() == '0')
                        {
                            prim.Ap[i] = -1;
                        }
                        //c = ordenaCajon(c);
                        escribePrimario();
                        //c = ordenaCajon(c);
                        i = prim.Longitud;
                    }
                }
            }
        }
        public Cajon_Primario ordenaCajon(Cajon_Primario c)
        {
            for (int i = 0; i < c.Longitud - 1; i++)
            {
                for (int j = 0; j < c.Longitud - 1; j++)
                {
                    var b = c.Cb[j];
                    if (atrib.Tipo == 'C')
                    {
                        if (c.Cb[j].Contains('\u001d'))
                        {
                            string s = c.Cb[j].Substring(c.Cb[j].LastIndexOf('\u001d') + 1);
                            while (s.Length < c.Cb[j].Length) s += " ";
                            c.Cb[j] = s;

                            s = c.Cb[j + 1].Substring(c.Cb[j].LastIndexOf('\u001d') + 1);
                            while (s.Length < c.Cb[j].Length) s += " ";
                            c.Cb[j+1] = s;
                        }
                        string actual = c.Cb[j];
                        string sig = c.Cb[j + 1];
                        if(actual.All(o=>o ==' ') && sig.All(o => o == ' ') ) { j = c.Longitud - 1; }
                        else if(actual.All(o => o == ' ') && !sig.All(o => o == ' '))
                        {
                            var a = c.Cb[j + 1];
                            var p = c.Ap[j + 1];
                            c.Cb[j + 1] = c.Cb[j];
                            c.Ap[j + 1] = c.Ap[j];
                            c.Cb[j] = a;
                            c.Ap[j] = p;
                        }
                        else if(actual.CompareTo(sig) > 0 && !sig.All(o => o == ' '))
                        {

                            var a = c.Cb[j];
                            var p = c.Ap[j];
                            c.Cb[j] = c.Cb[j + 1];
                            c.Ap[j] = c.Ap[j + 1];
                            c.Cb[j + 1] = a;
                            c.Ap[j + 1] = p;
                        }
                    }
                    else
                    {
                        int actual = Int32.Parse(c.Cb[j]);
                        int sig = Int32.Parse(c.Cb[j + 1]);
                        if (sig < actual && sig != 0)
                        {
                            var a = c.Cb[j];
                            var p = c.Ap[j];
                            c.Cb[j] = c.Cb[j + 1];
                            c.Ap[j] = c.Ap[j + 1];
                            c.Cb[j + 1] = a;
                            c.Ap[j + 1] = p;
                        }
                        else if(sig > actual && sig != 0)
                        {
                            var a = c.Cb[j + 1];
                            var p = c.Ap[j + 1];
                            c.Cb[j + 1] = c.Cb[j];
                            c.Ap[j + 1] = c.Ap[j];
                            c.Cb[j] = a;
                            c.Ap[j] = p;
                        }
                    }
                }
            }
            return c;
        }
        public void escribePrimario()
        {
            using (BinaryWriter b = new BinaryWriter(File.Open(Fullname, FileMode.Open)))
            { 
                for(int i= 0; i< primario.Longitud; i++)
                {
                    b.Write(primario.Ind[i]);
                    b.Write(primario.Ap[i]);
                }
            }
        }
        public void leePrimario()
        {
            using (BinaryReader r = new BinaryReader(File.Open(Fullname, FileMode.Open)))
            { 
                Console.WriteLine(r.PeekChar());
                if (r.PeekChar() == 65)
                {
                    prim = new Cajon_Primario(0);//26;
                    
                }
                else
                {
                    prim = new Cajon_Primario(1);
                }
                for (int i = 0; i < prim.Longitud; i++)
                {
                    Console.WriteLine(r.ReadChar());
                    long ap = r.ReadInt64();
                    Console.WriteLine(ap);
                    if (ap != -1)
                        prim.Ap[i] = ap;
                }
            }
        }
        public Cajon_Primario ElCajon(long ind)
        {
            Cajon_Primario c = new Cajon_Primario(atrib);
            using (BinaryReader r = new BinaryReader(File.Open(Fullname, FileMode.Open)))
            {
                r.BaseStream.Seek(ind, SeekOrigin.Begin);
                int i = 0;
                char[] var; long d = 0;
                while (i < 50 && d >= 0)
                {
                    string a = "";
                    if (atrib.Tipo == 'C')
                    {
                        var = r.ReadChars(c.Cb.First().Length+1);
                        List<char> cb = var.ToList();
                        cb.RemoveAll(o => o == '\u0003');
                        while (a.Length < c.Cb.First().Length) a += cb[a.Length];
                        Console.WriteLine(var);
                    }
                    else
                    {
                        int entero = r.ReadInt32();
                        a = entero.ToString();
                        Console.WriteLine(entero);
                    }
                    d = r.ReadInt64();
                    Console.WriteLine(d);
                    if (!a.Contains("aux"))
                        c.inserta(a, d);
                    i++;
                }
            }
            return c;
        }

        public void escribePrimario_Cajon(long l, Cajon_Primario C)
        { 
            using (BinaryWriter b = new BinaryWriter(File.Open(Fullname, FileMode.Open)))
            {
                b.Seek((int)l, SeekOrigin.Begin);
                for (int i = 0; i < C.Longitud; i++)
                {
                    if (atrib.Tipo == 'C')
                        b.Write(C.Cb[i]);
                    else
                        b.Write(Int32.Parse(C.Cb[i]));
                    b.Write(C.Ap[i]);
                }
            }
        }
    }
}
