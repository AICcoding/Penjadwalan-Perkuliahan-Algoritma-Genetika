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
    public partial class proses_algoritma_genetika : Form
    {
        MySqlConnection conn = conectionservice.getconection();

        public proses_algoritma_genetika()
        {
            InitializeComponent();

            tampilkan_jadwal();
        }

        private void tampilkan_jadwal()
        {
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM waktu, matkul, dosen, ruangan, jadwal_ag, matkul_dosen WHERE jadwal_ag.id_matkul_dosen=matkul_dosen.id AND jadwal_ag.id_ruangan=ruangan.id AND jadwal_ag.id_waktu=waktu.id AND matkul_dosen.id_matkul=matkul.id AND matkul_dosen.id_dosen=dosen.id ORDER BY waktu.hari ASC, waktu.jam ASC;";
                da.SelectCommand = command;
                DataSet ds = new DataSet();
                da.Fill(ds, "hasil");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "hasil";

                conn.Close();


                dataGridView1.Columns[0].HeaderText = "ID waktu";
                dataGridView1.Columns[1].HeaderText = "Hari";
                dataGridView1.Columns[2].HeaderText = "Jam";

                dataGridView1.Columns[3].HeaderText = "ID matkul";
                dataGridView1.Columns[4].HeaderText = "Nama matkul";
                dataGridView1.Columns[5].HeaderText = "SKS";
                dataGridView1.Columns[6].HeaderText = "Semester";

                dataGridView1.Columns[7].HeaderText = "ID dosen";
                dataGridView1.Columns[8].HeaderText = "Nama dosen";

                dataGridView1.Columns[9].HeaderText = "ID ruangan";
                dataGridView1.Columns[10].HeaderText = "Nama ruangan";

                dataGridView1.Columns[11].HeaderText = "ID matkul dosen";
                dataGridView1.Columns[12].HeaderText = "ID ruangan";        
                dataGridView1.Columns[13].HeaderText = "ID waktu";

                dataGridView1.Columns[14].HeaderText = "ID jadwal ag";
                dataGridView1.Columns[15].HeaderText = "ID matkul";
                dataGridView1.Columns[16].HeaderText = "ID dosen";


                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = false;
                dataGridView1.Columns[14].Visible = false;
                dataGridView1.Columns[15].Visible = false;
                dataGridView1.Columns[16].Visible = false;

                /*dataGridView1.Columns.Add("Column17", "Hari");
                for (int i = 0; i < dataGridView1.RowCount-1; i++)
                {
                    switch((int)dataGridView1.Rows[i].Cells[9].Value)
                    {
                        case 1:
                            dataGridView1.Rows[i].Cells["Column17"].Value = "senini";
                            break;
                        case 2:
                            dataGridView1.Rows[i].Cells["Column17"].Value = "Selasa";
                            break;
                        case 3:
                            dataGridView1.Rows[i].Cells["Column17"].Value = "Rabu";
                            break;
                        case 4:
                            dataGridView1.Rows[i].Cells["Column17"].Value = "Kamis";
                            break;
                        case 5:
                            dataGridView1.Rows[i].Cells["Column17"].Value = "Jumat";
                            break;
                        default:
                            dataGridView1.Rows[i].Cells["Column17"].Value = "Minggu";
                            break;
                    }
                }    */                      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
