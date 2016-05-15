using MySql.Data.MySqlClient;
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
    public partial class tambah_waktu : Form
    {
        MySqlConnection conn = conectionservice.getconection();
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["waktu"];

        public tambah_waktu()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string jam;
                int hari;
                jam = textBox1.Text;
                hari = comboBox1.SelectedIndex+1;

                jam = jam.Trim();
                if (jam == "")
                {
                    MessageBox.Show("Form masukan belum diisi !", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string SQL = "INSERT INTO waktu (hari, jam) VALUES (" + hari + ", '" + jam + "');";
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(SQL, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                    }
                    conn.Close();
                    MessageBox.Show("Berhasil menambahkan data", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((waktu)f).tampilkan_data();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
    }
}
