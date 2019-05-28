using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDA.Controladores
{
    class indAtrib
    {
        public int i;
        public Atributo a;

        public indAtrib(int i, Atributo a)
        {
            this.i = i;
            this.a = a ?? throw new ArgumentNullException(nameof(a));
        }
    }
    class Consulta
    {
        private List<Entidad> entidades;
        public Entidad tablaOut;
        private Entidad tablaQuery;
        private Entidad tablaJoin;

        List<object> cond  = new List<object>();
        List<indAtrib> iQ = new List<indAtrib>(), iJ = new List<indAtrib>();
        bool join = false;
        public string error = "";
        //private string atributos;
        private List<Atributo> atributos;
        public Consulta(string consulta, DDD dic)
        {
            atributos = new List<Atributo>();
            string[] c = consulta.Split(' ');
            int val = consulta.IndexOf(' ');
            if (c.Contains("SELECT") && c.Contains("FROM"))
            {
                if (consulta.IndexOf("SELECT") != consulta.LastIndexOf("SELECT"))
                {
                    string a = "";
                    int inic = consulta.IndexOf('('), fin = consulta.IndexOf(')');
                    a = consulta.Substring(inic + 1, fin - inic - 1);
                    //consulta.Remove(inic, fin - inic + 1);
                    Consulta con = new Consulta(a, dic);
                    tablaQuery = con.tablaOut;
                }
                else
                {
                    //if (!c.Contains("WHERE"))
                    //    tablaQuery = dic.EntidadesOrden.Find(o => o.shortName.CompareTo(c.Last()) == 0);
                    //else
                    {
                        int i;
                        for (i = 0; i < c.Length && c[i].CompareTo("FROM") != 0; i++) ;
                        tablaQuery = dic.EntidadesOrden.Find(o => o.shortName.CompareTo(c[i + 1]) == 0);

                    }
                    if (tablaQuery == null)
                        error += "Error: Tabla no encontrada \t\n";
                }
                join = joinOn(c, dic);
                //string atributo = consulta.Substring(consulta.IndexOf("SELECT"));
                int v = 1;
                if (tablaQuery == null) return;
                while (error == "" && tablaQuery != null && c[v].CompareTo("FROM") != 0)
                {
                    if (!join && c[v].CompareTo("*") == 0) atributos.AddRange(tablaQuery.Atrib);
                    else if (!join)
                    {
                        Atributo atr;//= tablaQuery.Atrib.Find(o => o.sNombre.Contains(c[v]));
                        if ((atr = tablaQuery.Atrib.Find(o => o.sNombre.Contains(c[v]))) != null)
                            atributos.Add(atr);
                        else
                            error += "Error: Atributo no encontrado";
                    }
                    else if (join) //si hay join 
                    {
                        
                        //recuperamos el campo a checar 
                        string[] a = c[v].Split('.');
                        if (tablaQuery.shortName.CompareTo(a.First()) == 0) // si esta en la tabla query entra 
                            buscaAtributo(tablaQuery, a.Last());
                        else if (tablaJoin.shortName.CompareTo(a.First()) == 0) // Si esta en la tabla join entra 
                            buscaAtributo(tablaJoin, a.Last());
                        else // si no esta en ninguna es error 
                            error += "Error: Tabla no declarada en la sentencia";
                    }
                    else
                        error += "Error: Sintaxis";
                    v++;
                }
                if (error != "") return;

                
                //Join on 

                //sin join on 
                if (!join)
                {
                    tablaOut = new Entidad(atributos, registros(atributos, tablaQuery));
                    where(v, c);
                }
                else
                {
                    //var res = regQ.Select();
                    var reg = registros();
                    if(reg != null)
                        tablaOut = new Entidad(atributos, registros());
                }
                {
                    /*if (c.Contains("WHERE"))// si hay un where  
                    {
                        v += 2;
                        do
                        {
                            v++;
                            //No encuentra el atributo coorrecto
                            Atributo atri = atributos.Find(o => o.sNombre.CompareTo(c[v]) != 0);//tablaOut.Atrib.Find(o => o.sNombre.Contains(c[v]));
                            int index = atributos.IndexOf(atri);
                            v++;
                            string op = c[v];
                            v++;
                            string com = c[v];
                            for (int i = 0; error == "" && i < tablaOut.Registros.Count; i++)
                            {
                                List<string> r = tablaOut.Registros[i];
                                switch (op)
                                {
                                    case ">":
                                        if (Convert.ToInt32(com) >= Convert.ToInt32(r[index + 1]))
                                        {
                                            tablaOut.Registros.Remove(r);
                                            i--;
                                        }
                                        break;
                                    case "<":
                                        if (Convert.ToInt32(com) <= Convert.ToInt32(r[index + 1]))
                                        {
                                            tablaOut.Registros.Remove(r);
                                            i--;
                                        }
                                        break;
                                    case "=":
                                        if (com != r[index + 1])
                                        {
                                            tablaOut.Registros.Remove(r);
                                            i--;
                                        }
                                        break;
                                    case "<>":
                                        if (com == r[index + 1])
                                        {
                                            tablaOut.Registros.Remove(r);
                                            i--;
                                        }
                                        break;
                                    case "<=":
                                        if (Convert.ToInt32(com) < Convert.ToInt32(r[index + 1]))
                                        {
                                            tablaOut.Registros.Remove(r);
                                            i--;
                                        }
                                        break;
                                    case ">=":
                                        if (Convert.ToInt32(com) > Convert.ToInt32(r[index + 1]))
                                        {
                                            tablaOut.Registros.Remove(r);
                                            i--;
                                        }
                                        break;
                                    default:
                                        error += "Error: Sintaxis";
                                        break;
                                }
                            }

                            //v++;
                        } while (v + 3 < c.Length);
                    }*/
                }
            }
            else
                error += "Error: Síntaxis";
        }
        private void buscaAtributo(Entidad tabla, string name)
        {
            Atributo atr; //variable del atributo 
            if ((atr = tabla.Atrib.Find(o => o.sNombre.Split(' ')[0].CompareTo(name) == 0)) != null)
            {
                atributos.Add(atr);
                int x = tabla.Atrib.FindIndex(o => o.sNombre.Split(' ')[0].CompareTo(name) == 0);
                if (tabla == tablaQuery)
                    iQ.Add(new indAtrib(x, atr));
                else
                    iJ.Add(new indAtrib(x, atr));
            }
            else
                error += "Error: Atributo no encontrado";
        }

        private bool joinOn(string[] c, DDD dic)
        {
            int inner = -1, join = -1, on = -1, from = -1;
            inner = Array.IndexOf(c, "INNER");
            join = Array.IndexOf(c, "JOIN");
            on = Array.IndexOf(c, "ON");

            from = Array.IndexOf(c, "FROM");

            if( from + 1 < inner && inner < join  && join + 1 < on  )
            {
                //la sentencia del inner join esta completa y en el orden correspondiente.
                if (c[from + 1] != "" && c[join + 1] != "" && c[on + 1] != "") // si el nombre de las tablas no es vacio 
                {
                    //buscar las tablas la tabla del from ya esta es tablaOut 
                    tablaJoin = dic.EntidadesOrden.Find(o => o.shortName.CompareTo(c[join + 1]) == 0);
                    if (tablaQuery != null && tablaJoin != null)
                    {
                        // las tablas existen 
                        var atr1 = c[on + 1].Split('.');
                        var atr2 = c[on + 3].Split('.');
                        if (tablaQuery.shortName.CompareTo(atr1[0]) == 0)
                        {
                            cond.Add(tablaQuery);
                            var a = tablaQuery.Atrib.FindIndex(o => o.sNombre.Split(' ')[0].CompareTo(atr1[1]) == 0);
                            if (a > 0 && tablaQuery.Atrib[a].Tipo!='C')
                            {
                                cond.Add(a);
                                string exOp = "(=|>|<)";
                                if (new System.Text.RegularExpressions.Regex(exOp).IsMatch(c[on + 2]))
                                    cond.Add(c[on + 2]);
                            }
                            if (tablaJoin.shortName.CompareTo(atr2[0]) == 0)
                            {
                                cond.Add(tablaJoin);
                                a = tablaJoin.Atrib.FindIndex(o => o.sNombre.Split(' ')[0].CompareTo(atr2[1]) == 0);
                                if (a > 0 && tablaJoin.Atrib[a].Tipo != 'C')
                                {
                                    cond.Add(a);
                                }
                            }
                        }
                        else if (tablaJoin.shortName.CompareTo(atr1[0]) == 0)
                        {
                            cond.Add(tablaJoin);
                            var a = tablaJoin.Atrib.FindIndex(o => o.sNombre.Split(' ')[0].CompareTo(atr1[1]) == 0);
                            if (a >= 0 && tablaJoin.Atrib[a].Tipo != 'C')
                            {
                                cond.Add(a);
                                string exOp = "(=|>|<)";
                                if (new System.Text.RegularExpressions.Regex(exOp).IsMatch(c[on + 2]))
                                    cond.Add(c[on + 2]);
                            }

                            if (tablaQuery.shortName.CompareTo(atr2[0]) == 0)
                            {
                                cond.Add(tablaQuery);
                                a = tablaQuery.Atrib.FindIndex(o => o.sNombre.Split(' ')[0].CompareTo(atr2[1]) == 0);
                                if (a >= 0 && tablaQuery.Atrib[a].Tipo != 'C')
                                    cond.Add(a);
                            }
                        }

                        return true;
                    }
                }
                else
                    error += "Error: En INNER JOIN";
                //return true;
            }
            return false;
        }

        public List<List<string>> registros(List<Atributo> a, Entidad e)
        {
            try
            {
                List<List<string>> r = new List<List<string>>();
                List<int> pos = new List<int>();
                pos.Add(0);
                for (int i = 0; i < e.Atrib.Count; i++)
                {
                    if (a.Contains(e.Atrib[i]))
                        pos.Add(i + 1);
                }
                pos.Add(e.Atrib.Count);
                //for(int i = 0; i <  e.Registros.Count ; i++)
                foreach (List<string> ls in e.Registros)
                {
                    List<string> s = new List<string>();

                    foreach (int j in pos)
                        s.Add(ls[j]);

                    r.Add(s);
                }
                return r;
            }
            catch (Exception ex)
            {
                
            }
            return null;
        }

        public List<List<string>> registros()
        {
            try
            {
                List<List<string>> r = new List<List<string>>();
                int idQ = -1, idJ = -1;
                string op;
                if (cond.Count < 5)
                {
                    error = "Error: En condicion del join";
                    return new List<List<string>>();
                }
                op = (string)cond[2];
                if ((Entidad)(cond[0]) == tablaQuery) {
                    idQ = (int)cond[2];
                    idJ = (int)cond[4];
                }
                else
                {
                    idJ = (int)cond[1];
                    idQ = (int)cond[4];
                }

                foreach (List<string> rQ in tablaQuery.Registros)
                {
                    List<string> s = new List<string>();
                    s.Add("0");
                    foreach (var j in iQ)
                        s.Add(rQ[j.i + 1] );
                    foreach (List<string> rJ in tablaJoin.Registros)
                    {
                        List<string> regJoin = new List<string>(s);
                        
                        foreach (var j in iJ)
                            regJoin.Insert(atributos.IndexOf(j.a) + 1, rJ[j.i+1]);
                        regJoin.Add("0");
                        bool b = false;
                        switch (op)
                        {
                            case "=":
                                if (Convert.ToInt32(rQ[idQ+1]) == Convert.ToInt32(rJ[idJ+1]))
                                    b = true;
                                break;
                        }
                        if(b)
                            r.Add(regJoin);
                    }
                }
                return r;
            }
            catch (Exception ex)
            {
                error += ex;
            }
            return null;
        }

        private void where(int v, string[] c)
        {
            if (c.Contains("WHERE"))// si hay un where  
            {
                v += 2;
                do
                {
                    v++;
                    //No encuentra el atributo coorrecto
                    Atributo atri = atributos.Find(o => o.sNombre.CompareTo(c[v]) != 0);//tablaOut.Atrib.Find(o => o.sNombre.Contains(c[v]));
                    int index = atributos.IndexOf(atri);
                    v++;
                    string op = c[v];
                    v++;
                    string com = c[v];
                    for (int i = 0; error == "" && i < tablaOut.Registros.Count; i++)
                    {
                        List<string> r = tablaOut.Registros[i];
                        switch (op)
                        {
                            case ">":
                                if (Convert.ToInt32(com) >= Convert.ToInt32(r[index + 1]))
                                {
                                    tablaOut.Registros.Remove(r);
                                    i--;
                                }
                                break;
                            case "<":
                                if (Convert.ToInt32(com) <= Convert.ToInt32(r[index + 1]))
                                {
                                    tablaOut.Registros.Remove(r);
                                    i--;
                                }
                                break;
                            case "=":
                                if (com != r[index + 1])
                                {
                                    tablaOut.Registros.Remove(r);
                                    i--;
                                }
                                break;
                            case "<>":
                                if (com == r[index + 1])
                                {
                                    tablaOut.Registros.Remove(r);
                                    i--;
                                }
                                break;
                            case "<=":
                                if (Convert.ToInt32(com) < Convert.ToInt32(r[index + 1]))
                                {
                                    tablaOut.Registros.Remove(r);
                                    i--;
                                }
                                break;
                            case ">=":
                                if (Convert.ToInt32(com) > Convert.ToInt32(r[index + 1]))
                                {
                                    tablaOut.Registros.Remove(r);
                                    i--;
                                }
                                break;
                            default:
                                error += "Error: Sintaxis";
                                break;
                        }
                    }
                    //v++;
                } while (v + 3 < c.Length);
            }
        }

    }
}
