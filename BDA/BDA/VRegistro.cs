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
        public VRegistro()
        {
            InitializeComponent();
        }

        public void VerTabla(Entidad entidad)
        {
            dgTabla.Columns.Clear();
            foreach (Atributo a in entidad.Atrib)
            {
                dgTabla.Columns.Add("col"+a.sNombre,a.sNombre);
            }
        }
    }
}
