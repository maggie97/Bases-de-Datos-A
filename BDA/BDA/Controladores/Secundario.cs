using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDA.Controladores
{
    class Secundario : Indice
    {
        List<Cajon_Secundario> principal;
        int capacidad = 100;
        int tope = 0;
        public Secundario(Atributo a, string nombre, int i): base (nombre, i, a)
        {
            if(!File.Exists(nombre + ".idx"))
            {
                nuevoArch();
                a.DirIndice = 0;
                principal = new List<Cajon_Secundario>();
                principal.Add(new Cajon_Secundario(a));
                escribeSecundario((int)a.DirIndice);
            }
            else if(a.DirIndice < 0)
            {
                a.DirIndice = Longitud;
                principal = new List<Cajon_Secundario>();
                principal.Add(new Cajon_Secundario(a));
                escribeSecundario((int)a.DirIndice);
            }
            else
            {
                leeBloquePrincipal(a.DirIndice);
            }
        }

        internal List<Cajon_Secundario> Principal { get => principal; set => principal = value; }
        public void insertaEscribe(string cb, long reg)
        {
            var c = inserta(cb, reg);
            if (c[0] != null && (long)c[1] > 0)
            {
                principal = ordenaPrincipal();
                escribeSecundario((int)atrib.DirIndice);
                escribeCajon((Cajon_Secundario)c[0], (long)c[1]);
            }
        }
        public Object[] inserta(string cb, long reg)
        {
            Cajon_Secundario c = null;
            long dir = -1;
            while (cb.Length < principal[0].Elementos.Last().Cb.Length) cb += " ";
            if (tope < capacidad)
            {
                if (tope == 0 )
                {
                   
                    principal.Last().Elementos[tope] = new Elemento(cb, Longitud);
                    c = new Cajon_Secundario(reg);
                    dir = Longitud;
                    tope++;
                }
                else
                {
                    var a = principal.Last().Elementos.Find(o => o.Cb == cb);
                    if(a != null)
                    {
                        //Lee el cajon
                        c = leeCajon(a.Ap);
                        dir = a.Ap;
                        int ind = c.Ap.FindIndex(o => o == -1);
                        if(c.Ap.FindIndex(o => o == reg) < 0)
                            c.Ap[ind] = reg;
                    }
                    else
                    {
                        principal.Last().Elementos[tope] = new Elemento(cb, Longitud);
                        c = new Cajon_Secundario(reg);
                        dir = Longitud;
                        tope++;
                    }
                }
            }
            else
            {

            }
            return new object[] { c, dir};
        }
        public void elimina(string dato, long reg)
        {
            var a = principal.Last().Elementos.Find(o => o.Cb.Contains(dato));
            if(a  != null){
                var c = leeCajon(a.Ap);
                if (c != null)
                {
                    int i = c.Ap.FindIndex(o => o == reg);
                    if (i >= 0)
                    {
                        c.Ap[i] = -1;
                        c = ordenaCajon(c);
                        escribeCajon(c, a.Ap);
                        if (c.Ap[0] == -1 )
                        {
                            int j = Principal.Last().Elementos.FindIndex(o => o.Cb == a.Cb);
                            a = new Elemento(a.Cb.Length);

                            principal.Last().Elementos[j] = a;

                            principal = ordenaPrincipal();
                            escribeSecundario((int)atrib.DirIndice);
                        }
                    }
                }
            }
        }

        public void escribeSecundario(int l)
        {
            using (BinaryWriter b = new BinaryWriter(File.Open(Fullname, FileMode.Open)))
            {
                b.Seek(l, SeekOrigin.Begin);
                for (int i = 0; i < principal.Count; i++)
                {
                    for(int j = 0; j < principal[i].Capacidad; j++)
                    {
                        b.Write(principal[i].Elementos[j].Cb.ToArray(), 0, atrib.Longitud);
                        b.Write(principal[i].Elementos[j].Ap);
                    }
                    b.Write(principal[i].Sig);
                }
            }
        }
        public void escribeCajon(Cajon_Secundario c, long l)
        {
            using (BinaryWriter b = new BinaryWriter(File.Open(Fullname, FileMode.Open)))
            {
                b.Seek((int)l, SeekOrigin.Begin);
                for (int i = 0; i < c.Capacidad; i++)
                {
                    b.Write(c.Ap[i]);
                }
            }
        }

        public void leeBloquePrincipal(long l)
        {
            tope = 0;
            principal = new List<Cajon_Secundario>();
            principal.Add(new Cajon_Secundario(atrib));
            //escribeSecundario((int)atrib.DirIndice);
            using (BinaryReader r = new BinaryReader(File.Open(Fullname, FileMode.Open)))
            {
                r.BaseStream.Seek(l, SeekOrigin.Begin);
                Console.WriteLine(r.PeekChar());
                //while (r.PeekChar() > 0)
                {
                    for (int i = 0; i < principal.Count; i++)
                    {
                        for (int j = 0; j < principal[i].Capacidad; j++)
                        {
                            char[] cb = r.ReadChars(atrib.Longitud );
                            Console.WriteLine(cb.ToArray());
                            string s = "";
                            while (s.Length < cb.Length) s += cb[s.Length];
                            //Console.WriteLine(r.PeekChar());
                            //List<char> ap = r.ReadChars(8).ToList();
                            long ap = r.ReadInt64();
                            //int ap = r.PeekChar();
                            
                            Console.WriteLine(r.BaseStream.Position);
                            Console.WriteLine(ap);
                            if (ap != -1)
                            {
                                //inserta(s, ap);
                                principal[i].Elementos[j].Cb = s;
                                principal[i].Elementos[j].Ap = ap;
                                tope++;
                            }
                        }
                        long p = r.ReadInt64();//r.PeekChar();//r.ReadInt64();
                        if (p != -1)
                        {
                            principal[i].Sig = p;
                            principal.Add(new Cajon_Secundario(atrib));
                        }
                        else
                            break;
                    }
                }
                /*for (int i = 0; i < principal.Capacidad; i++)
                {
                    //Console.WriteLine(r.PeekChar());
                    char[] cb = r.ReadChars(atrib.Longitud );
                    Console.WriteLine(cb.ToArray());
                    string s = "";
                    while (s.Length < cb.Length) s += cb[s.Length];
                    //Console.WriteLine(r.PeekChar());
                    //List<char> ap = r.ReadChars(8).ToList();
                    long ap = r.ReadInt64();
                    Console.WriteLine(ap);
                    if (ap != -1)
                    {
                        //inserta(s, ap);
                        principal.Elementos[i].Cb = s;
                        principal.Elementos[i].Ap = ap;
                        tope++;
                    }
                }*/
            }
        }
        public Cajon_Secundario leeCajon(long ap)
        {
            Cajon_Secundario c = null;
            using (BinaryReader r = new BinaryReader(File.Open(Fullname, FileMode.Open)))
            {
                r.BaseStream.Seek(ap, SeekOrigin.Begin);
                //Console.WriteLine(r.PeekChar());
                for (int i = 0; i < 100; i++)
                {
                    long p = r.ReadInt64();
                   //List<char> p = r.ReadChars(8).ToList();
                    Console.WriteLine(p);
                    if(p != -1)
                    {
                        if (i == 0) c = new Cajon_Secundario(p);
                        else c.Ap[i] = p;
                    }
                }
            }
            return c;
        }

        public List<Cajon_Secundario> ordenaPrincipal() // cajon principal
        {
            List<Cajon_Secundario> list = new List<Cajon_Secundario>();
            
            for (int k = 0; k < principal.Count; k++) {
                Cajon_Secundario c = principal[k];
                for (int i = 0; i < c.Capacidad - 1; i++)
                {
                    for (int j = 0; j < c.Capacidad - 1; j++)
                    {
                        if (atrib.Tipo == 'C')
                        {
                            if (c.Elementos[j].Cb.Contains('\u001d'))
                            {
                                string s = c.Elementos[j].Cb.Substring(c.Elementos[j].Cb.LastIndexOf('\u001d') + 1);
                                while (s.Length < c.Elementos[j].Cb.Length) s += " ";
                                c.Elementos[j].Cb = s;

                                s = c.Elementos[j + 1].Cb.Substring(c.Elementos[j].Cb.LastIndexOf('\u001d') + 1);
                                while (s.Length < c.Elementos[j].Cb.Length) s += " ";
                                c.Elementos[j + 1].Cb = s;
                            }
                            var act = c.Elementos[j].Cb;
                            var sig = c.Elementos[j + 1].Cb;
                            if (act.All(o => o == ' ') && sig.All(o => o == ' ')) { j = c.Capacidad - 1; }
                            else if (act.All(o => o == ' ') && !sig.All(o => o == ' '))
                            {
                                var a = c.Elementos[j + 1].Cb;
                                var p = c.Elementos[j + 1].Ap;
                                c.Elementos[j + 1].Cb = c.Elementos[j].Cb;
                                c.Elementos[j + 1].Ap = c.Elementos[j].Ap;
                                c.Elementos[j].Cb = a;
                                c.Elementos[j].Ap = p;
                            }
                            else if (act.CompareTo(sig) > 0 && !sig.All(o => o == ' ')) {
                                var a = c.Elementos[j].Cb;
                                var p = c.Elementos[j].Ap;
                                c.Elementos[j].Cb = c.Elementos[j + 1].Cb;
                                c.Elementos[j].Ap = c.Elementos[j + 1].Ap;
                                c.Elementos[j + 1].Cb = a;
                                c.Elementos[j + 1].Ap = p;
                            }
                        }
                    }
                }
                list.Add(c);
            }
            return list;
        }
        public Cajon_Secundario ordenaCajon(Cajon_Secundario c)
        {
            for (int i = 0; i < c.Capacidad - 1; i++)
            {
                for (int j = 0; j < c.Capacidad - 1; j++)
                {
                    var act = c.Ap[j];
                    var sig = c.Ap[j + 1];
                    if (sig < act && sig > 0)
                    {
                        var p = c.Ap[j];
                        c.Ap[j] = c.Ap[j + 1];
                        c.Ap[j + 1] = p;
                    }
                    else if (sig > act && act == -1)
                    {
                        var p = c.Ap[j + 1];
                        c.Ap[j + 1] = c.Ap[j];
                        c.Ap[j ] = p;
                    }
                }
            }
            return c;
        }
    }
}
