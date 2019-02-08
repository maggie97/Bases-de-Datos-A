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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ///Bunifu_classes.Round.ActivateForm(this, 20);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHerramintas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Este metodo es activado cuando un nnodo es pusado con el mouse. 
        /// Aunq solo se vera algun cambio si el nodo seleccionado es un nodo padre. 
        /// El cual activara el panel de contenido y mostrara lo que contenga la tabla seleccionada.
        /// </summary>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Level == 0)
                {
                    //
                }
            }
        }
    }
}
