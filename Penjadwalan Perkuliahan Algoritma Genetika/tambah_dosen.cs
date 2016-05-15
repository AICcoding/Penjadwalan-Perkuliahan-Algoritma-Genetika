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
    public partial class tambah_dosen : Form
    {
        MySqlConnection conn = conectionservice.getconection();
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["dosen"];

        public tambah_dosen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nama;
                nama = textBox2.Text;
                nama = nama.Trim();
                if(nama=="")
                {
                    MessageBox.Show("Form masukan belum diisi !", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string SQL = "INSERT INTO dosen (nama) VALUES ('" + nama + "');";
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(SQL, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                    }
                    conn.Close();
                    MessageBox.Show("Berhasil menambahkan data", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((dosen)f).tampilkan_data();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
    }
}
