using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Archivos
{
    public partial class Principal : Form
    {
        DDD ddd;
        //List<Archivo> datos;
        public Principal()
        {
            InitializeComponent();
            MaximizeBox = true;
            pEntidades.ClientSize = new Size(pEntidades.Size.Width, ClientSize.Height/2) ;
            cierraArch();
        }
        #region botones
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoDD();
            dgAtributos.Rows.Clear();
            dgEntidades.Rows.Clear();

        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirDD();
            
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cierraArch();
        }
        private void nuevaEntidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevaEnt();
            txtCab.Text = ddd.Cab.ToString();
        }
        private void eliminaEntidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgEntidades.SelectedRows)
            {
                if (!r.IsNewRow)
                {
                    int i = dgEntidades.Rows.IndexOf(r);
                    ddd.eliminaEntidad(r.Cells[0].Value.ToString());
                    actualizaEnt();
                }
            }
        }
        private void nuevoAtributoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoAtributo nuevo = new NuevoAtributo(ddd.EntidadesOrden);
            if (nuevo.ShowDialog() == DialogResult.OK)
            {
                Entidad ent = ddd.nuevoAtributo(nuevo.Nombre_atributo, nuevo.Tipo, nuevo.Long, nuevo.Index, nuevo.TipoIndex);
                AtribEnt(ent);
                lblEntidad.Text = ent.sNombre;
                actualizaEnt();
            }
        }
        private void eliminaAtributoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgAtributos.SelectedRows)
            {
                if (!r.IsNewRow)
                {
                    int i = dgAtributos.Rows.IndexOf(r);
                    ddd.eliminaAtributo(lblEntidad.Text, i);
                    actualizaEnt();
                    AtribEnt(lblEntidad.Text);
                }
            }
        }

        private void insertaRegistro_Click(object sender, EventArgs e)
        {
            Entidad ent;
            if(dgEntidades.CurrentCell.Value == null)
            {
                MessageBox.Show("Selecciona una entidad", "Sin Entidades", MessageBoxButtons.OK, MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                return;
            }
            else
            {
                ent = ddd.EntidadesOrden.Find(o => o.sNombre.Contains(lblEntidad.Text));
                VistaRegistros ventanaReg = new VistaRegistros(ent, ddd.Fullname);
                ventanaReg.actualizado += new VistaRegistros.Actualiza(actualizaEnt);
                ventanaReg.actualizado += new VistaRegistros.Actualiza(ddd.sobreescribe_archivo);
                ventanaReg.Show();
                actualizaEnt();
                AtribEnt(lblEntidad.Text);
                Enable_Entidades_Atributos(false);
            }
            if (Enable_Entidades_Atributos() ) 
            {
                if (MessageBox.Show("Al ingresar un registro a este Diccionario de Datos " +
                    "ya no podras ingresar ninguna Entidad o Atributo. \n ¿Estas seguro de que deseas continuar?",
                    "Registros", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.ServiceNotification) == DialogResult.No)
                    return;
                else
                    Enable_Entidades_Atributos(false);
            } 
        } 
        
        #endregion
        private void nuevoDD()
        {
            using (nuevoArchivo n = new nuevoArchivo())
            {
                if (n.ShowDialog() == DialogResult.OK)
                {
                    ddd = new DDD(n.name, ".dd", n.direccion);
                    using (BinaryWriter writer = new BinaryWriter(File.Open(ddd.Fullname, FileMode.Create)))
                    {
                        writer.Write(ddd.Cab);
                        txtCab.Text = ddd.Cab.ToString();
                        Enable_Entidades_Atributos(true);
                        btn_Registro.Enabled = true;
                    }
                }
            }
        }

        private void abrirDD()
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Diccionario de Datos (*.dd)| *.dd";
                ///open.InitialDirectory = Directory.GetParent(ddd.Fullname).ToString();
                open.Title = "Seleciona un Diccionario de datos";
                if (open.ShowDialog() == DialogResult.OK)
                { 
                    ddd = new DDD(open.FileName);
                    ddd.lee();
 
                    //Actualiza DataGrid
                    actualizaEnt();
                    dgAtributos.Rows.Clear();
                    txtCab.Text = ddd.Cab.ToString();
                    Enable_Entidades_Atributos(true);
                    btn_Registro.Enabled = true;
                    
                } 
            }
        }
        private void cierraArch()
        {
            Enable_Entidades_Atributos(false);
            btn_Registro.Enabled = false;
            dgEntidades.Rows.Clear();
            dgAtributos.Rows.Clear();
        }
        
        private void Enable_Entidades_Atributos(bool valor)
        {
            btn_Atributos.Enabled = valor;
            btn_Entidades.Enabled = valor;
        }

        private bool Enable_Entidades_Atributos()
        {
            return (btn_Atributos.Enabled && btn_Entidades.Enabled);
        }

        private void nuevaEnt()
        {
            NuevaEntidad nueva_ent = new NuevaEntidad();
            if (nueva_ent.ShowDialog() == DialogResult.OK)
            {
                ddd.nuevaEntidad(nueva_ent.Nombre_Entidad.ToString());
                actualizaEnt();
                Enable_Entidades_Atributos(true);
            }
        }
        private void actualizaEnt()
        {
            txtCab.Text = ddd.Cab.ToString();
            dgEntidades.Rows.Clear(); 
            foreach(Entidad e in ddd.EntidadesOrden)//ddd.RefreshGrid())//
            {
                dgEntidades.Rows.Add(e.sNombre, e.Dir_Entidad, e.Dir_Atributos, e.Dir_Datos, e.Dir_sig);
            }
        }
        #region datagrid Entidaes
        /// <summary>
        /// Modifica las entidades al darle doble click en la data grid
        /// </summary>
        private void dgEntidades_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Entidad eMod = ddd.EntidadesOrden[e.RowIndex];//list_entidades[e.RowIndex];
            string newName = Microsoft.VisualBasic.Interaction.InputBox("Modifica la entidad : " + eMod.sNombre + " " + e.RowIndex, "Modificar", eMod.sNombre, -1, -1);
            if(newName != "")
            {
                while (newName.Length < 30) newName += ' ';
                eMod.NombreEntidad = newName.ToCharArray(0, 30);
            }
            ddd.ordena();
            ddd.sobreescribEntidad(eMod);
            ddd.sobreescribe_archivo();
            actualizaEnt();
        }


        #endregion
        #region dataGrid Attributos

        /// <summary>
        /// Modifica atributo al darle doble click en el datagrid de atributos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgAtributos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Entidad ent = null;
            for (int i = 0; i < ddd.EntidadesOrden.Count && (ent = ddd.EntidadesOrden[i]).sNombre != lblEntidad.Text; i++) ; 
            if (ent != null)
            {
                Atributo aMod = ent.Atrib[e.RowIndex];
                using (NuevoAtributo n = new NuevoAtributo(aMod.sNombre, aMod.Tipo, aMod.Longitud, aMod.TipoIndice, ent))
                {
                    if (n.ShowDialog() == DialogResult.OK)
                    {
                        string nomb = n.Nombre_atributo;
                        if (nomb != "")
                        {
                            while (nomb.Length < 30) nomb += ' ';
                            aMod.Nombre = nomb.ToCharArray(0, 30);
                        }
                        aMod.Tipo = (n.Tipo == 0) ? 'C' : 'E';
                        aMod.Longitud = n.Long;
                        aMod.TipoIndice = n.TipoIndex;
                        ddd.sobreescribAtributo(aMod);
                        AtribEnt(ent);
                    }
                } 
            }
        }
        #endregion

        private void AtribEnt(Entidad e)
        {
            dgAtributos.Rows.Clear();
            foreach (Atributo a in e.Atrib)//ddd.Entidades)
            {
                dgAtributos.Rows.Add(a.sNombre, a.DirAtributo, a.Tipo, a.Longitud, a.TipoIndice, a.DirIndice, a.DirSig);
            }
        }

        private void AtribEnt(string ent)
        {
            dgAtributos.Rows.Clear();
            Entidad e = ddd.EntidadesOrden.Find(o => o.sNombre.Contains(ent));
            foreach (Atributo a in e.Atrib)
            {
                dgAtributos.Rows.Add(a.sNombre, a.DirAtributo, a.Tipo, a.Longitud, a.TipoIndice, a.DirIndice, a.DirSig);
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void Principal_Paint(object sender, PaintEventArgs e)
        {
            Longitud();
        }
        private void Longitud()
        {
            if (ddd != null)
                txtLong.Text = ddd.Longitud.ToString();
        }

        private void dgEntidades_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            Entidad ent = ddd.EntidadesOrden[e.RowIndex];
            AtribEnt(ent);
            lblEntidad.Text = ent.sNombre;
        }

        private void r2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}

