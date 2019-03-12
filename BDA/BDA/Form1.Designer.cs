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
            this.contextTabla = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoAtributoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eliminarTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cambiarNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelTree = new System.Windows.Forms.Panel();
            this.treeViewBD = new System.Windows.Forms.TreeView();
            this.panelHerramintas = new System.Windows.Forms.Panel();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoAtributoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextTabla.SuspendLayout();
            this.contextItem.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panelTree.SuspendLayout();
            this.panelHerramintas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextTabla
            // 
            this.contextTabla.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contextTabla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoAtributoToolStripMenuItem,
            this.toolStripSeparator2,
            this.eliminarTablaToolStripMenuItem});
            this.contextTabla.Name = "contextTabla";
            this.contextTabla.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextTabla.Size = new System.Drawing.Size(181, 76);
            // 
            // nuevoAtributoToolStripMenuItem
            // 
            this.nuevoAtributoToolStripMenuItem.Name = "nuevoAtributoToolStripMenuItem";
            this.nuevoAtributoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoAtributoToolStripMenuItem.Text = "Nuevo Atributo";
            this.nuevoAtributoToolStripMenuItem.Click += new System.EventHandler(this.nuevoAtributoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // eliminarTablaToolStripMenuItem
            // 
            this.eliminarTablaToolStripMenuItem.Enabled = false;
            this.eliminarTablaToolStripMenuItem.Name = "eliminarTablaToolStripMenuItem";
            this.eliminarTablaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.eliminarTablaToolStripMenuItem.Text = "Eliminar Tabla";
            // 
            // contextItem
            // 
            this.contextItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contextItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contextItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.toolStripSeparator1,
            this.cambiarNombreToolStripMenuItem,
            this.eliminarBDToolStripMenuItem});
            this.contextItem.Name = "contextItemTree";
            this.contextItem.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextItem.Size = new System.Drawing.Size(165, 76);
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.nuevaToolStripMenuItem.Text = "Nueva Tabla";
            this.nuevaToolStripMenuItem.Click += new System.EventHandler(this.nuevaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // cambiarNombreToolStripMenuItem
            // 
            this.cambiarNombreToolStripMenuItem.Name = "cambiarNombreToolStripMenuItem";
            this.cambiarNombreToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cambiarNombreToolStripMenuItem.Text = "Cambiar nombre";
            this.cambiarNombreToolStripMenuItem.Click += new System.EventHandler(this.cambiarNombreToolStripMenuItem_Click);
            // 
            // eliminarBDToolStripMenuItem
            // 
            this.eliminarBDToolStripMenuItem.Name = "eliminarBDToolStripMenuItem";
            this.eliminarBDToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.eliminarBDToolStripMenuItem.Text = "Eliminar BD";
            this.eliminarBDToolStripMenuItem.Click += new System.EventHandler(this.eliminarBDToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-database-16.png");
            this.imageList1.Images.SetKeyName(1, "icons8-spreadsheet-file-24.png");
            this.imageList1.Images.SetKeyName(2, "icons8-placeholder-thumbnail-xml-24.png");
            this.imageList1.Images.SetKeyName(3, "icons8-grid-2-48.png");
            this.imageList1.Images.SetKeyName(4, "icons8-column-48.png");
            this.imageList1.Images.SetKeyName(5, "mas.png");
            this.imageList1.Images.SetKeyName(6, "icons8-edit-file-24.png");
            this.imageList1.Images.SetKeyName(7, "icons8-new-copy-24.png");
            this.imageList1.Images.SetKeyName(8, "archivo-de-texto.png");
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panelHerramintas);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(798, 462);
            this.panel5.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.Control;
            this.panel10.Controls.Add(this.panelContenido);
            this.panel10.Controls.Add(this.panelTree);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(50, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(748, 462);
            this.panel10.TabIndex = 4;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.LightGray;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(200, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(548, 462);
            this.panelContenido.TabIndex = 1;
            // 
            // panelTree
            // 
            this.panelTree.Controls.Add(this.treeViewBD);
            this.panelTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTree.Location = new System.Drawing.Point(0, 0);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(200, 462);
            this.panelTree.TabIndex = 0;
            // 
            // treeViewBD
            // 
            this.treeViewBD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.treeViewBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewBD.FullRowSelect = true;
            this.treeViewBD.ImageIndex = 0;
            this.treeViewBD.ImageList = this.imageList1;
            this.treeViewBD.Location = new System.Drawing.Point(0, 0);
            this.treeViewBD.Name = "treeViewBD";
            this.treeViewBD.SelectedImageIndex = 0;
            this.treeViewBD.ShowNodeToolTips = true;
            this.treeViewBD.Size = new System.Drawing.Size(200, 462);
            this.treeViewBD.TabIndex = 0;
            this.treeViewBD.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewBD_NodeMouseClick);
            this.treeViewBD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeViewBD_MouseClick);
            // 
            // panelHerramintas
            // 
            this.panelHerramintas.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelHerramintas.Controls.Add(this.bunifuImageButton4);
            this.panelHerramintas.Controls.Add(this.bunifuImageButton3);
            this.panelHerramintas.Controls.Add(this.bunifuImageButton2);
            this.panelHerramintas.Controls.Add(this.bunifuImageButton1);
            this.panelHerramintas.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHerramintas.Location = new System.Drawing.Point(0, 0);
            this.panelHerramintas.Name = "panelHerramintas";
            this.panelHerramintas.Size = new System.Drawing.Size(50, 462);
            this.panelHerramintas.TabIndex = 0;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
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
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
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
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
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
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoAtributoToolStripMenuItem1,
            this.abrirBaseDeDatosToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoAtributoToolStripMenuItem1
            // 
            this.nuevoAtributoToolStripMenuItem1.Name = "nuevoAtributoToolStripMenuItem1";
            this.nuevoAtributoToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.nuevoAtributoToolStripMenuItem1.Text = "Nueva Base de Datos";
            this.nuevoAtributoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirBaseDeDatosToolStripMenuItem
            // 
            this.abrirBaseDeDatosToolStripMenuItem.Name = "abrirBaseDeDatosToolStripMenuItem";
            this.abrirBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.abrirBaseDeDatosToolStripMenuItem.Text = "Abrir Base de Datos";
            this.abrirBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 486);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manejador de Base de Datos";
            this.contextTabla.ResumeLayout(false);
            this.contextItem.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panelTree.ResumeLayout(false);
            this.panelHerramintas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelTree;
        private System.Windows.Forms.Panel panelHerramintas;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ContextMenuStrip contextItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cambiarNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarBDToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextTabla;
        private System.Windows.Forms.ToolStripMenuItem nuevoAtributoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem eliminarTablaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoAtributoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrirBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeViewBD;
    }
}

