using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivos
{
    public partial class VistaRegistros : Form
    {
        public event Actualiza actualizado;
        public delegate void Actualiza();
        Entidad entidad;
        ArchivoRegistros archivo;
        public VistaRegistros(Entidad e, string dir)
        {
            InitializeComponent();
            
            entidad = e;
            archivo = new ArchivoRegistros(dir, entidad);

            //define las columnas del datagried de los registros 
            dgVReg.Columns.Add("dir_Reg", "Direccion del registro");
            for (int i = 0; i < e.Atrib.Count; i++)
            {
                dgVReg.Columns.Add(e.Atrib[i].sNombre, e.Atrib[i].sNombre);
            }
            dgVReg.Columns.Add("dir_SigReg", "Direccion del siguiente registro");
            if (entidad.Registros != null)
            {
                foreach (List<string> reg in entidad.Registros)
                {
                    dgVReg.Rows.Add(reg.ToArray());
                }
            }
        }
        
        public void actualiza()
        {
            actualizado();
            dgVReg.Rows.Clear();
            foreach(List<string> reg in entidad.Registros)
            {
                dgVReg.Rows.Add(reg.ToArray()); 
            }
            archivo.sobreescribirArch();
            actualizaindices();
        }
        public void actualizaindices()
        {
            if(entidad.Prim != null)
            {
                entidad.Prim.escribePrimario();
                var p = entidad.Prim;
            }
        }
        private void insertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaRegistros alta = new AltaRegistros(entidad, archivo);
            alta.actualizado += new AltaRegistros.Actualiza(actualiza);
            alta.ShowDialog(); 
        }

        private void eliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (entidad.Registros == null ||  entidad.Registros.Count == 0) return;
            var regElim = entidad.Registros[dgVReg.CurrentCell.RowIndex];
            if (dgVReg.CurrentCell.RowIndex == 0 && dgVReg.CurrentCell.RowIndex == entidad.Registros.Count)
            {
                //primer reg y unico reg 
                entidad.Dir_Datos = -1;
                archivo.elimina();
            }
            else if(dgVReg.CurrentCell.RowIndex == 0)
            {
                entidad.Dir_Datos = Convert.ToInt64(regElim[entidad.Registros[0].Count - 1]);
            }
            else if(entidad.Registros.Count > 1)
            {
                var regAnt = entidad.Registros[dgVReg.CurrentCell.RowIndex - 1]; //reg anterior al eliminado 
                regAnt[entidad.Registros[0].Count - 1] = regElim[entidad.Registros[0].Count - 1];
            }
            regElim[entidad.Registros[0].Count - 1] = "-1";
            entidad.EliminaRegistro(regElim);
            archivo.sobreescribirArch();
            
            archivo.leerArch(entidad.Dir_Datos);
            actualiza();
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgVReg.CurrentCell.Value.ToString() != "")
            {
                int i = dgVReg.CurrentCell.RowIndex;
                var CurrentReg = entidad.Registros[i];
                AltaRegistros a = new AltaRegistros(entidad, archivo, CurrentReg);
                a.actualizado += new AltaRegistros.Actualiza(actualiza);
                a.ShowDialog();
            } 
        }

        private void indicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaIndice vInd = new VistaIndice(entidad);
            vInd.Show();
        }

        private void importarRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                //open.Filter = "Diccionario de Datos (*.dd)| *.dd";
                //open.Title = "Seleciona un Diccionario de datos";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string nombre = open.FileName;
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(nombre))
                    {
                        while (sr.Peek() != -1)
                        {
                            string todo = sr.ReadLine();
                            var a = todo.Split(',');
                            Console.WriteLine(a);
                            List<string> nuevo = new List<string>();
                            nuevo.Add(archivo.Longitud.ToString());
                            a[0].ToList().Remove('0');
                            Console.WriteLine(a);
                            int i = a[0].ToList().FindIndex(o => o != '0');
                            string s = a[0].Substring(i);
                            nuevo.Add(s);
                            nuevo.Add(a[1]);
                            nuevo.Add("-1");
                            entidad.nuevoReg(nuevo);
                            actualiza();
                        }
                    }
                    //actualiza();
                    actualizado();
                   /* ddd = new DDD(open.FileName);
                    ddd.lee();

                    //Actualiza DataGrid
                    actualizaEnt();
                    dgAtributos.Rows.Clear();
                    txtCab.Text = ddd.Cab.ToString();
                    Enable_Entidades_Atributos(true);
                    btn_Registro.Enabled = true;*/

                }
            }
        }
    }
}
