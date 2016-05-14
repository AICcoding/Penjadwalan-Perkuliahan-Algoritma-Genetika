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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matakuliah a = new matakuliah();
            DialogResult dr = a.ShowDialog();
        }

        private void dosenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosen a = new dosen();
            DialogResult dr = a.ShowDialog();
        }

        private void ruangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ruangan a = new ruangan();
            DialogResult dr = a.ShowDialog();
        }

        private void mataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relasi_matakuliah_dosen_ruangan a = new relasi_matakuliah_dosen_ruangan();
            DialogResult dr = a.ShowDialog();
        }

        private void waktuLaranganDosenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waktu_larangan_dosen a = new waktu_larangan_dosen();
            DialogResult dr = a.ShowDialog();
        }

        private void prosesAlgoritmaGenetikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setting_parameter_algoritma_genetika a = new setting_parameter_algoritma_genetika();
            DialogResult dr = a.ShowDialog();
        }

        private void cekUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value += 1;
            }
            MessageBox.Show("Anda telah menggunakan versi terbaru dari aplikasi ini.", "Aplikasi Up to date", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar1.Value = 0;
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikasi penjadwalan perkuliahan ini dibuat oleh mahasiswa ilmu komputer udayana.\n\n1. I Wayan Ariantha Sentanu\t[1308605009].\n2. I Putu Agus Suarya W.\t[1308605034].", "Tentang Developer", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void tentangAplikasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- Aplikasi ini merupakan aplikasi penjadwalan perkuliahan dengan menggunakan metode algorita genetika.\n\n- Algoritma genetika merupakan algoritma back to nature, sehingga penggabungan dari teknologi dan back to nature menghasilkan sesuatu yang mendekati sempurna, dalam hal ini penjadwalan perkuliahan.", "Tentang Aplikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
