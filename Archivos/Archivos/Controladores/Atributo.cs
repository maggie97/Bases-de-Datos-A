using Archivos.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Atributo
    {
        char[] nombre = new char[30];
        long dirAtributo = -1, dirSig = -1, dirIndice = -1;
        char tipo;
        int longitud;
        int tipoIndice = 0;
        Indice ind; 
        public Atributo(string nombre, long dirAtributo, int tipo, int longitud, int tipoIndice, long dirIndice, long dirs)
        {
            for (int i = 0; i < 30; i++)
            {
                if (nombre.Length > i)
                    this.nombre[i] = nombre[i];
                else
                    this.nombre[i] = ' ';
            }
            this.dirAtributo = dirAtributo;
            this.tipo = (char)tipo;
            switch (tipo)
            {
                case 0:
                    this.tipo = 'C';
                    break;
                case 1:
                    this.tipo = 'E';
                    break;
                case 2:
                    this.tipo = 'F';
                    break;
            }
            this.longitud = longitud;
            this.tipoIndice = tipoIndice;
            
            this.dirIndice = dirIndice;
            dirSig = dirs; 
        }

        public char[] Nombre { get => nombre; set => nombre = value; }
        public long DirAtributo { get => dirAtributo; set => dirAtributo = value; }
        public char Tipo { get => tipo; set => tipo = value; }
        public int Longitud { get => longitud; set => longitud = value; }
        public int TipoIndice { get => tipoIndice; set => tipoIndice = value; }

        public string sNombre
        {
            get
            {
                string nom = "";
                for (int i = 0; i < 30; i++)
                {
                    if (nombre[i] > -1)
                        nom += nombre[i].ToString();
                }
                return nom;
            }
        }

        public long DirSig { get => dirSig; set => dirSig = value; }
        public long DirIndice { get => dirIndice; set => dirIndice = value; }
        public Indice Ind { get => ind; set => ind = value; }
        /*
        public Indice creaIndice(int i )
        {
            if (ind != null) return ind;
            switch (tipoIndice)
            {
                case 2:
                    dirIndice = 0;
                    ind = new Primario(this, (this.tipo == 'C'), sNombre, i, longitud);
                    break;
                case 3:
                    ind = new Secundario(sNombre, i);
                    break;
            }
            return ind;
        }*/
    }
}
