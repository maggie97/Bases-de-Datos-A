using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDA.Controladores
{
    
    class Cajon_Secundario 
    {
        int capacidad = 100;
        int tam_Campo;
        List<Elemento> elementos;
        List<long> ap;
        Atributo atrib;
        long sig = -1;
        int tope = 0;
        int bit = 0;

        public Cajon_Secundario(long p)
        {
            ap = new List<long>();
            ap.Add(p);
            for (int i = 1; i < capacidad; i++)
            {
                ap.Add(-1);
            }
        }

        public Cajon_Secundario(Atributo a)
        {
            this.tam_Campo = a.Longitud;
            elementos = new List<Elemento>();
            for (int i = 0; i < capacidad; i++)
            {
                elementos.Add(new Elemento(a.Longitud));
            }
        }
        public Cajon_Secundario(Atributo a, int n)
        {
            this.tam_Campo = a.Longitud;
            elementos = new List<Elemento>();
            capacidad = 20;
            for (int i = 0; i < capacidad; i++)
            {
                elementos.Add(new Elemento("-1", -1));
            }
        }
        public int Capacidad { get => capacidad; }
        public int Tam_Campo { get => tam_Campo; }
        public List<long> Ap { get => ap; set => ap = value; }
        public long Sig { get => sig; set => sig = value; }
        public int Tope { get => tope; set => tope = value; }
        public int Bit { get => bit; set => bit = value; }
        internal List<Elemento> Elementos { get => elementos; set => elementos = value; }

    }

    class Elemento
    {
        string cb;
        long ap;

        public string Cb { get => cb; set => cb = value; }
        public long Ap { get => ap; set => ap = value; }

        public Elemento(string cb, long ap)
        {
            this.cb = cb;
            this.ap = ap;
        }
        public Elemento(int _long)
        {
            cb = "";
            while (cb.Length < _long) cb += " ";
            ap = -1;
        }

        public override bool Equals(object obj)
        {
            var elemento = obj as Elemento;
            return elemento != null &&
                   cb == elemento.cb &&
                   ap == elemento.ap;
        }

        public override int GetHashCode()
        {
            var hashCode = 1179118052;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cb);
            hashCode = hashCode * -1521134295 + ap.GetHashCode();
            return hashCode;
        }
    }
}
