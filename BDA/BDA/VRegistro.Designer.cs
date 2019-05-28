namespace BDA
{
    partial class VRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgTabla = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabla)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgTabla
            // 
            this.dgTabla.AllowUserToAddRows = false;
            this.dgTabla.AllowUserToDeleteRows = false;
            this.dgTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabla.ContextMenuStrip = this.contextMenuStrip1;
            this.dgTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTabla.Location = new System.Drawing.Point(0, 0);
            this.dgTabla.Name = "dgTabla";
            this.dgTabla.ReadOnly = true;
            this.dgTabla.Size = new System.Drawing.Size(800, 450);
            this.dgTabla.TabIndex = 0;
            this.dgTabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTabla_CellClick);
            this.dgTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTabla_CellContentClick);
            this.dgTabla.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgTabla_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.eliminarRegistroToolStripMenuItem,
            this.modificaRegistroToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aToolStripMenuItem.Text = "Añadir Registro";
            // 
            // eliminarRegistroToolStripMenuItem
            // 
            this.eliminarRegistroToolStripMenuItem.Name = "eliminarRegistroToolStripMenuItem";
            this.eliminarRegistroToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.eliminarRegistroToolStripMenuItem.Text = "Eliminar Registro";
            this.eliminarRegistroToolStripMenuItem.Click += new System.EventHandler(this.eliminarRegistroToolStripMenuItem_Click);
            // 
            // modificaRegistroToolStripMenuItem
            // 
            this.modificaRegistroToolStripMenuItem.Name = "modificaRegistroToolStripMenuItem";
            this.modificaRegistroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificaRegistroToolStripMenuItem.Text = "Modifica Registro";
            this.modificaRegistroToolStripMenuItem.Click += new System.EventHandler(this.modificaRegistroToolStripMenuItem_Click);
            // 
            // VRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgTabla);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VRegistro";
            this.Text = "VRegistro";
            ((System.ComponentModel.ISupportInitialize)(this.dgTabla)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTabla;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaRegistroToolStripMenuItem;
    }
}