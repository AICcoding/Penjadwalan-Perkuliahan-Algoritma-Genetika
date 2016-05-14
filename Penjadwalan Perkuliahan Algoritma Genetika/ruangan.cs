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
    public partial class ruangan : Form
    {
        public ruangan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tambah_ruangan a = new tambah_ruangan();
            DialogResult dr = a.ShowDialog();
        }
    }
}
