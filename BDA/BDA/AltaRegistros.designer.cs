namespace BDA
{
    partial class AltaRegistros
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
            this.dgEntidad = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNomEntidad = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.lblDato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEntidad
            // 
            this.dgEntidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntidad.Location = new System.Drawing.Point(13, 55);
            this.dgEntidad.Name = "dgEntidad";
            this.dgEntidad.Size = new System.Drawing.Size(379, 80);
            this.dgEntidad.TabIndex = 0;
            this.dgEntidad.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEntidad_CellEndEdit);
            this.dgEntidad.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEntidad_CellValueChanged);
            this.dgEntidad.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEntidad_RowLeave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(236, 141);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblNomEntidad
            // 
            this.lblNomEntidad.AutoSize = true;
            this.lblNomEntidad.Location = new System.Drawing.Point(208, 31);
            this.lblNomEntidad.Name = "lblNomEntidad";
            this.lblNomEntidad.Size = new System.Drawing.Size(55, 13);
            this.lblNomEntidad.TabIndex = 3;
            this.lblNomEntidad.Text = "<Entidad>";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(71, 31);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(119, 13);
            this.lblReg.TabIndex = 4;
            this.lblReg.Text = "Registros de la Entidad ";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Location = new System.Drawing.Point(317, 141);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(155, 141);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 6;
            this.btn_Insert.Text = "Insertar";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Location = new System.Drawing.Point(302, 31);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(42, 13);
            this.lblDato.TabIndex = 7;
            this.lblDato.Text = "<Dato>";
            // 
            // AltaRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(410, 176);
            this.Controls.Add(this.lblDato);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.lblNomEntidad);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgEntidad);
            this.Name = "AltaRegistros";
            this.Text = "Alta de Registro";
            this.Load += new System.EventHandler(this.AltaRegistros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEntidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEntidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNomEntidad;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label lblDato;
    }
}