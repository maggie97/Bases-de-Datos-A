using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDA
{
    public partial class NuevoAtributo : Form
    {
        DDD diccionario;
        Entidad entidad;
        public NuevoAtributo(Entidad entidad, DDD dic)
        {
            this.entidad = entidad;
            InitializeComponent();
            //entidad.Indice(0);
            num_Long.Text = "4";
            diccionario = dic;
            lblEntidad.Text = entidad.sNombre;
            cmbTipo.Items.AddRange(new object[] {"int", "float", "char" });
            if(entidad.Prim == null)
                cmbIndice.Items.AddRange(new object[] {"Sin Llave", "Llave Primaria", "Llave Foranea" });
            else
                cmbIndice.Items.AddRange(new object[] { "Sin Llave", "Llave Foranea" });
            cmbIndice.SelectedIndex = 0;
            cmbTipo.SelectedIndex = 0;
        }
        public void modifica(Atributo a)
        {

        }
        public string Nombre_atributo { get => txt_Nombre.Text; }
        public int Long { get => Convert.ToInt32(num_Long.Text); }
        public int Tipo { get => cmbTipo.SelectedIndex; }

        public int TipoIndex {
            get {
                string s = (string)cmbIndice.SelectedItem;
                int i = 0;
                switch (s)
                {
                    case "Llave Primaria":
                        i = 2;
                        break;
                    case "Llave Foranea":
                        i = 3;
                        break;
                }
                return i;
            }
        }
        //public 

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Tipo)
            {
                case 0: //int 
                    num_Long.Value = 4;
                    num_Long.Enabled = false;
                    break;
                case 1:
                    num_Long.Value = 4;
                    num_Long.Enabled = false;
                    break;
                default:
                    num_Long.Value = 1;
                    num_Long.Enabled = true;
                    break;
            }
        }
        public Atributo Relacion {
            get
            {
                if (TipoIndex == 3)
                {
                    string nEnt = cmbLlave.SelectedItem.ToString().Split(':')[0];
                    Entidad e = diccionario.EntidadesOrden.Find(o => o.shortName.CompareTo(nEnt) == 0);
                    
                    return e.Prim.Atributo;
                }
                return null;
            }
        }

        private void cmbIndice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TipoIndex == 3)
            {
                cmbLlave.Visible = true;
                lblLlave.Visible = true;
                cmbLlave.Items.Clear();
                foreach(Entidad ent in diccionario.EntidadesOrden)
                {
                    if(ent!=entidad &&  ent.Prim != null)
                    {
                        cmbLlave.Items.AddRange(new object[] { ent.shortName + ":"+ ent.Prim.Atributo.sNombre });
                    }
                }
            }
            else
            {
                cmbLlave.Visible = false;
                lblLlave.Visible = false;
            }
        }

    }
}
