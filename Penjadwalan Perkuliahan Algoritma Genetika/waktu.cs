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
    public partial class waktu : Form
    {
        MySqlConnection conn = conectionservice.getconection();

        public waktu()
        {
            InitializeComponent();
            tampilkan_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hapus_semua();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin menghapus data terpilih ?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = (int)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value;
                    hapus_data(id);
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tambah_waktu a = new tambah_waktu();
            DialogResult dr = a.ShowDialog();
        }


        public void tampilkan_data()
        {
            try
            {

                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM waktu;";
                da.SelectCommand = command;
                DataSet ds = new DataSet();
                da.Fill(ds, "hasil");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "hasil";
                                
                conn.Close();

                dataGridView1.Columns[0].HeaderText = "ID waktu";
                dataGridView1.Columns[1].HeaderText = "Hari";
                dataGridView1.Columns[2].HeaderText = "Jam";

                //konversi_kode_hari();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hapus_semua()
        {
            if (MessageBox.Show("Apakah anda yakin ingin menghapus semua data ?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string SQL = "DELETE FROM waktu;";
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(SQL, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                    }
                    conn.Close();
                    //MessageBox.Show("Berhasil menghapus semua data.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tampilkan_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void hapus_data(int id)
        {
            try
            {
                string SQL = "DELETE FROM waktu WHERE id=" + id + ";";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                }
                conn.Close();
                //MessageBox.Show("Berhasil menghapus data terpilih.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tampilkan_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void konversi_kode_hari()
        {
            int kode;
            dataGridView1.Columns.Add("Column4", "Nama hari");


            for(int i=0;i<dataGridView1.Rows.Count;i++)
            {
                String hasil;
                kode = (int)dataGridView1.Rows[i].Cells[1].Value;

                switch(kode)
                {
                    case 1:
                        hasil = "(1) Senin";
                        break;
                    case 2:
                        hasil = "(2) Selasa";
                        break;
                    case 3:
                        hasil = "(3) Rabu";
                        break;
                    case 4:
                        hasil = "(4) Kamis";
                        break;
                    case 5:
                        hasil = "(5) Jumat";
                        break;
                    default:
                        hasil = "(0) Minggu";
                        break;
                }
                dataGridView1.Rows[i].Cells[3].Value = hasil;

            }
        }
    }
}
