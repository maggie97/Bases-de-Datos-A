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
            abrirDD();
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
            if (treeViewBD.SelectedNode != null)
            {
                if (treeViewBD.SelectedNode.Level == 0)
                {
                    //
                }
            }
        }


        #region
        private void abrirDD()
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Diccionario de Datos (*.dd)| *.dd";
                ///open.InitialDirectory = Directory.GetParent(ddd.Fullname).ToString();
                open.Title = "Seleciona un Diccionario de datos";
                if (open.ShowDialog() == DialogResult.OK)
                {


                }
            }
        }
        #endregion

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void bunifuFlatButton2_MouseDown(object sender, EventArgs e)
        {
            
        }

        private void menuArchivo_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                menuArchivo.ContextMenuStrip = contextArchivo;
                
                menuArchivo.ContextMenuStrip.Show(menuArchivo, 0, menuArchivo.Bottom);
            }
        }
    }
}
