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
    public partial class VRegistro : Form
    {
        public event actualiza sobreescribe;
        public delegate void actualiza();

        public event modifica modificaReg;
        public delegate void modifica();

        Entidad e;
        ArchivoRegistros a;
        int actual = -1;

        public Entidad E { get => e; set => e = value; }
        public int Actual { get => actual; set => actual = value; }

        public VRegistro()
        {
            InitializeComponent();
        }

        public void VerTabla(Entidad entidad, Archivo arch)
        {
            e = entidad;
            a = (ArchivoRegistros)arch;
            Actualizar();
            
        }
        public void VerTabla(Entidad entidad)
        {
            e = entidad;

            dgTabla.Columns.Clear();
            foreach (Atributo a in e.Atrib)
                dgTabla.Columns.Add("col" + a.sNombre, a.sNombre);
            
            dgTabla.Rows.Clear();
           // if (e.Dir_Datos == -1) return;
            foreach (List<string> reg in e.Registros)
            {
                //string[] except = { reg.First(), reg.Last() };
                //string[] r = reg.Except(except).ToArray();
                reg.RemoveAt(0);
                reg.Remove(reg.Last());
                string[] r = reg.ToArray();
                dgTabla.Rows.Add(r);
            }
        }
        public void Actualizar()
        {
            dgTabla.Columns.Clear();
            dgTabla.Rows.Clear();
            foreach (Atributo a in e.Atrib)
            {
                dgTabla.Columns.Add("col" + a.sNombre, a.sNombre);
            }
            //dgTabla.Rows.Clear();
            if (e.Dir_Datos == -1) return;
            else a.leerArch(e.Dir_Datos);
            foreach (List<string> reg in e.Registros)
            {
                //string[] except = { reg.First(), reg.Last() };
                //string[] r = reg.Except(except).ToArray();
                var r = reg.GetRange(1, reg.Count - 2);
                dgTabla.Rows.Add(r.ToArray());
            }
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void eliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Eliminar Registro", "Estas seguro de eliminar el registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if(dialog == DialogResult.OK)
            {
                MessageBox.Show("", this.e.Registros[actual][0]);
                //this.e.Registros.RemoveAt(actual);
                this.e.EliminaRegistro(this.e.Registros[actual]);
                //actualizar el archivo
                sobreescribe();
            }
        }

        private void dgTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ToString());
        }

        private void dgTabla_CellClick(object sender, DataGridViewCellEventArgs en)
        {
            int index = en.RowIndex;

            //e.Registros.RemoveAt(index);
        }

        private void dgTabla_CellMouseDown(object sender, DataGridViewCellMouseEventArgs en)
        {
            
            actual = en.RowIndex;
            //MessageBox.Show(actual.ToString());
        }

        private void modificaRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (actual != -1)
            {
                modificaReg();
            }
        }
    }
}
