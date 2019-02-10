using System;
using System.IO;
using System.Windows.Forms;

namespace BDA
{
    public partial class Form1 : Form
    {
        private string Path;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            abrirDD();
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
                    Path = open.FileName;
                    Path.Substring(0, Path.LastIndexOf('\''));
                    DirectoryInfo directory = new DirectoryInfo(Path);
                    DirectoryInfo[] directories = directory.GetDirectories();

                    foreach (FileInfo file in directory.GetFiles())
                    {
                        if (file.Exists)
                        {
                            TreeNode nodes = treeViewBD.Nodes[0].Nodes.Add(file.Name);
                        }
                    }

                }
            }
        }
        private void nuevoDD()
        {
            using (nuevoArchivo n = new nuevoArchivo())
            {
                if (n.ShowDialog() == DialogResult.OK)
                {
                    Path = n.Path;
                    if (!Directory.Exists(Path))
                    {
                        DirectoryInfo directory = System.IO.Directory.CreateDirectory(Path);
                        DDD ddd = new DDD(n.name, ".dd", Path);
                        using (BinaryWriter writer = new BinaryWriter(File.Open(ddd.Fullname, FileMode.Create)))
                        {
                            writer.Write(ddd.Cab);

                            /*txtCab.Text = ddd.Cab.ToString();
                            Enable_Entidades_Atributos(true);
                            btn_Registro.Enabled = true;*/

                            /**/
                            DirectoryInfo[] directories = directory.GetDirectories();

                            foreach (FileInfo file in directory.GetFiles())
                            {
                                if (file.Exists)
                                {
                                    TreeNode nodes = treeViewBD.Nodes[0].Nodes.Add(file.Name);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un directorio con ese nombre");
                    }
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
        

        private void menuArchivo_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                menuArchivo.ContextMenuStrip = contextArchivo;
                menuArchivo.ContextMenuStrip.Show(menuArchivo, 0, menuArchivo.Bottom);
            }
            else
            {
                menuArchivo.ContextMenuStrip = null;
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirDD();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoDD();
        }
        
       

        private void eliminarBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path))
            {
                Directory.Delete(Path);
            }
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
