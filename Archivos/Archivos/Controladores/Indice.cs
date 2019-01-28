using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos.Controladores
{
    public abstract class Indice : Archivo
    {
        public int index = 0;
        protected Atributo atrib;

        public Indice(string Nombre, int i, Atributo a) : base(Nombre + ".idx")
        {
            index = i;
            atrib = a;
        }

        public Atributo Atributo { get => atrib; }
    }
}
