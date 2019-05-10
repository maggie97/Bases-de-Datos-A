using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDA
{
    public partial class VRegistro : Form
    {
        Entidad e;
        ArchivoRegistros a;
        public VRegistro()
        {
            InitializeComponent();
        }

        public void VerTabla(Entidad entidad, Archivo arch)
        {
            e = entidad;
            a = (ArchivoRegistros)arch;
            Actualiza();
            
        }
        public void VerTabla(Entidad entidad)
        {
            e = entidad;

            dgTabla.Columns.Clear();
            foreach (Atributo a in e.Atrib)
                dgTabla.Columns.Add("col" + a.sNombre, a.sNombre);
            
            dgTabla.Rows.Clear();
           // if (e.Dir_Datos == -1) return;
            foreach (List<string> reg in e.Registros)
            {
                //string[] except = { reg.First(), reg.Last() };
                //string[] r = reg.Except(except).ToArray();
                reg.RemoveAt(0);
                reg.Remove(reg.Last());
                string[] r = reg.ToArray();
                dgTabla.Rows.Add(r);
            }
        }
        public void Actualiza()
        {
            dgTabla.Columns.Clear();
            foreach (Atributo a in e.Atrib)
            {
                dgTabla.Columns.Add("col" + a.sNombre, a.sNombre);
            }
            dgTabla.Rows.Clear();
            if (e.Dir_Datos == -1) return;
            else a.leerArch(e.Dir_Datos);
            foreach (List<string> reg in e.Registros)
            {
                string[] except = { reg.First(), reg.Last() };
                string[] r = reg.Except(except).ToArray();
                dgTabla.Rows.Add(r);
            }
            
        }
    }
}
