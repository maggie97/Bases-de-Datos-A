using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDA.Controladores
{
    class Consulta
    {
        private List<Entidad> entidades;
        public Entidad tablaOut;
        private Entidad tablaQuery;
        //private string atributos;
        private List<Atributo> atributos;
        public Consulta(string consulta, DDD dic)
        {
            atributos = new List<Atributo>();
            string[] c = consulta.Split(' ');
            int val = consulta.IndexOf(' ');
            if (c.Contains("SELECT") && c.Contains("FROM"))
            {
                string a = "", s;
                if (consulta.IndexOf("SELECT") != consulta.LastIndexOf("SELECT"))
                {
                    int inic = consulta.IndexOf('('), fin = consulta.IndexOf(')');
                    a = consulta.Substring(inic + 1, fin - inic - 1);
                    //consulta.Remove(inic, fin - inic + 1);
                    Consulta con = new Consulta(a, dic);
                    tablaQuery = con.tablaOut;
                }
                else
                    tablaQuery = dic.EntidadesOrden.Find(o => o.shortName.CompareTo( c.Last() ) == 0);
                
                //string atributo = consulta.Substring(consulta.IndexOf("SELECT"));
                int v = 1;
                while (tablaQuery != null && v != -1 )
                {
                    if (c[v].CompareTo("*") == 0)  atributos.AddRange(tablaQuery.Atrib);
                    else
                    {
                        Atributo atr = tablaQuery.Atrib.Find(o => o.sNombre.Contains(c[v]));
                        atributos.Add(atr);
                    }
                    
                    v = (c[v + 1].CompareTo("FROM") == 0) ? v = -1 : v++;
                }
                if (c.Contains("WHERE")) ;// si hay un where  
                
                List<List<string>> reg = new List<List<string>>();

                tablaOut = new Entidad(atributos, registros(atributos, tablaQuery));
               
            }
        }
        public List<List<string>> registros(List<Atributo> a, Entidad e)
        {
            List<List<string>> r = new List<List<string>>();
            List<int> pos = new List<int>();
            pos.Add(0);
            for (int i = 0; i < e.Atrib.Count ; i++)
            {
                if(a.Contains(e.Atrib[i]))
                    pos.Add(i+1);
            }
            pos.Add(e.Atrib.Count);
            //for(int i = 0; i <  e.Registros.Count ; i++)
            foreach(List<string> ls in e.Registros)
            {
                List<string> s = new List<string>();

                foreach (int j in pos)
                    s.Add(ls[j]);
                
                r.Add(s);
            }
            return r;
        }

    }
}
