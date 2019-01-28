namespace Archivos
{
    partial class VistaIndice
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
            this.dGVPrimario1 = new System.Windows.Forms.DataGridView();
            this.Primario1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primario2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVPrimario2 = new System.Windows.Forms.DataGridView();
            this.PrimarioCajon1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimarioCajon2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCIndices = new System.Windows.Forms.TabControl();
            this.tPPrimarios = new System.Windows.Forms.TabPage();
            this.tPSecundarios = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgVSecundarios1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVSecundarios2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtbitPrincipal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBIt = new System.Windows.Forms.TextBox();
            this.txtSig = new System.Windows.Forms.TextBox();
            this.dgvHashDin2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvHashDin1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPrimario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPrimario2)).BeginInit();
            this.tabCIndices.SuspendLayout();
            this.tPPrimarios.SuspendLayout();
            this.tPSecundarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVSecundarios1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSecundarios2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHashDin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHashDin1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVPrimario1
            // 
            this.dGVPrimario1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPrimario1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Primario1,
            this.Primario2});
            this.dGVPrimario1.Location = new System.Drawing.Point(8, 74);
            this.dGVPrimario1.Name = "dGVPrimario1";
            this.dGVPrimario1.Size = new System.Drawing.Size(206, 389);
            this.dGVPrimario1.TabIndex = 0;
            this.dGVPrimario1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Primario1
            // 
            this.Primario1.Frozen = true;
            this.Primario1.HeaderText = "Letra/Num";
            this.Primario1.Name = "Primario1";
            this.Primario1.ReadOnly = true;
            this.Primario1.Width = 70;
            // 
            // Primario2
            // 
            this.Primario2.Frozen = true;
            this.Primario2.HeaderText = "Apuntador";
            this.Primario2.Name = "Primario2";
            this.Primario2.ReadOnly = true;
            this.Primario2.Width = 60;
            // 
            // dGVPrimario2
            // 
            this.dGVPrimario2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPrimario2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrimarioCajon1,
            this.PrimarioCajon2});
            this.dGVPrimario2.Location = new System.Drawing.Point(220, 74);
            this.dGVPrimario2.Name = "dGVPrimario2";
            this.dGVPrimario2.Size = new System.Drawing.Size(202, 389);
            this.dGVPrimario2.TabIndex = 1;
            // 
            // PrimarioCajon1
            // 
            this.PrimarioCajon1.HeaderText = "CB";
            this.PrimarioCajon1.Name = "PrimarioCajon1";
            this.PrimarioCajon1.Width = 60;
            // 
            // PrimarioCajon2
            // 
            this.PrimarioCajon2.HeaderText = "Ap";
            this.PrimarioCajon2.Name = "PrimarioCajon2";
            this.PrimarioCajon2.ReadOnly = true;
            this.PrimarioCajon2.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "Primarios";
            // 
            // tabCIndices
            // 
            this.tabCIndices.Controls.Add(this.tPPrimarios);
            this.tabCIndices.Controls.Add(this.tPSecundarios);
            this.tabCIndices.Controls.Add(this.tabPage1);
            this.tabCIndices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCIndices.Location = new System.Drawing.Point(0, 0);
            this.tabCIndices.Multiline = true;
            this.tabCIndices.Name = "tabCIndices";
            this.tabCIndices.SelectedIndex = 0;
            this.tabCIndices.Size = new System.Drawing.Size(438, 504);
            this.tabCIndices.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCIndices.TabIndex = 5;
            // 
            // tPPrimarios
            // 
            this.tPPrimarios.BackColor = System.Drawing.SystemColors.Control;
            this.tPPrimarios.Controls.Add(this.dGVPrimario2);
            this.tPPrimarios.Controls.Add(this.label1);
            this.tPPrimarios.Controls.Add(this.dGVPrimario1);
            this.tPPrimarios.Location = new System.Drawing.Point(4, 22);
            this.tPPrimarios.Name = "tPPrimarios";
            this.tPPrimarios.Padding = new System.Windows.Forms.Padding(3);
            this.tPPrimarios.Size = new System.Drawing.Size(430, 478);
            this.tPPrimarios.TabIndex = 0;
            this.tPPrimarios.Text = "Indices Primarios";
            // 
            // tPSecundarios
            // 
            this.tPSecundarios.BackColor = System.Drawing.SystemColors.Control;
            this.tPSecundarios.Controls.Add(this.comboBox1);
            this.tPSecundarios.Controls.Add(this.label2);
            this.tPSecundarios.Controls.Add(this.dgVSecundarios1);
            this.tPSecundarios.Controls.Add(this.dGVSecundarios2);
            this.tPSecundarios.Location = new System.Drawing.Point(4, 22);
            this.tPSecundarios.Name = "tPSecundarios";
            this.tPSecundarios.Padding = new System.Windows.Forms.Padding(3);
            this.tPSecundarios.Size = new System.Drawing.Size(430, 478);
            this.tPSecundarios.TabIndex = 1;
            this.tPSecundarios.Text = "Indices Secundarios";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(276, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 32);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 57);
            this.label2.TabIndex = 5;
            this.label2.Text = "Secundario de";
            // 
            // dgVSecundarios1
            // 
            this.dgVSecundarios1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVSecundarios1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgVSecundarios1.Location = new System.Drawing.Point(10, 63);
            this.dgVSecundarios1.Name = "dgVSecundarios1";
            this.dgVSecundarios1.Size = new System.Drawing.Size(260, 407);
            this.dgVSecundarios1.TabIndex = 3;
            this.dgVSecundarios1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVSecundarios1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "CB";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Ap";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dGVSecundarios2
            // 
            this.dGVSecundarios2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSecundarios2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.dGVSecundarios2.Location = new System.Drawing.Point(276, 63);
            this.dGVSecundarios2.Name = "dGVSecundarios2";
            this.dGVSecundarios2.Size = new System.Drawing.Size(148, 407);
            this.dGVSecundarios2.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Apuntador al registro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.txtbitPrincipal);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtBIt);
            this.tabPage1.Controls.Add(this.txtSig);
            this.tabPage1.Controls.Add(this.dgvHashDin2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgvHashDin1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(430, 478);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Hash Dinamico";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtbitPrincipal
            // 
            this.txtbitPrincipal.Location = new System.Drawing.Point(8, 52);
            this.txtbitPrincipal.Name = "txtbitPrincipal";
            this.txtbitPrincipal.ReadOnly = true;
            this.txtbitPrincipal.Size = new System.Drawing.Size(95, 20);
            this.txtbitPrincipal.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "bit Cajon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Siguiente Cajon";
            // 
            // txtBIt
            // 
            this.txtBIt.Location = new System.Drawing.Point(321, 49);
            this.txtBIt.Name = "txtBIt";
            this.txtBIt.ReadOnly = true;
            this.txtBIt.Size = new System.Drawing.Size(95, 20);
            this.txtBIt.TabIndex = 9;
            // 
            // txtSig
            // 
            this.txtSig.Location = new System.Drawing.Point(321, 24);
            this.txtSig.Name = "txtSig";
            this.txtSig.ReadOnly = true;
            this.txtSig.Size = new System.Drawing.Size(95, 20);
            this.txtSig.TabIndex = 8;
            this.txtSig.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSig_MouseClick);
            // 
            // dgvHashDin2
            // 
            this.dgvHashDin2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHashDin2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.dgvHashDin2.Location = new System.Drawing.Point(224, 75);
            this.dgvHashDin2.Name = "dgvHashDin2";
            this.dgvHashDin2.Size = new System.Drawing.Size(202, 389);
            this.dgvHashDin2.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "CB";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Ap";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hash Dinamico";
            // 
            // dgvHashDin1
            // 
            this.dgvHashDin1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHashDin1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvHashDin1.Location = new System.Drawing.Point(8, 75);
            this.dgvHashDin1.Name = "dgvHashDin1";
            this.dgvHashDin1.Size = new System.Drawing.Size(206, 389);
            this.dgvHashDin1.TabIndex = 5;
            this.dgvHashDin1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHashDin1_CellClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "Letra/Num";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "Apuntador";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 60;
            // 
            // VistaIndice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 504);
            this.Controls.Add(this.tabCIndices);
            this.Name = "VistaIndice";
            this.Text = "Indices";
            ((System.ComponentModel.ISupportInitialize)(this.dGVPrimario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPrimario2)).EndInit();
            this.tabCIndices.ResumeLayout(false);
            this.tPPrimarios.ResumeLayout(false);
            this.tPPrimarios.PerformLayout();
            this.tPSecundarios.ResumeLayout(false);
            this.tPSecundarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVSecundarios1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSecundarios2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHashDin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHashDin1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVPrimario1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primario1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primario2;
        private System.Windows.Forms.DataGridView dGVPrimario2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimarioCajon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimarioCajon2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabCIndices;
        private System.Windows.Forms.TabPage tPPrimarios;
        private System.Windows.Forms.TabPage tPSecundarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgVSecundarios1;
        private System.Windows.Forms.DataGridView dGVSecundarios2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvHashDin2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHashDin1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBIt;
        private System.Windows.Forms.TextBox txtSig;
        private System.Windows.Forms.TextBox txtbitPrincipal;
    }
}