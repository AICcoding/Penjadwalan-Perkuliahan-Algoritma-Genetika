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
    public partial class matakuliah : Form
    {
        public matakuliah()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tambah_matakuliah a = new tambah_matakuliah();
            DialogResult dr = a.ShowDialog();
        }
    }
}
