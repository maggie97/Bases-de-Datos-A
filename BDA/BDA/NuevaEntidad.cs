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
    public partial class NuevaEntidad : Form
    {

        public NuevaEntidad()
        {
            InitializeComponent();
        }
        
        private void NuevaEntidad_Load(object sender, EventArgs e)
        {

        }
        public string Nombre_Entidad{get => txt_Nombre.Text; }
}
}
