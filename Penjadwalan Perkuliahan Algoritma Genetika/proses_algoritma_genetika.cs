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
        //System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["setting_parameter_algoritma_genetika"];
        MySqlConnection conn = conectionservice.getconection();
        int jumlahGen;
        public proses_algoritma_genetika()
        {
            InitializeComponent();

            tampilkan_jadwal();
        }

        private void tampilkan_jadwal()
        {
            try
            {
                /*conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM waktu, matkul, dosen, ruangan, jadwal_ag, matkul_dosen WHERE jadwal_ag.id_matkul_dosen=matkul_dosen.id AND jadwal_ag.id_ruangan=ruangan.id AND jadwal_ag.id_waktu=waktu.id AND matkul_dosen.id_matkul=matkul.id AND matkul_dosen.id_dosen=dosen.id ORDER BY waktu.hari ASC, waktu.jam ASC;";
                da.SelectCommand = command;
                DataSet ds = new DataSet();
                da.Fill(ds, "hasil");
                ds.Tables[0].Rows
                ds.Tables[0].Rows[0][1] = "TAI";

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "hasil";

                conn.Close();*/

                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM matkul_dosen;", conn))
                {
                    conn.Open();
                    jumlahGen = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                }

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();

                dataGridView1.Columns.Add("hari", "Hari");
                dataGridView1.Columns.Add("jam", "Jam");
                dataGridView1.Columns.Add("nama_dosen", "Nama Dosen");
                dataGridView1.Columns.Add("nama_dosen", "Nama Mata Kuliah");
                dataGridView1.Columns.Add("ruangan", "Ruangan");

                dataGridView1.Columns[0].Width = 70;
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[3].Width = 270;
                /*dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;*/

                for (int i = 0; i < jumlahGen; i++)
                {
                    dataGridView1.Rows.Add();
                }

                //dataGridView1.RowHeadersWidth = 60;

                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM waktu, matkul, dosen, ruangan, jadwal_ag, matkul_dosen WHERE jadwal_ag.id_matkul_dosen=matkul_dosen.id AND jadwal_ag.id_ruangan=ruangan.id AND jadwal_ag.id_waktu=waktu.id AND matkul_dosen.id_matkul=matkul.id AND matkul_dosen.id_dosen=dosen.id ORDER BY waktu.hari ASC, waktu.jam ASC;", conn))
                {
                    conn.Open();
                    int i = 0;
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        switch (dataReader.GetInt32(1))
                        {
                            case 1:
                                dataGridView1.Rows[i].Cells[0].Value = "Senin";
                                break;
                            case 2:
                                dataGridView1.Rows[i].Cells[0].Value = "Selasa";
                                break;
                            case 3:
                                dataGridView1.Rows[i].Cells[0].Value = "Rabu";
                                break;
                            case 4:
                                dataGridView1.Rows[i].Cells[0].Value = "Kamis";
                                break;
                            case 5:
                                dataGridView1.Rows[i].Cells[0].Value = "Jumat";
                                break;
                            default:
                                dataGridView1.Rows[i].Cells[0].Value = "Minggu";
                                break;
                        }
                        dataGridView1.Rows[i].Cells[1].Value = dataReader.GetString(2);
                        dataGridView1.Rows[i].Cells[2].Value = dataReader.GetString(4);
                        dataGridView1.Rows[i].Cells[3].Value = dataReader.GetString(8);
                        dataGridView1.Rows[i].Cells[4].Value = dataReader.GetString(10);

                        if(dataReader.GetInt32(1) % 2==0)
                        {
                            dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.FromArgb(150, 150, 150);
                            dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.FromArgb(150, 150, 150);
                            dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.FromArgb(150, 150, 150);
                            dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.FromArgb(150, 150, 150);
                            dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.FromArgb(150, 150, 150);
                        }
                        i++;
                    }
                    conn.Close();
                }


                /*dataGridView1.Columns[0].HeaderText = "ID waktu";
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

                dataGridView1.Columns.Add("Column17", "Hari");
                dataGridView1.Rows.Add();
                for (int i = 0; i < dataGridView1.RowCount-1; i++)
                {
                    switch((int)dataGridView1.Rows[i].Cells[9].Value)
                    {
                        case 1:
                            dataGridView1.Rows[i].Cells[17].Style.BackColor = Color.Green;
                            break;
                        case 2:
                            dataGridView1.Rows[i].Cells[17].Value = "Selasa";
                            break;
                        case 3:
                            dataGridView1.Rows[i].Cells[17].Value = "Rabu";
                            break;
                        case 4:
                            dataGridView1.Rows[i].Cells[17].Value = "Kamis";
                            break;
                        case 5:
                            dataGridView1.Rows[i].Cells[17].Value = "Jumat";
                            break;
                        default:
                            dataGridView1.Rows[i].Cells[17].Value = "Minggu";
                            break;
                    }
                }              */  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
