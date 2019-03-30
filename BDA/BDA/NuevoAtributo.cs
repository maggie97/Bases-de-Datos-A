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
    public partial class NuevoAtributo : Form
    {
        
        public NuevoAtributo(Entidad entidades)
        {
            InitializeComponent();
            
            num_Long.Text = "4";
            cmbIndice.SelectedIndex = 0;
            lblEntidad.Text = entidades.sNombre;
            cmbTipo.Items.AddRange(new object[] {"int", "float", "char" });
            cmbTipo.SelectedIndex = 0;
        }
        /*
        public NuevoAtributo(string nombre, char tipo, int longit, int indice,Entidad e)
        {
            InitializeComponent();
            
            txt_Nombre.Text = nombre;
            if (tipo == 'C')
                cmbTipo.SelectedIndex = 0;
            else
                cmbTipo.SelectedIndex = 1;
            txt_Long.Text = longit.ToString();
            cmbIndice.SelectedIndex = indice;

        }*/
        public string Nombre_atributo { get => txt_Nombre.Text; }
        public int Long { get => Convert.ToInt32(num_Long.Text); }
        public int Tipo { get => cmbTipo.SelectedIndex; }

        public int TipoIndex { get => cmbIndice.SelectedIndex; }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Tipo)
            {
                case 0: //int 
                    num_Long.Value = 4;
                    num_Long.Enabled = false;
                    break;
                case 1:
                    num_Long.Value = 4;
                    num_Long.Enabled = false;
                    break;
                default:
                    num_Long.Value = 1;
                    num_Long.Enabled = true;
                    break;
            }
        }
    }
}
