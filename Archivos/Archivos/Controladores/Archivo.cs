using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Archivos
{
    public class Archivo
    {

        string fullname;
        
        public long Longitud { get { using(FileStream a = new FileStream(Fullname, FileMode.Open)) return a.Length; } }
        public string Fullname { get => fullname; set => fullname = value; }

        public Archivo(string filename, string extencion, string direccion)
        {
            Fullname = direccion + "\\" +  filename + extencion;
            nuevoArch();
        }

        public Archivo(string fullname)
        {
            this.fullname = fullname;
            //nuevoArch();
        }


        public void nuevoArch()
        {
            using(FileStream f = new FileStream(Fullname, FileMode.Create))
            {

            }
        }

        public void elimina()
        {
            File.Delete(fullname);
        }       
    }
}
