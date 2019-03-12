using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BDA
{
    public partial class Form1 : Form
    {
        private string Path;
        private string nombreBD;


        DDD ddd;
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
                    ddd = new DDD(open.FileName);
                    ddd.lee();
                    Path = open.FileName;
                    Path = Path.Substring(0, Path.LastIndexOf('\\'));
                    string n = Path.Substring(Path.LastIndexOf('\\') + 1);

                    creArbol(n);
                }
            }
        }
        private void creArbol( string nomb)
        {
            nombreBD = nomb;
            treeViewBD.Nodes.Clear();
            if (!Directory.Exists(Path)) return;
            DirectoryInfo directory = new DirectoryInfo(Path);
            
            TreeNode root = new TreeNode(nomb);
            root.ContextMenuStrip = contextItem;
            foreach (FileInfo file in directory.GetFiles())
            {
                if (file.Exists && file.Name.Substring(file.Name.IndexOf('.')+1) != "dd")
                {
                    TreeNode node = new TreeNode(file.Name);
                    node.ContextMenuStrip = contextTabla;
                    root.Nodes.Add(node);
                    node.ImageIndex = node.Level;
                    node.SelectedImageIndex = node.Level;
                }
            }
            List<TreeNode> tree = new List<TreeNode>();
            tree.Add(root);
            treeViewBD.Nodes.AddRange(tree.ToArray());
            treeViewBD.ExpandAll();
        }
        private void creArbol()
        {
            treeViewBD.Nodes.Clear();
            if (!Directory.Exists(Path)) return;
            DirectoryInfo directory = new DirectoryInfo(Path);

            TreeNode root = new TreeNode(nombreBD);
            root.ContextMenuStrip = contextItem;
            foreach (FileInfo file in directory.GetFiles())
            {
                if (file.Exists && file.Name.Substring(file.Name.IndexOf('.') + 1) != "dd")
                {
                    TreeNode node = new TreeNode(file.Name);
                    node.ContextMenuStrip = contextTabla;
                    
                    root.Nodes.Add(node);
                    
                }
            }
            List<TreeNode> tree = new List<TreeNode>();
            tree.Add(root);
            treeViewBD.Nodes.AddRange(tree.ToArray());
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
                        ddd = new DDD(n.name, ".dd", Path);
                        using (BinaryWriter writer = new BinaryWriter(File.Open(ddd.Fullname, FileMode.Create)))
                        {
                            writer.Write(ddd.Cab);

                            /*txtCab.Text = ddd.Cab.ToString();
                            Enable_Entidades_Atributos(true);
                            btn_Registro.Enabled = true;*/

                            /**/
                            creArbol(n.name);
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
                //eliminar los arcchivos de la carpeta 
                DirectoryInfo directory = new DirectoryInfo(Path);
                foreach (FileInfo file in directory.GetFiles())
                {
                    file.Delete();
                }
                // eliminar la carpeta (sin archivos)
                Directory.Delete(Path);
                creArbol();
            }
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cambiarNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aux = Path.Substring(0, Path.LastIndexOf('\\'));
            string res = Microsoft.VisualBasic.Interaction.InputBox("Nombre de la BD", "Cambiar nombre", nombreBD);


            File.Move(Path + '\\' + nombreBD + ".dd", Path + '\\' + res + ".dd");
            Directory.Move(Path , aux + '\\'+ res);

            
            Path = aux + '\\' + res;
            nombreBD = res;

            ddd.Fullname = Path + '\\' + nombreBD + ".dd";

            creArbol();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaTabla nueva = new NuevaTabla();
            if(nueva.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(Path + '\\' + nueva.Nombre_Entidad + ".dat"))
                {
                    ddd.nuevaEntidad(nueva.Nombre_Entidad);
                    ddd.sobreescribe_archivo();
                    Archivo n = new Archivo(  nueva.Nombre_Entidad, ".dat", Path );
                    creArbol();
                }
            }
        }

        private void treeViewBD_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void treeViewBD_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
        }

        private void nuevoAtributoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
