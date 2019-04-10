using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Archivos
{
    public partial class AltaRegistros : Form
    {
        public event Actualiza actualizado;
        public delegate void Actualiza();

        Entidad ent;
        String[] reg; 
        Archivo a;
         
        int regAct = 0 ;
        int lenght = 0;
        long DirReg; 
        public AltaRegistros(Entidad entidad, Archivo r)
        {
            InitializeComponent();
            lblNomEntidad.Text = entidad.sNombre; 
            ent = entidad;
            lenght = ent.Atrib.Count;
            reg =  new string[lenght + 2];
            DirReg = 0;
            a = r;
            btnAceptar.Visible = false;
            foreach (Atributo a in Ent.Atrib) 
                dgEntidad.Columns.Add("clm_" + a.sNombre, a.sNombre); 
        }
        public AltaRegistros(Entidad entidad, Archivo r, List<string> reg)
        {
            InitializeComponent();
            lblNomEntidad.Text = entidad.sNombre;
            btn_Insert.Visible = false;
            ent = entidad;
            lenght = ent.Atrib.Count;
            this.reg = reg.ToArray();
            //elimino el reg
            entidad.EliminaRegistro(reg);

            DirReg = Convert.ToInt64(reg[0]);
            a = r;

            foreach (Atributo a in Ent.Atrib) 
                dgEntidad.Columns.Add("clm_" + a.sNombre, a.sNombre); 
            
            dgEntidad.Rows.Insert(0, reg.GetRange(1, ent.Atrib.Count).ToArray());
            btn_Insert.Visible = false;
        }
        public Entidad Ent { get => ent;  }
        public List<string> UltimoReg { get => new List<string>(reg); }
        private int longitud
        {
            get {
                int longReg = 0;
                foreach (Atributo a in ent.Atrib) longReg += a.Longitud; 
                return longReg;
            }
        } 

        private void AltaRegistros_Load(object sender, EventArgs e) 
        { 
            for (int i = 1; i < lenght; i++)
            {
                for (int j = 0; j < ent.Atrib[i].Longitud; j++)
                    switch (ent.Atrib[i].Tipo)
                    {
                        case 'C':
                            reg[i] += " ";
                            break;
                        case 'E':
                            reg[i] += "0";
                            break;
                    }
            }
            dgEntidad.Rows.Add(); 
        }

        private void dgEntidad_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgEntidad.CurrentCell == null || dgEntidad.CurrentCell.Value == null) return;
            lblDato.Text = dgEntidad.CurrentCell.Value.ToString(); 
            if ( regAct == dgEntidad.CurrentRow.Index)
            { 
                reg[dgEntidad.CurrentCell.ColumnIndex+1] = dgEntidad.CurrentCell.Value.ToString(); 
                regAct = (dgEntidad.CurrentCell.ColumnIndex == ent.Atrib.Count-1) ?  -1: regAct;  
            }
            
        }

        private void dgEntidad_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        { 
            if(camposVacios()) 
            {
                DirReg = a.Longitud;
                regAct = dgEntidad.CurrentRow.Index;
                reg[lenght + 1] = "-1" ;
                reg[0] = DirReg.ToString();
                ent.nuevoReg(UltimoReg);
                
                reg = new string[lenght + 2];
                dgEntidad.Rows.Clear();
                actualizado();
            }
        }

        private bool camposVacios()
        {
            bool cont = true;
            for (int i = 1; i <= lenght && cont; i++)
            {
                cont = ((reg[i] != null) && !(reg[i].Equals(""))) ? true : false;
            }
            if (cont == false)
            {
                MessageBox.Show("Faltan Campos por rellenar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification); 
            }
            return cont;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (camposVacios())
            { 
                ent.nuevoReg(UltimoReg); 
                
                actualizado();
            }
        }
    }
}
