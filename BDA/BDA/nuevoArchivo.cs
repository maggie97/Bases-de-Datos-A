using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace BDA
{
    public partial class nuevoArchivo : Form
    {
        public nuevoArchivo()
        {
            InitializeComponent();
            txt_Path.Text = Directory.GetCurrentDirectory();
            //folderBrowserDialog1.ShowDialog();
        }

        private void btn_Explora_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_Path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void nuevoArchivo_Load(object sender, EventArgs e)
        {

        }
    }
}
