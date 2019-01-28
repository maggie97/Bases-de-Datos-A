using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos.Controladores
{
    class HashDinamico : Indice
    {
        int bit = 0;
        List<Elemento> principal;

        internal List<Elemento> Principal { get => principal; set => principal = value; }
        public int Bit { get => bit; set => bit = value; }

        public HashDinamico(Atributo a, string nomb, int ind): base (nomb, ind, a)
        {
            principal = new List<Elemento>();
            for(int i =0; i<64; i++)
            {
                var dato = Convert.ToString(i, 2);
                while (dato.Length < 6) dato = '0' + dato;
                principal.Add(new Elemento(dato, -1));
            }
            if (!File.Exists(nomb + ".idx"))
            {
                nuevoArch();
                a.DirIndice = 0;
                escribePrincipal((int)a.DirIndice);
            }
            else if (a.DirIndice == -1) //no existe hash y/o el arch 
            {
                a.DirIndice = Longitud;
                escribePrincipal((int)a.DirIndice);
            }
            else //existe hash y existe el archivo 
            {
                //hay que leerlo 
                leePrincipal(a.DirIndice);

            }
        }

        public void inserta(string cb, long reg)
        {
            var nuevos = bin(cb);//sCB.Substring(0, bit);
            long dir = -1;
            Cajon_Secundario c = null;
            bool insertado = false;
            while (!insertado)
            {
                nuevos = bin(cb);
                var a = principal.Find(o => o.Cb.Substring(0, Bit) == nuevos);
                if (a != null && a.Ap != -1)
                {
                    //Lee el cajon
                    c = leeCajon(a.Ap);
                    dir = a.Ap;
                    if (c != null)
                    {
                        if (c.Tope < c.Capacidad)
                        {
                            c.Elementos[c.Tope] = new Elemento(cb, reg);
                            c.Tope++;
                            //c.Elementos = c.Elementos.OrderBy(o => o.Cb).ToList();
                            c.Elementos.Sort(delegate (Elemento x, Elemento y)
                            {
                                // Sort by total in descending order
                                int res = 1;
                                if (x.Cb != "-1")
                                    res = y.Cb.CompareTo(x.Cb);
                                return res;
                            });
                            //c.Elementos.Sort((a, b)=>  Int32.Parse(o.Cb)).ToList();
                            insertado = true;
                        }
                        else if (c.Bit < 6)
                        {
                            //nuevo cajon
                            if(bit< 6)
                                Bit++;
                            c.Bit++;
                            var b = a.Cb.Substring(0, c.Bit);
                            var v = principal.FindAll(o => o.Ap == a.Ap);
                            var col = v.FindAll(o => v.IndexOf(o) < v.Count / 2);
                            var comparat = v[col.Count];
                            b = comparat.Cb.Substring(0, c.Bit);
                            //duplicamos el cajon y dividimos valores segun correspondan 
                            Cajon_Secundario copia = divideValores(c, b);
                            
                            var x = v.Find(o => o.Cb.Substring(0, c.Bit) != b);
                            b = x.Cb.Substring(0, c.Bit);
                            //dir = Longitud;

                            //direccion de el nuevo cajon 
                            for (int i = 0; i < v.Count; i++)
                            {
                                var bits = v[i].Cb.Substring(0, c.Bit);
                                //if (bits == b)
                                if(col.FindIndex(o=>o.Cb == v[i].Cb)< 0)
                                {
                                    v[i].Ap = Longitud;
                                }
                            }
                            escribePrincipal((int)atrib.DirIndice);
                            escribeCajon((int)Longitud, copia);
                            escribeCajon((int)dir, c);
                        }
                        else if(c.Sig == -1)
                        {
                            c.Sig = Longitud;
                            escribeCajon((int)dir, c);
                            c = new Cajon_Secundario(atrib, 0);
                            c.Bit = 6;
                            dir = Longitud;
                            c.Elementos[0] = new Elemento(cb, reg);
                            c.Tope++;
                            insertado = true;
                        }
                        else
                        {
                            a.Ap = c.Sig;
                        }
                    }
                }
                else
                {
                    //principal[tope] = new Elemento(cb, Longitud);
                    c = new Cajon_Secundario(atrib, 0);
                    dir = Longitud;
                    c.Elementos[0] = new Elemento(cb, reg);
                    c.Tope++;
                    insertado = true;
                    for (int i = 0; i < principal.Count; i++)
                    {
                        var bits = principal[i].Cb.Substring(0, Bit);
                        if (bits == nuevos)
                        {
                            principal[i].Ap = Longitud;
                        }
                    }
                    escribePrincipal((int)atrib.DirIndice);

                }
            }
            escribeCajon((int)dir, c);
        }
        public string bin(string cb)
        {
            var s = cb[0];
            var sCB = Convert.ToString(Int32.Parse(s.ToString()), 2);
            while (sCB.Length < 4) sCB = '0' + sCB;
            if (Bit < 4)
            {
                while (sCB.Length < 6) sCB += '0';
            }
            else
            {
                if (cb == "0")
                    s = '0';
                else 
                    s = cb[1];
                var s2 = Convert.ToString(Int32.Parse(s.ToString()), 2);

                //sCB += s2.Substring(0, 2);
                while (s2.Length < 4) s2 = '0' + s2;
                sCB += s2.Substring(0, 2);
            }
            return sCB.Substring(0, Bit);
        }

        public Cajon_Secundario divideValores(Cajon_Secundario c, string div)
        {
            Cajon_Secundario _d = new Cajon_Secundario(atrib, 0);
            _d.Bit = c.Bit;
            //_d.Elementos.CopyTo(c.Elementos.ToArray());
            for (int i = 0; i< c.Capacidad; i++)
            {
                if(c.Elementos[i].Ap != -1)
                {
                    var num = bin(c.Elementos[i].Cb).Substring(0, c.Bit);
                    
                    if(num == div)
                    {
                        _d.Elementos.RemoveAt(_d.Tope);
                        _d.Elementos.Insert(_d.Tope, c.Elementos[i]);
                        
                        c.Elementos.RemoveAt(i);
                        c.Elementos.Add(new Elemento("0", -1));
                        _d.Tope++;
                        c.Tope--;
                        i--;
                    }
                }
            }
            return _d ;
        }


        public void escribePrincipal(int l)
        {
            using (BinaryWriter b = new BinaryWriter(File.Open(Fullname, FileMode.Open)))
            {
                b.Seek(l, SeekOrigin.Begin);
                for (int i = 0; i < principal.Count; i++)
                {
                    b.Write(principal[i].Cb.ToArray(), 0, 6);
                    b.Write(principal[i].Ap);
                }
                b.Write(bit);
            }
        }

        public void escribeCajon(int l, Cajon_Secundario c)
        {
            using (BinaryWriter b = new BinaryWriter(File.Open(Fullname, FileMode.Open)))
            {
                b.Seek(l, SeekOrigin.Begin);
                for (int j = 0; j < c.Capacidad; j++)
                {
                    b.Write(Int32.Parse(c.Elementos[j].Cb));
                    b.Write(c.Elementos[j].Ap);
                }
                b.Write(c.Sig);
                b.Write(c.Bit);
            }
        }
        public void leePrincipal(long l)
        {
            principal = new List<Elemento>();
            for (int i = 0; i < 64; i++)
            {
                var dato = Convert.ToString(i, 2);
                while (dato.Length < 6) dato = '0' + dato;
                principal.Add(new Elemento(dato, -1));
            }

            using (BinaryReader r = new BinaryReader(File.Open(Fullname, FileMode.Open)))
            {
                r.BaseStream.Seek(l, SeekOrigin.Begin);
                Console.WriteLine(r.PeekChar());
                for (int i = 0; i < principal.Count; i++)
                {
                    char[] cb = r.ReadChars(6);
                    Console.WriteLine(cb.ToArray());
                    string s = "";
                    while (s.Length < cb.Length) s += cb[s.Length];
                    long ap = r.ReadInt64();
                    Console.WriteLine(ap);
                    if (ap != -1)
                    {
                        principal[i].Cb = s;
                        principal[i].Ap = ap;
                    }
                }
                bit = r.ReadInt32();
            }
        }
        public Cajon_Secundario leeCajon(long l)
        {
            Cajon_Secundario c = new Cajon_Secundario(atrib, 0);
            using (BinaryReader r = new BinaryReader(File.Open(Fullname, FileMode.Open)))
            {
                r.BaseStream.Seek(l, SeekOrigin.Begin);
                //Console.WriteLine(r.PeekChar());  
                for (int i = 0; i < 20; i++)
                {
                    //char[] cb =//r.ReadChars(atrib.Longitud );
                    int cb = r.ReadInt32();
                    Console.WriteLine(cb);
                    string s = cb.ToString();
                   // string s = "";
                   // while (s.Length < cb.Length) c;
                    long ap = r.ReadInt64();
                    Console.WriteLine(ap);
                    if (ap != -1)
                    {
                        //inserta(s, ap);
                        //if (i == 0) c = new Cajon_Secundario(atrib, 0);
                        c.Elementos[i].Cb =  s;
                        c.Elementos[i].Ap = ap;
                        c.Tope++;
                    }
                }
                if(c!= null)
                {
                    c.Sig = r.ReadInt64();
                    c.Bit = r.ReadInt32();
                }
            }
            return c;
        }
    }
}
