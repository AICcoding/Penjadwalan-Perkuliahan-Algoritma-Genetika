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
    public partial class matakuliah : Form
    {
        MySqlConnection conn = conectionservice.getconection();

        public matakuliah()
        {
            InitializeComponent();
            tampilkan_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tambah_matakuliah a = new tambah_matakuliah();
            DialogResult dr = a.ShowDialog();
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

        private void button3_Click(object sender, EventArgs e)
        {
            hapus_semua();
        }



        public void tampilkan_data()
        {
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM matkul;";
                da.SelectCommand = command;
                DataSet ds = new DataSet();
                da.Fill(ds, "hasil");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "hasil";
                conn.Close();

                dataGridView1.Columns[0].HeaderText = "ID matakuliah";
                dataGridView1.Columns[1].HeaderText = "Nama matakulia";
                dataGridView1.Columns[2].HeaderText = "Jumlah SKS";
                dataGridView1.Columns[3].HeaderText = "Semester";

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
                    string SQL = "DELETE FROM matkul;";
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
                string SQL = "DELETE FROM matkul WHERE id="+id+";";
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

    }
}
