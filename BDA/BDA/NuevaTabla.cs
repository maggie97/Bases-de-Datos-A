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
    public partial class NuevaTabla : Form
    {

        public NuevaTabla()
        {
            InitializeComponent();
        }
        public NuevaTabla(string nombre)
        {
            InitializeComponent();
            txt_Nombre.Text = nombre;
        }
        private void NuevaEntidad_Load(object sender, EventArgs e)
        {

        }
        public string Nombre_Entidad{get => txt_Nombre.Text; }
}
}
