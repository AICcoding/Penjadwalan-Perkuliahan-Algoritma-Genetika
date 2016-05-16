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
    public partial class relasi_matakuliah_dosen_ruangan : Form
    {
        MySqlConnection conn = conectionservice.getconection();

        public relasi_matakuliah_dosen_ruangan()
        {
            InitializeComponent();

            isi_combobox();
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
            if (comboBox1.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Silakan pilih data terlebih dahulu!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tambah_data();
            }
        }

        private void isi_combobox()
        {
            try
            {
                string SQL = "SELECT * FROM matkul;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String data = "(" + reader.GetString("id") + ") " + reader.GetString("nama");
                    comboBox1.Items.Add(data);
                }
                conn.Close();

                conn.Open();
                SQL = "SELECT * FROM dosen;";
                cmd = new MySqlCommand(SQL, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String data = "(" + reader.GetString("id") + ") " + reader.GetString("nama");
                    comboBox3.Items.Add(data);
                }
                conn.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void tampilkan_data()
        {
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM matkul_dosen, matkul, dosen WHERE matkul_dosen.id_dosen=dosen.id AND matkul_dosen.id_matkul=matkul.id;";

                da.SelectCommand = command;
                DataSet ds = new DataSet();
                da.Fill(ds, "hasil");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "hasil";
                conn.Close();

                dataGridView1.Columns[0].HeaderText = "ID relasi";
                dataGridView1.Columns[1].HeaderText = "ID matkul";
                dataGridView1.Columns[2].HeaderText = "ID dosen";
                dataGridView1.Columns[3].HeaderText = "ID matkul";
                dataGridView1.Columns[4].HeaderText = "Nama matkul";
                dataGridView1.Columns[5].HeaderText = "Jumlah SKS";
                dataGridView1.Columns[6].HeaderText = "Semester";
                dataGridView1.Columns[7].HeaderText = "ID dosen";
                dataGridView1.Columns[8].HeaderText = "Nama dosen";

                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;

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
                    string SQL = "DELETE FROM matkul_dosen;";
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
                string SQL = "DELETE FROM matkul_dosen WHERE id=" + id + ";";
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

        private void tambah_data()
        {
            try
            {
                int id_matkul, id_dosen, id_ruangan;
                id_matkul = cari_id(1);  //matkul
                id_dosen = cari_id(2);   //dosen

                string SQL = "INSERT INTO matkul_dosen (id_matkul, id_dosen) VALUES (" + id_matkul + ", " + id_dosen + ");";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                }
                conn.Close();
                MessageBox.Show("Berhasil menambahkan data", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tampilkan_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int cari_id(int tipe)
        {
            int hasil = 0;
            int indek_awal, panjang;
            String data;

            indek_awal = 1;
            panjang = 1;
            if (tipe == 1) //matakuliah
            {
                data = comboBox1.Text;
            }
            else
            {
                data = comboBox3.Text;
            }
            
            int indek_tmp;
            for (int i = 0; i < data.Length; i++)
            {
                indek_tmp = data.IndexOf(')', i);
                if (indek_tmp != -1)
                {
                    //MessageBox.Show("data ditemukan pada indek "+indek);
                    panjang = indek_tmp - 1;
                    break;
                }
            }

            data = data.Substring(indek_awal, panjang);
            hasil = Convert.ToInt16(data);

            return hasil;
        }
    }
}
