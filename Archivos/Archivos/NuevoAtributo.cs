using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivos
{
    public partial class NuevoAtributo : Form
    {
        
        public NuevoAtributo(List<Entidad> entidades)
        {
            InitializeComponent();
            foreach (Entidad e in entidades)
                cmb_Entidad.Items.Add(e.sNombre);
            cmbTipo.SelectedIndex = 0;
            txt_Long.Text = "4";
            cmbIndice.SelectedIndex = 0;
            cmb_Entidad.SelectedIndex = 0;
            //cmbTipo.Items.AddRange(new object[] {"int", "float", "char","string" });
        }
        public NuevoAtributo(string nombre, char tipo, int longit, int indice,Entidad e)
        {
            InitializeComponent();
            cmb_Entidad.Items.Add(e.sNombre);
            cmb_Entidad.Enabled = false;
            txt_Nombre.Text = nombre;
            if (tipo == 'C')
                cmbTipo.SelectedIndex = 0;
            else
                cmbTipo.SelectedIndex = 1;
            txt_Long.Text = longit.ToString();
            cmbIndice.SelectedIndex = indice;
            //cmbTipo.Items.AddRange(new object[] {"int", "float", "char","string" });
        }
        public string Nombre_atributo { get => txt_Nombre.Text; }
        public int Long { get => Convert.ToInt32(txt_Long.Text); }
        public int Tipo { get => cmbTipo.SelectedIndex; }//cmbTipo.SelectedText[0];}
        public string Entidad { get => cmb_Entidad.SelectedItem.ToString(); }
        public int Index { get => cmb_Entidad.SelectedIndex; }

        public int TipoIndex { get => cmbIndice.SelectedIndex; }
    }
}
