using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDA.Controladores
{
    enum Index { Primario_Principal, Primario_Cajon,Secundario_Principal, Secundario_Cajon, HashD, Multilistas}
    public class Cajon_Primario
    {
        char[] ind; //si es cajon principal del primario contien del rango de [A-Z] o [0-9]
        List<List<char>> cv; //sabe 
        string[] cb; //las claves de busqueda si se llegan a usar 
        long[] ap;//apuntadores del registro 
        int longitud = 0;//cantidad  de registros que puede almacenar 
        public char c = '\0';
        Index op;

        //crea el bloque principal del indice primario
        public Cajon_Primario(int op)
        {
            this.op = Index.Primario_Principal;
            longitud = (op == 0) ? 26 : (op == 1)? 9: 0;
            ind =  new char[longitud]; 
            ap = new long[longitud];
            int inicia = (op == 1) ? 49 : 65;
            for (int i = 0;i< longitud; i ++)
            {
                ind[i] = Convert.ToChar(inicia);
                ap[i] = -1;
                inicia++;
            }  
        }
        //crea el bloque que se enlaza con el bloque principal (todo vacio)
        public Cajon_Primario(Atributo a)
        {
            if (a.TipoIndice == 2)
            {
                creaBloqPrimario(a.Longitud, (a.Tipo == 'C'));
            }
        }

        //crea el bloque primario que se enlaza con el principal del primario pero insertando el primer elemento
        public Cajon_Primario(string claveBusq, long apuntador, int long_clave)
        {
            creaBloqPrimario(long_clave, !Int32.TryParse(claveBusq, out int a));
            inserta(claveBusq, apuntador);
        }
        public void creaBloqPrimario(int long_clave, bool cadena)
        {
            this.op = Index.Primario_Cajon;
            longitud = 50;
            cv = new List<List<char>>();
            cb = new string[longitud];
            ap = new long[longitud];
            for (int i = 0; i < longitud; i++)
            {
                string s = "";
                if (cadena)
                    while (s.Length < long_clave - 1) s += " ";
                else
                    while (s.Length < long_clave - 1) s += '0';
                cb[i] = s;
                ap[i] = -1;
            }
            
        }
        public void inserta(string claveBusq, long apuntador)
        {
            int i = 0;
            while (i < longitud)
            {
                if (ap[i] == -1)//cb[i].Contains("aux" ))
                {
                    string s = claveBusq;
                    while (s.Length < cb[i].Length) s += " ";
                    cb[i] = s;
                    ap[i] = apuntador;
                    break;
                }
                i++;
            }
        }
        public char[] Ind { get => ind; set => ind = value; }
        public long[] Ap { get => ap; set => ap = value; }
        public int Longitud { get => longitud; set => longitud = value; }
        public string[] Cb { get => cb; set => cb = value; }
    }
}
