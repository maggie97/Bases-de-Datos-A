namespace Archivos
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Entidades = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaEntidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Atributos = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoAtributoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaAtributoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Registro = new System.Windows.Forms.ToolStripMenuItem();
            this.pEntidades = new System.Windows.Forms.Panel();
            this.dgEntidades = new System.Windows.Forms.DataGridView();
            this.Nom_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Ent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Atributos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Datos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_SigEnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cabeceraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCab = new System.Windows.Forms.ToolStripTextBox();
            this.longitudArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLong = new System.Windows.Forms.ToolStripTextBox();
            this.pAtributos = new System.Windows.Forms.Panel();
            this.dgAtributos = new System.Windows.Forms.DataGridView();
            this.Nom_Atrib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Atrib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Da = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Long = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_SigAtrib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTituloAtrib = new System.Windows.Forms.Panel();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.lbltextoA = new System.Windows.Forms.Label();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaEntidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pEntidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntidades)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.pAtributos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAtributos)).BeginInit();
            this.pTituloAtrib.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.btn_Entidades,
            this.btn_Atributos,
            this.btn_Registro});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.modificarBDToolStripMenuItem,
            this.eliminarBDToolStripMenuItem,
            this.toolStripSeparator,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(224, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Archivos.Properties.Resources.icons8_edit_48__1_;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btn_Entidades
            // 
            this.btn_Entidades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaEntidadToolStripMenuItem,
            this.eliminaEntidadToolStripMenuItem});
            this.btn_Entidades.Name = "btn_Entidades";
            this.btn_Entidades.Size = new System.Drawing.Size(73, 20);
            this.btn_Entidades.Text = "Entidades ";
            // 
            // eliminaEntidadToolStripMenuItem
            // 
            this.eliminaEntidadToolStripMenuItem.Name = "eliminaEntidadToolStripMenuItem";
            this.eliminaEntidadToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.eliminaEntidadToolStripMenuItem.Text = "Elimina Entidad";
            this.eliminaEntidadToolStripMenuItem.Click += new System.EventHandler(this.eliminaEntidadToolStripMenuItem_Click);
            // 
            // btn_Atributos
            // 
            this.btn_Atributos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoAtributoToolStripMenuItem,
            this.eliminaAtributoToolStripMenuItem});
            this.btn_Atributos.Name = "btn_Atributos";
            this.btn_Atributos.Size = new System.Drawing.Size(68, 20);
            this.btn_Atributos.Text = "Atributos";
            // 
            // nuevoAtributoToolStripMenuItem
            // 
            this.nuevoAtributoToolStripMenuItem.Name = "nuevoAtributoToolStripMenuItem";
            this.nuevoAtributoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nuevoAtributoToolStripMenuItem.Text = "Nuevo Atributo";
            this.nuevoAtributoToolStripMenuItem.Click += new System.EventHandler(this.nuevoAtributoToolStripMenuItem_Click);
            // 
            // eliminaAtributoToolStripMenuItem
            // 
            this.eliminaAtributoToolStripMenuItem.Name = "eliminaAtributoToolStripMenuItem";
            this.eliminaAtributoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.eliminaAtributoToolStripMenuItem.Text = "Elimina Atributo";
            this.eliminaAtributoToolStripMenuItem.Click += new System.EventHandler(this.eliminaAtributoToolStripMenuItem_Click);
            // 
            // btn_Registro
            // 
            this.btn_Registro.Name = "btn_Registro";
            this.btn_Registro.Size = new System.Drawing.Size(62, 20);
            this.btn_Registro.Text = "Registro";
            this.btn_Registro.Click += new System.EventHandler(this.insertaRegistro_Click);
            // 
            // pEntidades
            // 
            this.pEntidades.Controls.Add(this.dgEntidades);
            this.pEntidades.Controls.Add(this.menuStrip2);
            this.pEntidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.pEntidades.Location = new System.Drawing.Point(0, 24);
            this.pEntidades.Name = "pEntidades";
            this.pEntidades.Size = new System.Drawing.Size(786, 208);
            this.pEntidades.TabIndex = 2;
            // 
            // dgEntidades
            // 
            this.dgEntidades.AllowUserToAddRows = false;
            this.dgEntidades.AllowUserToDeleteRows = false;
            this.dgEntidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom_Entidad,
            this.Dir_Ent,
            this.Dir_Atributos,
            this.Dir_Datos,
            this.Dir_SigEnt});
            this.dgEntidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEntidades.Location = new System.Drawing.Point(0, 27);
            this.dgEntidades.Name = "dgEntidades";
            this.dgEntidades.ReadOnly = true;
            this.dgEntidades.Size = new System.Drawing.Size(786, 181);
            this.dgEntidades.TabIndex = 4;
            this.dgEntidades.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEntidades_CellContentDoubleClick);
            this.dgEntidades.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgEntidades_CellMouseDown);
            this.dgEntidades.Paint += new System.Windows.Forms.PaintEventHandler(this.Principal_Paint);
            // 
            // Nom_Entidad
            // 
            this.Nom_Entidad.HeaderText = "Nombre de Entidad";
            this.Nom_Entidad.Name = "Nom_Entidad";
            this.Nom_Entidad.ReadOnly = true;
            this.Nom_Entidad.Width = 113;
            // 
            // Dir_Ent
            // 
            this.Dir_Ent.HeaderText = "Direccion Entidad";
            this.Dir_Ent.Name = "Dir_Ent";
            this.Dir_Ent.ReadOnly = true;
            this.Dir_Ent.Width = 106;
            // 
            // Dir_Atributos
            // 
            this.Dir_Atributos.HeaderText = "Direccion Atributos";
            this.Dir_Atributos.Name = "Dir_Atributos";
            this.Dir_Atributos.ReadOnly = true;
            this.Dir_Atributos.Width = 111;
            // 
            // Dir_Datos
            // 
            this.Dir_Datos.HeaderText = "Direccion Datos";
            this.Dir_Datos.Name = "Dir_Datos";
            this.Dir_Datos.ReadOnly = true;
            this.Dir_Datos.Width = 99;
            // 
            // Dir_SigEnt
            // 
            this.Dir_SigEnt.HeaderText = "Direccion Siguiente Entidad";
            this.Dir_SigEnt.Name = "Dir_SigEnt";
            this.Dir_SigEnt.ReadOnly = true;
            this.Dir_SigEnt.Width = 116;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cabeceraToolStripMenuItem,
            this.txtCab,
            this.longitudArchivoToolStripMenuItem,
            this.txtLong});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(786, 27);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cabeceraToolStripMenuItem
            // 
            this.cabeceraToolStripMenuItem.Enabled = false;
            this.cabeceraToolStripMenuItem.Name = "cabeceraToolStripMenuItem";
            this.cabeceraToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.cabeceraToolStripMenuItem.Text = "Cabecera";
            // 
            // txtCab
            // 
            this.txtCab.Enabled = false;
            this.txtCab.Name = "txtCab";
            this.txtCab.Size = new System.Drawing.Size(100, 23);
            // 
            // longitudArchivoToolStripMenuItem
            // 
            this.longitudArchivoToolStripMenuItem.Enabled = false;
            this.longitudArchivoToolStripMenuItem.Name = "longitudArchivoToolStripMenuItem";
            this.longitudArchivoToolStripMenuItem.Size = new System.Drawing.Size(111, 23);
            this.longitudArchivoToolStripMenuItem.Text = "Longitud Archivo";
            // 
            // txtLong
            // 
            this.txtLong.Enabled = false;
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(100, 23);
            // 
            // pAtributos
            // 
            this.pAtributos.Controls.Add(this.dgAtributos);
            this.pAtributos.Controls.Add(this.pTituloAtrib);
            this.pAtributos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAtributos.Location = new System.Drawing.Point(0, 232);
            this.pAtributos.Name = "pAtributos";
            this.pAtributos.Size = new System.Drawing.Size(786, 329);
            this.pAtributos.TabIndex = 4;
            // 
            // dgAtributos
            // 
            this.dgAtributos.AllowUserToAddRows = false;
            this.dgAtributos.AllowUserToDeleteRows = false;
            this.dgAtributos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgAtributos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgAtributos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgAtributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAtributos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom_Atrib,
            this.Dir_Atrib,
            this.Tipo_Da,
            this.Long,
            this.Tipo_Indice,
            this.Dir_Indice,
            this.Dir_SigAtrib});
            this.dgAtributos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAtributos.Location = new System.Drawing.Point(0, 33);
            this.dgAtributos.Name = "dgAtributos";
            this.dgAtributos.ReadOnly = true;
            this.dgAtributos.Size = new System.Drawing.Size(786, 296);
            this.dgAtributos.TabIndex = 4;
            this.dgAtributos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAtributos_CellContentDoubleClick);
            this.dgAtributos.Paint += new System.Windows.Forms.PaintEventHandler(this.Principal_Paint);
            // 
            // Nom_Atrib
            // 
            this.Nom_Atrib.HeaderText = "Nombre Atributo";
            this.Nom_Atrib.Name = "Nom_Atrib";
            this.Nom_Atrib.ReadOnly = true;
            this.Nom_Atrib.Width = 99;
            // 
            // Dir_Atrib
            // 
            this.Dir_Atrib.HeaderText = "Direccion Atributo";
            this.Dir_Atrib.Name = "Dir_Atrib";
            this.Dir_Atrib.ReadOnly = true;
            this.Dir_Atrib.Width = 106;
            // 
            // Tipo_Da
            // 
            this.Tipo_Da.HeaderText = "Tipo de Dato";
            this.Tipo_Da.Name = "Tipo_Da";
            this.Tipo_Da.ReadOnly = true;
            this.Tipo_Da.Width = 87;
            // 
            // Long
            // 
            this.Long.HeaderText = "Longitud";
            this.Long.Name = "Long";
            this.Long.ReadOnly = true;
            this.Long.Width = 73;
            // 
            // Tipo_Indice
            // 
            this.Tipo_Indice.HeaderText = "Tipo Indice";
            this.Tipo_Indice.Name = "Tipo_Indice";
            this.Tipo_Indice.ReadOnly = true;
            this.Tipo_Indice.Width = 78;
            // 
            // Dir_Indice
            // 
            this.Dir_Indice.HeaderText = "Direccion Indice";
            this.Dir_Indice.Name = "Dir_Indice";
            this.Dir_Indice.ReadOnly = true;
            // 
            // Dir_SigAtrib
            // 
            this.Dir_SigAtrib.HeaderText = "Direccion Siguiente Atributo";
            this.Dir_SigAtrib.Name = "Dir_SigAtrib";
            this.Dir_SigAtrib.ReadOnly = true;
            this.Dir_SigAtrib.Width = 116;
            // 
            // pTituloAtrib
            // 
            this.pTituloAtrib.Controls.Add(this.lblEntidad);
            this.pTituloAtrib.Controls.Add(this.lbltextoA);
            this.pTituloAtrib.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTituloAtrib.Location = new System.Drawing.Point(0, 0);
            this.pTituloAtrib.Name = "pTituloAtrib";
            this.pTituloAtrib.Size = new System.Drawing.Size(786, 33);
            this.pTituloAtrib.TabIndex = 1;
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidad.Location = new System.Drawing.Point(243, 2);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(147, 31);
            this.lblEntidad.TabIndex = 1;
            this.lblEntidad.Text = "<Entidad>";
            this.lblEntidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltextoA
            // 
            this.lbltextoA.AutoSize = true;
            this.lbltextoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextoA.Location = new System.Drawing.Point(58, 2);
            this.lbltextoA.Name = "lbltextoA";
            this.lbltextoA.Size = new System.Drawing.Size(179, 31);
            this.lbltextoA.TabIndex = 0;
            this.lbltextoA.Text = "Atributos de ";
            this.lbltextoA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::Archivos.Properties.Resources.icons8_new_job_48;
            this.nuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.nuevoToolStripMenuItem.Text = "&Nueva Base de Datos";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // modificarBDToolStripMenuItem
            // 
            this.modificarBDToolStripMenuItem.Name = "modificarBDToolStripMenuItem";
            this.modificarBDToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.modificarBDToolStripMenuItem.Text = "Modificar BD";
            // 
            // eliminarBDToolStripMenuItem
            // 
            this.eliminarBDToolStripMenuItem.Image = global::Archivos.Properties.Resources.icons8_new_job_48__2_;
            this.eliminarBDToolStripMenuItem.Name = "eliminarBDToolStripMenuItem";
            this.eliminarBDToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.eliminarBDToolStripMenuItem.Text = "Eliminar BD";
            // 
            // nuevaEntidadToolStripMenuItem
            // 
            this.nuevaEntidadToolStripMenuItem.Image = global::Archivos.Properties.Resources.icons8_new_file_48;
            this.nuevaEntidadToolStripMenuItem.Name = "nuevaEntidadToolStripMenuItem";
            this.nuevaEntidadToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.nuevaEntidadToolStripMenuItem.Text = "Nueva Entidad";
            this.nuevaEntidadToolStripMenuItem.Click += new System.EventHandler(this.nuevaEntidadToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(786, 561);
            this.Controls.Add(this.pAtributos);
            this.Controls.Add(this.pEntidades);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Principal_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pEntidades.ResumeLayout(false);
            this.pEntidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntidades)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.pAtributos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAtributos)).EndInit();
            this.pTituloAtrib.ResumeLayout(false);
            this.pTituloAtrib.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel pEntidades;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cabeceraToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtCab;
        private System.Windows.Forms.ToolStripMenuItem longitudArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtLong;
        private System.Windows.Forms.Panel pAtributos;
        private System.Windows.Forms.DataGridView dgAtributos;
        private System.Windows.Forms.Panel pTituloAtrib;
        private System.Windows.Forms.DataGridView dgEntidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Atrib;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Atrib;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Da;
        private System.Windows.Forms.DataGridViewTextBoxColumn Long;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_SigAtrib;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Ent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Atributos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_SigEnt;
        private System.Windows.Forms.ToolStripMenuItem btn_Entidades;
        private System.Windows.Forms.ToolStripMenuItem nuevaEntidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaEntidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_Atributos;
        private System.Windows.Forms.ToolStripMenuItem nuevoAtributoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaAtributoToolStripMenuItem;
        private System.Windows.Forms.Label lbltextoA;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.ToolStripMenuItem btn_Registro;
        private System.Windows.Forms.ToolStripMenuItem modificarBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarBDToolStripMenuItem;
    }
}

