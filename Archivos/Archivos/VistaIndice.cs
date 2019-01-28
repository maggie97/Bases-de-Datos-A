using Archivos.Controladores;
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
    public partial class VistaIndice : Form
    {
        private const string Nada = "-1";
        Indice indice;
        Primario p;
        Entidad entidad;
        List<Secundario> s;
        HashDinamico h;
        public VistaIndice(Entidad e)
        {
            InitializeComponent();
            entidad = e;
            p = e.Prim;
            s = e.Sec;
            foreach(var a in e.Atrib)
            {
                switch (a.TipoIndice)
                {
                    case 2:
                        indice = a.Ind;
                        p = (Primario)indice;
                        break;
                    /*case 3:
                        indice = a.Ind;
                        if (s == null)
                             s = new List<Secundario>();
                        s.Add((Secundario)indice);
                        break;*/
                }
            }
            Atributo z = e.Atrib.Find(o => o.TipoIndice == 6);
            if (z != null && z.DirAtributo != -1)
            {
                h = (HashDinamico)z.Ind;
            }
            if (p!= null)
                carga();
            if(s!= null)
            {
                cargaSec();
            }
            if(h != null)
            {
                hash();
            }
        }
        private void carga()
        {
            p.leePrimario();
            for(int i = 0; p.prim.Ind != null && i < p.prim.Longitud; i++)
            {
                dGVPrimario1.Rows.Add(p.prim.Ind[i].ToString(), p.prim.Ap[i].ToString());
            }
        }

        private void cargaSec( )
        {
            foreach(Secundario sec in s)
            {
                comboBox1.Items.Add(sec.Atributo.sNombre);
            }
            comboBox1.SelectedIndex = 0;
            muestra(0);
        }
        private void hash()
        {
            h.leePrincipal(h.Atributo.DirIndice);
            txtbitPrincipal.Text = h.Bit.ToString();
            //dgvHashDin1.Rows.Add(h.Principal[0].Cb.ToString(), h.Principal[0].Ap.ToString());
            string a = "-1";
            for (int i = 0; i < h.Principal.Count; i++)
            {
                if (a != h.Principal[i].Cb.Substring(0, h.Bit))
                {
                    dgvHashDin1.Rows.Add(h.Principal[i].Cb.ToString(), h.Principal[i].Ap.ToString());
                    a = h.Principal[i].Cb.Substring(0, h.Bit);
                }
            }
        }

        private void muestra(int j)
        {
            dgVSecundarios1.Rows.Clear();
            s[j].leeBloquePrincipal(s[j].Atributo.DirIndice);
            for(int k = 0; k < s[j].Principal.Count; k++ )
                for (int i = 0; s[j].Principal != null && i < s[j].Principal[k].Capacidad; i++)
                {
                    var e = s[j].Principal[k].Elementos[i];
                    dgVSecundarios1.Rows.Add(e.Cb, e.Ap);
                }
        }

        public void actualiza()
        {
            if (p != null)
                carga();
            if(s != null)
                muestra(comboBox1.SelectedIndex);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int valor = 0;
            dGVPrimario2.Rows.Clear();
            if (!Int32.TryParse(dGVPrimario1.CurrentCell.Value.ToString(), out valor)) return;
            if (valor == -1) return;
            int i = dGVPrimario1.CurrentCell.RowIndex;
            int x = 0;
            var c = p.ElCajon(Convert.ToInt64(dGVPrimario1.CurrentCell.Value));
            for(int j = 0; c != null && j< c.Longitud; j++)
            {
                dGVPrimario2.Rows.Add(c.Cb[j], c.Ap[j]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            muestra(comboBox1.SelectedIndex);
        }

        private void dgVSecundarios1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int valor = 0;
            dGVSecundarios2.Rows.Clear();
            if (dgVSecundarios1.CurrentCell.Value == null && (int)dgVSecundarios1.CurrentCell.Value == -1) { return; }
            if (!Int32.TryParse(dgVSecundarios1.CurrentCell.Value.ToString(), out valor)) return;
            int i = dgVSecundarios1.CurrentCell.RowIndex;
            int x = 0;
            Secundario c;
            var cS = s[comboBox1.SelectedIndex].leeCajon(Convert.ToInt64(dgVSecundarios1.CurrentCell.Value));
            for (int j = 0; cS!= null && j < cS.Capacidad; j++)
            {
                dGVSecundarios2.Rows.Add(cS.Ap[j]);
            }
        }

        private void dgvHashDin1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int valor = 0;
            dgvHashDin2.Rows.Clear();
            txtBIt.Text = "-1";
            txtSig.Text = "-1";
            if (dgvHashDin1.CurrentCell.Value == null && (int)dgvHashDin1.CurrentCell.Value == -1) { return; }
            if (!Int32.TryParse(dgvHashDin1.CurrentCell.Value.ToString(), out valor)) return;
            int i = dgvHashDin1.CurrentCell.RowIndex;
            var cS = h.leeCajon(Convert.ToInt64(dgvHashDin1.CurrentCell.Value));
            long a = 0;
            for (int j = 0; cS != null && j < cS.Capacidad; j++)
            {
                dgvHashDin2.Rows.Add(cS.Elementos[j].Cb, cS.Elementos[j].Ap);
                a = cS.Elementos[j].Ap;
            }
            if (cS != null)
            {
                txtBIt.Text = cS.Bit.ToString();
                txtSig.Text = cS.Sig.ToString();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtSig_MouseClick(object sender, MouseEventArgs e)
        {
            int valor = 0;
            dgvHashDin2.Rows.Clear();
            if (txtSig.Text == "" || txtSig.Text == "-1") { return; }
            if (!Int32.TryParse(txtSig.Text, out valor)) return;
            txtBIt.Text = "-1";
            txtSig.Text = "-1";
            var cS = h.leeCajon(valor);
            long a = 0;
            for (int j = 0; cS != null && j < cS.Capacidad; j++)
            {
                dgvHashDin2.Rows.Add(cS.Elementos[j].Cb, cS.Elementos[j].Ap);
                a = cS.Elementos[j].Ap;
            }
            if (cS != null)
            {
                txtBIt.Text = cS.Bit.ToString();
                txtSig.Text = cS.Sig.ToString();
            }
        }
    }
}
