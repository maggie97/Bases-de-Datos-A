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
        private VRegistro vr;

        DDD ddd;
        public Form1()
        {
            InitializeComponent();
            vr = new VRegistro();
            vr.TopLevel = false;
            vr.Dock = DockStyle.Fill;
            if (panelContenido.Controls.Count > 0)
                panelContenido.Controls.RemoveAt(0);
            Form fh = vr as VRegistro;
            panelContenido.Controls.Add(fh);
            panelContenido.Tag = fh;
            vr.Show();
        }

        #region
        private void abrirDD()
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Diccionario de Datos (*.dd)| *.dd";
                open.Title = "Seleciona un Diccionario de datos";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    ddd = new DDD(open.FileName);
                    ddd.lee_();
                    Path = open.FileName;
                    Path = Path.Substring(0, Path.LastIndexOf('\\'));
                    string n = Path.Substring(Path.LastIndexOf('\\') + 1);
                    creArbol(n);
                }
            }
        }
        private void creArbol(string nomb)
        {
            nombreBD = nomb;
            treeViewBD.Nodes.Clear();
            if (!Directory.Exists(Path)) return;
            DirectoryInfo directory = new DirectoryInfo(Path);
            
            TreeNode root = new TreeNode(nomb);
            root.ContextMenuStrip = contextItem;
            TreeNode n1 = null;           
            foreach (Entidad e in ddd.EntidadesOrden)
            {
                if (!File.Exists(Path + '\\' + e.shortName + ".dat"))
                {
                    Archivo n = new Archivo(e.shortName, ".dat", Path);
                }
                TreeNode node = new TreeNode(e.shortName, 1, 1);
                node.ContextMenuStrip = contextTabla;
                foreach (Atributo a in e.Atrib)
                {
                    int img = 2;// ningun tipo de llave 

                    switch (a.TipoIndice)
                    {
                        case 2: //llave primaria
                            img = 3;
                            break;
                        case 3: //llave foranea 
                            img = 4;
                            break;
                    }
                    TreeNode nA = new TreeNode(a.sNombre, img, img);
                    nA.ContextMenuStrip = contextAtributo;
                    node.Nodes.Add(nA);
                }
                //node.SelectedImageIndex = node.Level+1;
                //node.ImageIndex = node.Level;
                root.Nodes.Add(node);
                if (n1 == null) n1 = node;
            }
            List<TreeNode> tree = new List<TreeNode>();
            tree.Add(root);
            treeViewBD.Nodes.AddRange(tree.ToArray());
            treeViewBD.ExpandAll();
            treeViewBD.SelectedNode = n1;

        }
        private void creArbol()
        {
            treeViewBD.Nodes.Clear();
            if (!Directory.Exists(Path)) return;
            DirectoryInfo directory = new DirectoryInfo(Path);
            TreeNode n1 = null;
            TreeNode root = new TreeNode(nombreBD);
            root.ContextMenuStrip = contextItem;
            foreach (Entidad e in ddd.EntidadesOrden)
            {
                if(!File.Exists(Path + '\\'+ e.shortName + ".dat"))
                {
                    Archivo n = new Archivo(e.shortName, ".dat", Path);
                }
                TreeNode node = new TreeNode(e.shortName, 1, 1);
                node.ContextMenuStrip = contextTabla;
                foreach (Atributo a in e.Atrib)
                {
                    int img = 2;// ningun tipo de llave 

                    switch (a.TipoIndice)
                    {
                        case 2: //llave primaria
                            img = 3;
                            break;
                        case 3: //llave foranea 
                            img = 4;
                            break;
                    }
                    TreeNode nA = new TreeNode(a.sNombre, img, img);
                    nA.ContextMenuStrip = contextAtributo;
                    node.Nodes.Add(nA);
                }
                //node.SelectedImageIndex = node.Level;
                //node.ImageIndex = node.Level;
                root.Nodes.Add(node);
                treeViewBD.ExpandAll();
                if (n1 == null) n1 = node;
            } 

            List<TreeNode> tree = new List<TreeNode>();
            tree.Add(root);
            treeViewBD.Nodes.AddRange(tree.ToArray());
            treeViewBD.SelectedNode = n1;
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
                            creArbol(n.name);
                        }
                    }
                    else
                        MessageBox.Show("Ya existe un directorio con ese nombre");
                }
            }
        }
        #endregion

        
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
                else
                    MessageBox.Show("Ya existe una tabla con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeViewBD_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void treeViewBD_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ((TreeView)sender).SelectedNode = e.Node;
        }

        private void nuevoAtributoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoAtributo();
        }

        private void eliminarTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aux = treeViewBD.SelectedNode.Text;
            Entidad ent = ddd.EntidadesOrden.Find(o => o.sNombre.Contains(aux));
            //ArchivoRegistros a = new ArchivoRegistros(Path + '\\' + aux + ".dat", ent);
            
            if (Relacion(ent))
            {
                MessageBox.Show("Tabla con relacion de FK");
                return;
            }
            if(MessageBox.Show("¿Estas seguro de eliminar esta tabla?", "Eliminar tabla", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification ) == DialogResult.OK)
            {
                elimina();
            }
        }

        private void treeViewBD_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewBD.SelectedNode != null && treeViewBD.SelectedNode.Level == 1)
            {
                string name = treeViewBD.SelectedNode.Text.Split('.')[0];
                Entidad ent = ddd.EntidadesOrden.Find(o => o.sNombre.Contains(name));
                vr.VerTabla(ent);
            }
            
        }
        private bool elimina()
        {
            try
            {
                string name = treeViewBD.SelectedNode.Text;
                string n = treeViewBD.SelectedNode.Text.Split('.')[0];
                ddd.eliminaEntidad(n);
                File.Delete(Path + '\\' + name);
                creArbol();
            }
            catch
            {
                return false;
            }
            return true;
        }
        private bool nuevoAtributo()
        {
            bool r = false;
            int i = treeViewBD.SelectedNode.Index;
            string name = treeViewBD.SelectedNode.Text;
            string n = treeViewBD.SelectedNode.Text.Split('.')[0];
            Entidad ent = ddd.EntidadesOrden.Find(o => o.shortName.CompareTo(n) == 0);
            //.Indice(Path);
            NuevoAtributo nuevo = new NuevoAtributo(ent, ddd);

            if (nuevo.ShowDialog() == DialogResult.OK)
            {
                long dir = -1;
                ddd.nuevoAtributo(nuevo.Nombre_atributo, nuevo.Tipo, nuevo.Long, ent, nuevo.TipoIndex, nuevo.Relacion);
                ent.Indice(Path);
                vr.VerTabla(ent);
                creArbol();
                r = true;
            }
            return r;
        }
        private void treeViewBD_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            
        }

        private void modifiicarTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string n = treeViewBD.SelectedNode.Text.Split('.')[0];
            Entidad eMod = ddd.EntidadesOrden.Find(o => o.shortName.CompareTo(n) == 0);
            if (Relacion(eMod)) 
            {
                MessageBox.Show("Tabla con relacion a pk");
                return;
            }
            NuevaTabla nueva = new NuevaTabla(eMod.shortName);
            if (nueva.ShowDialog() == DialogResult.OK)
            {
                if (nueva.Nombre_Entidad == "")
                    MessageBox.Show("Nombre Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (!File.Exists(Path + '\\' + nueva.Nombre_Entidad + ".dat"))
                {
                    string name = treeViewBD.SelectedNode.Text, aux = "";
                    aux = nueva.Nombre_Entidad;
                    while (aux.Length < 30) aux += ' ';
                    eMod.NombreEntidad = aux.ToCharArray(0, 30);
                    File.Move( Path + '\\' + name + ".dat", Path+'\\'+ nueva.Nombre_Entidad + ".dat");
                }
                else
                    MessageBox.Show("Ya existe una tabla con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ddd.ordena();
            ddd.sobreescribEntidad(eMod);
            ddd.sobreescribe_archivo();
            creArbol();
        }
        private bool Relacion(Entidad e)
        {
            if (e.Prim != null)
                foreach (Entidad ent in ddd.EntidadesOrden)
                    if (ent != e && ent.Sec != null) 
                        foreach (Controladores.Secundario s in ent.Sec)
                            if (s.RelacionAtributo() != null && s.RelacionAtributo().DirAtributo == e.Prim.Atributo.DirAtributo)
                                return true;
            return false;
        }
        private void eliminarAtributoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode n = treeViewBD.SelectedNode;
            if(n.Level == 2)
            {
                if (!ddd.eliminaAtributo(n.Parent.Text, n.Index))
                    MessageBox.Show("Atributo no eliminado");
                creArbol();
            }
        }
    }
}
