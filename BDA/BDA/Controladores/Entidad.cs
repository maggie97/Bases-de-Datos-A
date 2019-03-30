using BDA.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDA
{
    public class Entidad
    {
        char[] nombreEntidad = new char[30];
        long dir_Entidad = -1;
        long dir_Atributos = -1;
        long dir_Datos = -1;
        long dir_sig = -1;
        List<Atributo> atrib;
        List<List<string>> registros;

        int cve_busqeda = -1;
        Primario prim;
        List<Secundario> sec;

        public Entidad(char[] nombreEntidad, long dir_Entidad, long dir_Atributos, long dir_Datos)
        { 
            for (int i = 0; i < 30; i++)
            {
                if (nombreEntidad.Length > i)
                    this.nombreEntidad[i] = nombreEntidad[i];
                else
                    this.nombreEntidad[i] = ' ';
            }

            this.dir_Entidad = dir_Entidad;
            this.dir_Atributos = dir_Atributos;
            this.dir_Datos = dir_Datos;
            atrib = new List<Atributo>();
            registros = new List<List<string>>();
        } 
        public Entidad(char[] nombreEntidad, long dir_Entidad, long dir_Atributos, long dir_Datos, long dir_Sig)
        {
            //this.nombreEntidad = nombreEntidad;
            for (int i = 0; i < 30; i++)
            {
                if (nombreEntidad.Length > i)
                    this.nombreEntidad[i] = nombreEntidad[i];
                else
                    this.nombreEntidad[i] = ' ';
            }

            this.dir_Entidad = dir_Entidad;
            this.dir_Atributos = dir_Atributos;
            this.dir_Datos = dir_Datos;
            dir_sig = dir_Sig;
            atrib = new List<Atributo>();
        }

        public void nuevoA(Atributo a)
        {
            dir_Atributos = (atrib.Count == 0) ? a.DirAtributo : dir_Atributos;
            if(atrib.Count > 0)
                atrib.Last().DirSig = a.DirAtributo;
            atrib.Add(a);
        }

        public char[] NombreEntidad { get => nombreEntidad; set => nombreEntidad = value; }
        public long Dir_Entidad { get => dir_Entidad; set => dir_Entidad = value; }
        public long Dir_Atributos { get => dir_Atributos; set => dir_Atributos = value; }
        public long Dir_Datos { get => dir_Datos; set => dir_Datos = value; }
        public long Dir_sig { get => dir_sig; set => dir_sig = value; }
        public string sNombre
        {
            get
            {
                string nom = "";
                for (int i = 0; i < 30; i++)
                {
                    if (nombreEntidad[i] > -1 )
                        nom += nombreEntidad[i].ToString();
                }
                return nom;
            }
        }
        public string shortName
        {
            get => sNombre.Split(' ')[0];
        }

        public List<Atributo> Atrib { get => atrib; set => atrib = value; }
        public List<List<string>> Registros { get => registros; set => registros = value; }
        public Primario Prim { get => prim; set => prim = value; }
        internal List<Secundario> Sec { get => sec; set => sec = value; }

        internal void nuevoReg(List<string> atributos)
        {
            if (Registros == null || Registros.Count == 0)
            {
                registros = new List<List<string>>();
                Indice(1);
            }
            registros.Add(atributos);
            if (prim != null)
            {
                prim.inserta(atributos[prim.index + 1], Convert.ToInt64(atributos[0]));
            }
            if(sec != null)
            {
                foreach(var s in sec)
                {
                    s.insertaEscribe(atributos[s.index + 1], Convert.ToInt64(atributos[0]));
                }
            }
            Atributo a = atrib.Find(o => o.TipoIndice == 6);
            if (a != null && a.DirAtributo != -1)
            {
                HashDinamico h = (HashDinamico)a.Ind;
                h.inserta(atributos[h.index + 1], Convert.ToInt64(atributos[0]));
            }
            ordenaReg();
        }
        public void Indice(int op)
        {
            bool nuevoArch = false;
            if(!System.IO.File.Exists(sNombre + ".idx"))
            {
                for(int i = 0; i< atrib.Count; i++) 
                    atrib[i].DirIndice = -1;
            }
            Atributo a = null;
            if( (a = Atrib.Find(o => o.TipoIndice == 2)) != null){
                if (a.Ind == null)
                {
                    a.Ind = new Primario(a, (a.Tipo == 'C'), sNombre, Atrib.IndexOf(a), a.Longitud);
                }
                prim = (Primario)a.Ind;
            }
            if((a = Atrib.Find(o => o.TipoIndice == 3)) != null)
            {
                if(a.Ind == null)
                {
                    if (sec == null) sec = new List<Secundario>();
                    //if ()
                    if( sec.FindIndex(o=>o.Atributo == a) < 0)
                        a.Ind = new Secundario(a, sNombre, Atrib.IndexOf(a));
                }
                sec.Add((Secundario)a.Ind);
            }
            if((a = Atrib.Find(o => o.TipoIndice == 6)) != null) { 
                if(a.Ind == null)
                {
                    a.Ind = new HashDinamico(a, sNombre, Atrib.IndexOf(a));
                }

            }
            
        }
        public void ordenaReg()
        {
            if (atrib.Exists(o => o.TipoIndice == 1))
            {
                //ordena 
                int i = atrib.FindIndex(o => o.TipoIndice == 1);
                if (atrib[i].Tipo == 'C')
                    registros = registros.OrderBy(o => o[i + 1]).ToList();
                else
                    registros = registros.OrderBy(o => Convert.ToInt32(o[i + 1])).ToList();
                //registros.Sort((a, b) => (a[i].CompareTo(b[i])));
            }
            for (int i = 0; registros.Count > 0 && i < registros.Count; i++)
            {
                if (registros.Count - 1 == i)
                {
                    registros[i][atrib.Count + 1] = "-1";
                    break;
                }
                registros[i][atrib.Count + 1] = registros[i + 1].First();
            }
            if(registros.Count != 0) 
                dir_Datos = Convert.ToInt64(registros.First()[0]);
            else
                dir_Datos = -1 ;
        }
        public void EliminaRegistro(List<string> reg)
        {
            Registros.Remove(reg);
            if (prim != null)
            {
                int i = prim.index;
                var dat = reg[i+1];
                prim.elimina(dat);
            }
            if (sec != null)
            {
                foreach(var s in sec)
                {
                    var dat = reg[s.index + 1];
                    dat = dat.Substring(dat.LastIndexOf('\u001d') + 1 );
                    s.elimina(dat, Int64.Parse(reg[0]));
                }
            }

        }
    }
}
