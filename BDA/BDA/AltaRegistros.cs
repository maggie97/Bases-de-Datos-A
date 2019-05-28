using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BDA
{
    public partial class AltaRegistros : Form
    {
        public event Actualiza actualizado;
        public delegate void Actualiza();

        //public event Foranea Integridad;
        //public delegate void Foranea();

        Entidad ent;
        List<string> shadow;
        String[] reg; 
        Archivo a;
        DDD diccionary;
         
        int regAct = 0 ;
        int lenght = 0;
        long DirReg; 
        public AltaRegistros(Entidad entidad, Archivo r, DDD dic)
        {
            InitializeComponent();
            lblNomEntidad.Text = entidad.sNombre; 
            ent = entidad;
            lenght = ent.Atrib.Count;
            reg =  new string[lenght + 2];
            DirReg = 0;
            a = r;
            diccionary = dic;
            btnAceptar.Visible = false;
            foreach (Atributo a in Ent.Atrib) 
                dgEntidad.Columns.Add("clm_" + a.sNombre, a.sNombre); 
        }
        public AltaRegistros(Entidad entidad, Archivo r, List<string> reg, DDD d)
        {
            InitializeComponent();
            lblNomEntidad.Text = entidad.sNombre;
            btn_Insert.Visible = false;
            ent = entidad;
            lenght = ent.Atrib.Count;
            this.reg = reg.ToArray();
            //elimino el reg
            shadow = reg;
            //entidad.EliminaRegistro(reg);
            //entidad.Registros.Remove(reg);
            diccionary = d;
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
                var leng = (reg[i] != null) ? reg[i].Length : 0;
                for (int j = leng; j < ent.Atrib[i].Longitud; j++)
                    switch (ent.Atrib[i].Tipo)
                    {
                        case 'C':
                            reg[i] += " ";
                            break;
                        case 'E':
                            //reg[i] = "0" + reg[i];
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
            var error = ""; 
            if(camposVacios() && (error = integridadReferencial()) == "") 
            {
                DirReg = a.Longitud;
                regAct = dgEntidad.CurrentRow.Index;
                reg[lenght + 1] = "-1" ;
                reg[0] = DirReg.ToString();
                if (!ent.nuevoReg(UltimoReg))
                    MessageBox.Show("No se añadio el registro");
                //Indice(1);
                reg = new string[lenght + 2];
                dgEntidad.Rows.Clear();
                ((ArchivoRegistros)a).sobreescribirArch();
                actualizado();
            }
            else
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string error = "";
            if (camposVacios())
            {
                int i = -1;
                var reg = ent.Registros;

                if ((i = ent.Atrib.FindIndex(o => o.TipoIndice == '2')) != -1) //tiene llave primaria
                {
                    var x = reg.Find(o => o[i] == UltimoReg[i]);
                    //la llave se repite ??
                    // si se repite marca error 
                    for (int j = 0; reg != null && j < reg.Count; j++)
                    {
                        var r = reg[j];
                        if (r[i] == UltimoReg[i])
                        {
                            error = "Error: Violacion a la integridad de datos";
                            break;
                        }
                    }

                }
                var foraneas = ent.Atrib.FindAll(o => o.TipoIndice == '3');
                error = integridadReferencial();

                if (error == "")
                {
                    //ent.EliminaRegistro(shadow);
                    //ent.nuevoReg(UltimoReg);
                    int index = ent.Registros.IndexOf(shadow);
                    ent.Registros.Remove(shadow);
                    //.EliminaRegistro(shadow);

                    ent.Registros.Insert(index, UltimoReg);
                    actualizado();
                }
                else
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string integridadReferencial()
        {
            if (ent.Prim != null)
            {
                int index = ent.Prim.index;
                if (ent.Registros.Find(o => Convert.ToInt32(o[index + 1]) == Convert.ToInt32(UltimoReg[index + 1])) != null)
                    return "error";
            }
            if (ent.Sec != null)
            {
                for (int i = 0; i < ent.Sec.Count; i++)
                {
                    var s = ent.Sec[i];
                    // = diccionary.EntidadesOrden.Find(o => o.Atrib.Find(a => a.sNombre.Contains(s.Atributo.sNombre)) != null);
                    var otra = diccionary.EntidadesOrden.Find(o => o.Atrib.Find(a => a.DirAtributo == s.Atributo.DirIndice) != null);
                    if (ent != null)
                    {
                        var indOtra = otra.Atrib.FindIndex(o => o.DirAtributo == s.Atributo.DirIndice);
                        var index = ent.Atrib.IndexOf(s.Atributo);
                        //var a = otra.Registros.Find(o => Convert.ToInt32(o[index + 1]) == Convert.ToInt32(UltimoReg[index + 1]));
                        if (otra.Registros == null || otra.Registros.Find(o => Convert.ToInt32(o[indOtra + 1]) == Convert.ToInt32(UltimoReg[index + 1])) == null)
                        {
                            return "Error de Integridad referencial";
                        }
                    }
                }
            }
            return "";
        }

        private void dgEntidad_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
