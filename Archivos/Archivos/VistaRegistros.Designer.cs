namespace Archivos
{
    partial class VistaRegistros
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgVReg = new System.Windows.Forms.DataGridView();
            this.importarRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVReg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertaToolStripMenuItem,
            this.eliminaToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.indicesToolStripMenuItem,
            this.importarRegistrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insertaToolStripMenuItem
            // 
            this.insertaToolStripMenuItem.Name = "insertaToolStripMenuItem";
            this.insertaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.insertaToolStripMenuItem.Text = "Inserta";
            this.insertaToolStripMenuItem.Click += new System.EventHandler(this.insertaToolStripMenuItem_Click);
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            this.eliminaToolStripMenuItem.Click += new System.EventHandler(this.eliminaToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // indicesToolStripMenuItem
            // 
            this.indicesToolStripMenuItem.Name = "indicesToolStripMenuItem";
            this.indicesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.indicesToolStripMenuItem.Text = "Indices";
            this.indicesToolStripMenuItem.Click += new System.EventHandler(this.indicesToolStripMenuItem_Click);
            // 
            // dgVReg
            // 
            this.dgVReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVReg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgVReg.Location = new System.Drawing.Point(0, 24);
            this.dgVReg.MultiSelect = false;
            this.dgVReg.Name = "dgVReg";
            this.dgVReg.ReadOnly = true;
            this.dgVReg.Size = new System.Drawing.Size(556, 355);
            this.dgVReg.TabIndex = 1;
            // 
            // importarRegistrosToolStripMenuItem
            // 
            this.importarRegistrosToolStripMenuItem.Name = "importarRegistrosToolStripMenuItem";
            this.importarRegistrosToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.importarRegistrosToolStripMenuItem.Text = "Importar Registros";
            this.importarRegistrosToolStripMenuItem.Click += new System.EventHandler(this.importarRegistrosToolStripMenuItem_Click);
            // 
            // VistaRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 379);
            this.Controls.Add(this.dgVReg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VistaRegistros";
            this.Text = "Registros";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insertaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgVReg;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarRegistrosToolStripMenuItem;
    }
}