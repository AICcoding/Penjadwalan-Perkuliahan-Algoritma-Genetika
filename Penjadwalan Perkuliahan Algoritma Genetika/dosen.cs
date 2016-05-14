using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penjadwalan_Perkuliahan_Algoritma_Genetika
{
    public partial class dosen : Form
    {
        public dosen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tambah_dosen a = new tambah_dosen();
            DialogResult dr = a.ShowDialog();
        }
    }
}
