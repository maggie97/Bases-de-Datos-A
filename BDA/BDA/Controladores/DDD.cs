using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BDA
{
    public class DDD : Archivo
    { 
        List<Object> obj = new List<object>();
        List<Entidad> list_insercion = new List<Entidad>();
        List<Entidad> list_entidades = new List<Entidad>();
        long cab = -1;

        public List<Entidad> EntidadesInser { get => list_insercion; set => list_insercion = value; }
        public List<Entidad> EntidadesOrden { get => list_entidades; set => list_entidades = value; }
        public long Cab { get => cab; set => cab = value; }

        public DDD(string filename, string extencion, string direccion) 
            : base(filename, extencion, direccion)
        {

        }

        public DDD(string fullname) : base (fullname)
        {

        }
        
        public new void lee()
        {
            using (BinaryReader reader = new BinaryReader(File.Open(base.Fullname, FileMode.Open)))
            {
                cab = reader.ReadInt64();
                Console.WriteLine(cab); 
                try
                {
                    Console.WriteLine(reader.PeekChar());
                    while (reader.PeekChar() != -1)
                    {
                        string nomb = "";
                        long dir;
                        char[] nombre = reader.ReadChars(30);
                        foreach (char n in nombre) 
                            nomb += n;
                        dir = reader.ReadInt64();
                        Console.WriteLine(reader.PeekChar()); 
                        if (reader.PeekChar() >= 70 || reader.PeekChar()<60)
                        {
                            list_insercion.Add(leeEntidad(reader, nomb, dir));
                            //list_entidades.Add(list_insercion.Last());
                            obj.Add(list_insercion.Last());
                        }
                        else
                        {
                            Atributo n = leeAtributo(reader, nomb, Convert.ToInt64(dir));
                            foreach (Entidad ent in list_insercion)
                            {
                                obj.Add(n);
                                if(ent.Dir_Entidad != -1)
                                {
                                    if (ent.Dir_Atributos == n.DirAtributo)
                                        ent.Atrib.Add(n);
                                    else
                                        foreach (Atributo a in ent.Atrib)
                                        {
                                            if (a.DirSig == n.DirAtributo)
                                            {
                                                ent.Atrib.Add(n);
                                                break;
                                            }
                                        }
                                }
                            }
                        }
                        
                    }
                    
                }
                catch (Exception  e){ }
                entidades(cab);
            }
        }
        public  void lee_()
        {
            leeCab();
            using (BinaryReader reader = new BinaryReader(File.Open(base.Fullname, FileMode.Open)))
            {
                Console.WriteLine(cab);
                try
                {
                    long dirSig = cab; 
                    reader.BaseStream.Seek(dirSig, SeekOrigin.Begin);
                    Console.WriteLine(reader.PeekChar());
                    //lee entidades
                    while (dirSig != -1)
                    {
                        reader.BaseStream.Seek(dirSig, SeekOrigin.Begin);
                        string nomb = "";
                        long dir;
                        char[] nombre = reader.ReadChars(30);
                        foreach (char n in nombre)
                            nomb += n;
                        dir = reader.ReadInt64();
                        //Console.WriteLine(reader.PeekChar());
                        Entidad ent = leeEntidad(reader, nomb, dir);
                        list_entidades.Add(ent);
                        obj.Add(ent);
                        dirSig = ent.Dir_sig;
                        //list_entidades.Add(list_insercion.Last());
                    }
                    foreach(Entidad e in list_entidades)
                    {
                        dirSig = e.Dir_Atributos;
                        while (dirSig != -1)
                        {
                            reader.BaseStream.Seek(dirSig, SeekOrigin.Begin);
                            string nomb = "";
                            long dir;
                            char[] nombre = reader.ReadChars(30);
                            foreach (char n in nombre)
                                nomb += n;
                            dir = reader.ReadInt64();
                            //----------------
                            //Console.WriteLine(reader.PeekChar());
                            Atributo a = leeAtributo(reader, nomb, Convert.ToInt64(dir));
                            e.Atrib.Add(a);
                            e.Indice(Fullname.Substring(0, Fullname.LastIndexOf('\\')));
                            dirSig = a.DirSig;
                        }
                    }
                    


                }
                catch (Exception e) { }
            }
        }
        public void entidades(long ap)
        {
            long dir = ap;
            //while (dir != -1)
            {
                foreach(Entidad e in list_insercion)
                {
                    if (e.Dir_Entidad == dir)
                    {
                        list_entidades.Add(e);
                        e.Indice(Fullname.Substring(0, Fullname.LastIndexOf('\\')));
                        dir = e.Dir_sig;
                    }
                }
            }
        }
       
        public void sobreescribeCab()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(Fullname, FileMode.Open)))
            {
                writer.Seek(0, SeekOrigin.Begin);
                writer.Write(cab);
            }
        }

        public void leeCab()
        {
            using (BinaryReader reader = new BinaryReader(File.Open(Fullname, FileMode.Open)))
            {
                cab = reader.ReadInt64();
                Console.WriteLine("Cabecera: " + cab);
            }/**/
        }

        #region entidades

        public Entidad leeEntidad(BinaryReader reader, string name, long dir)
        {
            long dir_atr, dir_dat, dir_sig;
            dir_atr = reader.ReadInt64();
            dir_dat = reader.ReadInt64();
            dir_sig = reader.ReadInt64();
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", name, dir, dir_atr, dir_dat, dir_sig);
            return (new Entidad(name.ToCharArray(), dir, dir_atr, dir_dat, dir_sig));
        }

        public void nuevaEntidad(string nomb)
        {
            try
            {
                long sig_ent = -1;
                if (list_insercion.Count != 0)
                {
                    list_insercion.Last().Dir_sig = Longitud;
                }
                Entidad entidad = new Entidad(nomb.ToCharArray(), Longitud, -1, sig_ent);
                Console.WriteLine(nomb + entidad.Dir_Entidad.ToString() + entidad.Dir_sig.ToString());
                list_insercion.Add(entidad);
                list_entidades.Add(entidad);
                obj.Add(entidad);
                //Ordena las entidades
                list_entidades = list_entidades.OrderBy(o => o.sNombre).ToList();

                cab = list_entidades[0].Dir_Entidad; //Asigna el valor de la primera entidad a la cabecera 
                sobreescribeCab(); //Se sobreescribe la cabecera

                guardaEntidad(entidad); //Se guarda la nueva entidad.
                ordena();
                //sobreescribEntidades();
                sobreescribe_archivo();
            }
            catch (Exception e)
            {
                Console.WriteLine("causo una excepcion: ", e);
            }
        }
        public void eliminaEntidad(string s)
        {
            Entidad ent = list_entidades.Find(o => o.sNombre.Contains(s));
            long ds = ent.Dir_sig;
            if(cab == ent.Dir_Entidad)
            {
                ent.Dir_sig = -1;
                cab = ds;
                list_entidades.Remove(ent);
                sobreescribe_archivo();
            }
            else
            {
                Entidad aux = list_entidades.Find(o => o.Dir_sig.Equals(ent.Dir_Entidad));
                if(aux != null)
                {
                    ent.Dir_sig = -1;
                    aux.Dir_sig = ds;
                    list_entidades.Remove(ent); 
                    sobreescribe_archivo();
                }
                else
                {
                    list_entidades.Remove(ent);
                }
            }
        }

        public void guardaEntidad(Entidad e)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(base.Fullname, FileMode.Append)))
            {
                writer.Write(e.NombreEntidad);
                writer.Write(e.Dir_Entidad);
                writer.Write(e.Dir_Atributos);
                writer.Write(e.Dir_Datos);
                writer.Write(e.Dir_sig);
            }
        }
        public void ordena()
        {
            list_entidades = list_entidades.OrderBy(o => o.sNombre).ToList();
            cab = list_entidades.FirstOrDefault().Dir_Entidad;
            for (int i = 0; i < list_entidades.Count - 1; i++)
            {
                list_entidades[i].Dir_sig = list_entidades[i + 1].Dir_Entidad;
            }
            list_entidades.Last().Dir_sig = -1;
            /*foreach (Entidad e in list_entidades)
            {
                int i = list_insercion.IndexOf(e);
                list_insercion[i] = e;
            }*/
        }
         
        public void sobreescribEntidad(Entidad e)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(Fullname, FileMode.Open)))
            {
                Console.WriteLine(e.sNombre + "  " + e.Dir_Entidad + " " + e.Dir_Atributos);
                writer.Seek(Convert.ToInt32(e.Dir_Entidad),  SeekOrigin.Begin);
                writer.Write(e.NombreEntidad);
                writer.Write(e.Dir_Entidad);
                writer.Write(e.Dir_Atributos);
                writer.Write(e.Dir_Datos);
                writer.Write(e.Dir_sig);
            }
        }

        #endregion
        public void sobreescribe_archivo()
        {
            sobreescribeCab();
            foreach (Object o in obj)
            {
                if (o.GetType() == typeof(Entidad))
                    sobreescribEntidad((Entidad)o);
                else
                    sobreescribAtributo((Atributo)o);
            }
        }

        #region atributos
        public void nuevoAtributo(string nombre, int tipo, int longi,Entidad e, int TipoIndice, Atributo referencia)
        {
            long index = -1;
            if (referencia != null) index = referencia.DirAtributo;
            Atributo nuevo = new Atributo(nombre, Longitud, tipo, longi, TipoIndice, index, -1);

            e.nuevoA(nuevo);
            
            obj.Add(nuevo);
            ordena();
            sobreescribe_archivo();
            //sobreescribEntidades();
            //sobreescribAtributos(list_entidades[iEnt]);
        }
        public void guardaAtrib(Atributo a)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(Fullname, FileMode.Append)))
            {
                //writer.Seek(Convert.ToInt32( a.DirAtributo), SeekOrigin.Begin);
                writer.Write(a.Nombre);
                writer.Write(a.DirAtributo);
                writer.Write(a.Tipo);
                writer.Write(a.Longitud);
                writer.Write(a.TipoIndice);
                writer.Write(a.DirIndice);
                writer.Write(a.DirSig);
            }
        } 
        public void sobreescribAtributo(Atributo a)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(Fullname, FileMode.Open)))
            {
                Console.WriteLine(a.sNombre + "  " + a.DirAtributo + " " + a.DirIndice);
                writer.Seek(Convert.ToInt32(a.DirAtributo), SeekOrigin.Begin);
                writer.Write(a.Nombre);
                writer.Write(a.DirAtributo);
                writer.Write(a.Tipo);
                writer.Write(a.Longitud);
                writer.Write(a.TipoIndice);
                writer.Write(a.DirIndice);
                writer.Write(a.DirSig);
            }
            
        }
        
        public Atributo leeAtributo(BinaryReader reader, string name, long dir)
        {
            char tipo;
            long dirIn, dirsig;
            int l, tipoI;

            tipo = reader.ReadChar();
            l = reader.ReadInt32();
            tipoI = reader.ReadInt32();
            dirIn = reader.ReadInt64();
            dirsig = reader.ReadInt64();

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}", name, dir, tipo, l, tipoI, dirIn, dirsig);
            return new Atributo(name, dir, tipo, l, tipoI, dirIn, dirsig);
        }
        public bool eliminaAtributo(string e, int i)
        {
            Entidad ent = list_entidades.Find(x => x.sNombre.Contains(e));
            long ds = ent.Atrib[i].DirSig;
            Atributo a = ent.Atrib[i];
            foreach (Entidad auxE in EntidadesInser)
            {
                if(auxE.Sec != null)
                    foreach(Controladores.Secundario auxA in auxE.Sec)
                    {
                        if(auxA.Atributo == a)
                        {
                            return false;
                        }
                    }
            }
            if (i > 0)// no es el primer elemento
            {
                ent.Atrib[i - 1].DirSig = ds;
                ent.Atrib[i].DirSig = -1;
            }
            else // si es el primer elemento
            {
                if (ent.Atrib.Count == 1) //y solo tiene ese elemento
                    ent.Dir_Atributos = -1;
                else
                    ent.Dir_Atributos = ent.Atrib[i + 1].DirAtributo;
                ent.Atrib[i].DirSig = -1;
            }
            ent.Atrib.RemoveAt(i);
            sobreescribe_archivo();
            return true;
            
            return false;
            
        }
        #endregion
 
    }
}
