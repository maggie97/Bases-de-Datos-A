namespace BDA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Atributo", 2, 2);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Tabla", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Base de Datos", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.contextTabla = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoAtributoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextItemTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cambiarNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.menuArchivo = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelTree = new System.Windows.Forms.Panel();
            this.treeViewBD = new System.Windows.Forms.TreeView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelHerramintas = new System.Windows.Forms.Panel();
            this.contextArchivo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton7 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextTabla.SuspendLayout();
            this.contextItemTree.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panelTree.SuspendLayout();
            this.panelHerramintas.SuspendLayout();
            this.contextArchivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            this.SuspendLayout();
            // 
            // contextTabla
            // 
            this.contextTabla.BackColor = System.Drawing.Color.ForestGreen;
            this.contextTabla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoAtributoToolStripMenuItem});
            this.contextTabla.Name = "contextTabla";
            this.contextTabla.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextTabla.Size = new System.Drawing.Size(157, 26);
            // 
            // nuevoAtributoToolStripMenuItem
            // 
            this.nuevoAtributoToolStripMenuItem.Name = "nuevoAtributoToolStripMenuItem";
            this.nuevoAtributoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.nuevoAtributoToolStripMenuItem.Text = "Nuevo Atributo";
            // 
            // contextItemTree
            // 
            this.contextItemTree.BackColor = System.Drawing.Color.ForestGreen;
            this.contextItemTree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contextItemTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.toolStripSeparator1,
            this.cambiarNombreToolStripMenuItem,
            this.eliminarBDToolStripMenuItem});
            this.contextItemTree.Name = "contextItemTree";
            this.contextItemTree.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextItemTree.Size = new System.Drawing.Size(165, 76);
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaToolStripMenuItem.Text = "Nueva Tabla";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // cambiarNombreToolStripMenuItem
            // 
            this.cambiarNombreToolStripMenuItem.Name = "cambiarNombreToolStripMenuItem";
            this.cambiarNombreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarNombreToolStripMenuItem.Text = "Cambiar nombre";
            // 
            // eliminarBDToolStripMenuItem
            // 
            this.eliminarBDToolStripMenuItem.Name = "eliminarBDToolStripMenuItem";
            this.eliminarBDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarBDToolStripMenuItem.Text = "Eliminar BD";
            this.eliminarBDToolStripMenuItem.Click += new System.EventHandler(this.eliminarBDToolStripMenuItem_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(58)))), ((int)(((byte)(6)))));
            this.panelTitulo.Controls.Add(this.panel11);
            this.panelTitulo.Controls.Add(this.bunifuFlatButton1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(798, 49);
            this.panelTitulo.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.bunifuImageButton7);
            this.panel11.Controls.Add(this.bunifuImageButton5);
            this.panel11.Controls.Add(this.bunifuImageButton6);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(685, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(113, 49);
            this.panel11.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-database-16.png");
            this.imageList1.Images.SetKeyName(1, "icons8-grid-2-48.png");
            this.imageList1.Images.SetKeyName(2, "icons8-column-48.png");
            this.imageList1.Images.SetKeyName(3, "mas.png");
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 10);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(788, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 437);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 437);
            this.panel4.TabIndex = 1;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTitulo;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(58)))), ((int)(((byte)(6)))));
            this.panel6.Controls.Add(this.menuArchivo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(778, 25);
            this.panel6.TabIndex = 5;
            // 
            // menuArchivo
            // 
            this.menuArchivo.AutoSize = true;
            this.menuArchivo.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuArchivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuArchivo.Location = new System.Drawing.Point(3, 3);
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(64, 19);
            this.menuArchivo.TabIndex = 1;
            this.menuArchivo.Text = "Archivo";
            this.menuArchivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menuArchivo_MouseClick);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(58)))), ((int)(((byte)(6)))));
            this.panel12.Controls.Add(this.panel5);
            this.panel12.Controls.Add(this.panel2);
            this.panel12.Controls.Add(this.panel6);
            this.panel12.Controls.Add(this.panel1);
            this.panel12.Controls.Add(this.panel4);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 49);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(798, 437);
            this.panel12.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(126)))), ((int)(((byte)(16)))));
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panelHerramintas);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(778, 402);
            this.panel5.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(182)))), ((int)(((byte)(28)))));
            this.panel10.Controls.Add(this.panelContenido);
            this.panel10.Controls.Add(this.panelTree);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(50, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(723, 397);
            this.panel10.TabIndex = 4;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(213)))), ((int)(((byte)(190)))));
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(200, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(523, 397);
            this.panelContenido.TabIndex = 1;
            // 
            // panelTree
            // 
            this.panelTree.Controls.Add(this.treeViewBD);
            this.panelTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTree.Location = new System.Drawing.Point(0, 0);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(200, 397);
            this.panelTree.TabIndex = 0;
            // 
            // treeViewBD
            // 
            this.treeViewBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(182)))), ((int)(((byte)(28)))));
            this.treeViewBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewBD.ImageIndex = 0;
            this.treeViewBD.ImageList = this.imageList1;
            this.treeViewBD.Location = new System.Drawing.Point(0, 0);
            this.treeViewBD.Name = "treeViewBD";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "NodoAtributo";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Text = "Atributo";
            treeNode5.ContextMenuStrip = this.contextTabla;
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "nodoTabla";
            treeNode5.SelectedImageIndex = 1;
            treeNode5.Text = "Tabla";
            treeNode6.ContextMenuStrip = this.contextItemTree;
            treeNode6.Name = "Nodo0";
            treeNode6.Text = "Base de Datos";
            this.treeViewBD.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeViewBD.SelectedImageIndex = 0;
            this.treeViewBD.Size = new System.Drawing.Size(200, 397);
            this.treeViewBD.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(50, 397);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(723, 5);
            this.panel9.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(773, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 402);
            this.panel8.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(50, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(728, 5);
            this.panel7.TabIndex = 1;
            // 
            // panelHerramintas
            // 
            this.panelHerramintas.Controls.Add(this.bunifuImageButton4);
            this.panelHerramintas.Controls.Add(this.bunifuImageButton3);
            this.panelHerramintas.Controls.Add(this.bunifuImageButton2);
            this.panelHerramintas.Controls.Add(this.bunifuImageButton1);
            this.panelHerramintas.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHerramintas.Location = new System.Drawing.Point(0, 0);
            this.panelHerramintas.Name = "panelHerramintas";
            this.panelHerramintas.Size = new System.Drawing.Size(50, 402);
            this.panelHerramintas.TabIndex = 0;
            // 
            // contextArchivo
            // 
            this.contextArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(50)))), ((int)(((byte)(5)))));
            this.contextArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.contextArchivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem});
            this.contextArchivo.Name = "contextMenuStrip1";
            this.contextArchivo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextArchivo.Size = new System.Drawing.Size(185, 48);
            this.contextArchivo.UseWaitCursor = true;
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nuevoToolStripMenuItem.CheckOnClick = true;
            this.nuevoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.nuevoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.nuevoToolStripMenuItem.Text = "Nueva Base de Datos";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(126)))), ((int)(((byte)(16)))));
            this.bunifuImageButton4.Image = global::BDA.Properties.Resources.icons8_insert_table_48;
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(6, 123);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(37, 35);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 5;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(126)))), ((int)(((byte)(16)))));
            this.bunifuImageButton3.Image = global::BDA.Properties.Resources.icons8_add_database_48;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(5, 45);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(37, 33);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 4;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(126)))), ((int)(((byte)(16)))));
            this.bunifuImageButton2.Image = global::BDA.Properties.Resources.icons8_delete_database_48;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(6, 84);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(37, 33);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(126)))), ((int)(((byte)(16)))));
            this.bunifuImageButton1.Image = global::BDA.Properties.Resources.icons8_opened_folder_480;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(6, 6);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton7
            // 
            this.bunifuImageButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(58)))), ((int)(((byte)(6)))));
            this.bunifuImageButton7.Image = global::BDA.Properties.Resources.linea_recta;
            this.bunifuImageButton7.ImageActive = null;
            this.bunifuImageButton7.Location = new System.Drawing.Point(17, 11);
            this.bunifuImageButton7.Name = "bunifuImageButton7";
            this.bunifuImageButton7.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton7.TabIndex = 5;
            this.bunifuImageButton7.TabStop = false;
            this.bunifuImageButton7.Zoom = 10;
            this.bunifuImageButton7.Click += new System.EventHandler(this.bunifuImageButton7_Click);
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(58)))), ((int)(((byte)(6)))));
            this.bunifuImageButton5.Image = global::BDA.Properties.Resources.cerrar;
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(81, 11);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 3;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(58)))), ((int)(((byte)(6)))));
            this.bunifuImageButton6.Image = global::BDA.Properties.Resources.cuadrado;
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(49, 11);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 4;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(58)))), ((int)(((byte)(6)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(58)))), ((int)(((byte)(6)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton1.ButtonText = "Manejador de Bses de Datos";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::BDA.Properties.Resources.dato__1_;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = global::BDA.Properties.Resources.dato;
            this.bunifuFlatButton1.IconMarginLeft = 2;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(58)))), ((int)(((byte)(6)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(58)))), ((int)(((byte)(6)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(260, 49);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "Manejador de Bses de Datos";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.abrirToolStripMenuItem.Text = "Abrir Base De Datos";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 486);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SMBDA";
            this.contextTabla.ResumeLayout(false);
            this.contextItemTree.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panelTree.ResumeLayout(false);
            this.panelHerramintas.ResumeLayout(false);
            this.contextArchivo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton7;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelTree;
        private System.Windows.Forms.TreeView treeViewBD;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelHerramintas;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ContextMenuStrip contextArchivo;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.Label menuArchivo;
        private System.Windows.Forms.ContextMenuStrip contextItemTree;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cambiarNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarBDToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextTabla;
        private System.Windows.Forms.ToolStripMenuItem nuevoAtributoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
    }
}

