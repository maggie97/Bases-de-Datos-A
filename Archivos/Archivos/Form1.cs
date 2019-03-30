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
    public partial class Form1 : Form
    {
        VistaRegistros VistReg;
        VistaIndice VistaIndice;
        Principal VistaDDD;
        public Form1(Entidad E)
        {
            InitializeComponent();
            VistaDDD = new Principal();
            panelContedor.Controls.Add(VistaDDD);
            VistaDDD.Show();


            VistaIndice = new VistaIndice(E);
            //VistReg = new VistaRegistros(E, E.Dir_Datos);
            //VistReg.actualizado += new VistaRegistros.Actualiza(actualizaEnt);
            //VistReg.actualizado += new VistaRegistros.Actualiza(ddd.sobreescribe_archivo);
            VistReg.Show();
        }

        private void lblDD_Click(object sender, EventArgs e)
        {
            VistaDDD.Visible = true;
        }

        private void lblIndices_Click(object sender, EventArgs e)
        {

        }

        private void lblReg_Click(object sender, EventArgs e)
        {

        }
    }
}
