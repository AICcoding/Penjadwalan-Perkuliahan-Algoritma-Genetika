using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Penjadwalan_Perkuliahan_Algoritma_Genetika
{
    public partial class setting_parameter_algoritma_genetika : Form
    {
        MySqlConnection conn = conectionservice.getconection();

        int jumlahKromosom = 5;
        int jumlahGen;
        int[] mataKuliah;
        int[] dosenMK;
        List<int> ruangan;
        List<int> waktu;
        
        int jumlahTabelBentrok;
        int[,] tabelBentrok;

        public setting_parameter_algoritma_genetika()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*proses_algoritma_genetika a = new proses_algoritma_genetika();
            DialogResult dr = a.ShowDialog();*/

            
            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM matkul_dosen;", conn))
            {
                conn.Open();
                jumlahGen = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }


            mataKuliah = new int[jumlahGen];
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM matkul_dosen;", conn))
            {
                conn.Open();
                int i = 0;
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while(dataReader.Read())
                {
                    mataKuliah[i] = dataReader.GetInt32(0);
                    i++;
                }
                conn.Close();
            }

            dosenMK = new int[jumlahGen];
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM matkul_dosen;", conn))
            {
                conn.Open();
                int i = 0;
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    dosenMK[i] = dataReader.GetInt32(2);
                    i++;
                }
                conn.Close();
            }

            ruangan = new List<int>();
            using (MySqlCommand cmd = new MySqlCommand("SELECT id FROM ruangan;", conn))
            {
                conn.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    ruangan.Add(dataReader.GetInt32(0));
                }
                conn.Close();
            }

            waktu = new List<int>();
            using (MySqlCommand cmd = new MySqlCommand("SELECT id FROM waktu;", conn))
            {
                conn.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    waktu.Add(dataReader.GetInt32(0));
                }
                conn.Close();
            }

            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM larangan;", conn))
            {
                conn.Open();
                jumlahTabelBentrok = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }

            tabelBentrok = new int[jumlahTabelBentrok, 2];
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM larangan;", conn))
            {
                conn.Open();
                int i = 0;
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tabelBentrok[i, 0] = dataReader.GetInt32(1);
                    tabelBentrok[i, 1] = dataReader.GetInt32(2);
                    i++;
                }
                conn.Close();
            }

            //Buat ag
            AG ag = new AG(jumlahKromosom, mataKuliah, dosenMK, ruangan, waktu, tabelBentrok);

            MessageBox.Show("Populasi Awal");
            StringBuilder sbx = new StringBuilder();
            for (int i = 0; i < ag.kromosom.Length; i++)
            {
                sbx.Append("KROMOSOM " + (i + 1) + ": ");
                for (int j = 0; j < ag.kromosom[0].jumlahGen; j++)
                {

                    sbx.Append(ag.kromosom[i].gen[j, 0] + ",");
                    sbx.Append(ag.kromosom[i].gen[j, 1] + ",");
                    sbx.Append(ag.kromosom[i].gen[j, 2] + "|");


                }
                sbx.Append("\n");
            }
            MessageBox.Show(sbx.ToString());

            ag.hitungFitness();
            ag.seleksi();
            ag.crossover();


            /*for (int i = 0; i < jumlahKromosom; i++)
            {
                MessageBox.Show("FITNESS K"+ (i+1) + ": " + ag.kromosom[i].fitness.ToString());
            }
            MessageBox.Show("TOTAL FITNESS di form lain : " + ag.totalFitness.ToString());*/

            //MESEGBOX UNTUK KROMOSOM 1 GEN NEEEEEEEEE
            /*MessageBox.Show("BENTROK RUANGAN: " + ag.kromosom[0].bentrokBR.ToString());
            MessageBox.Show("BENTROK DOSEN MK: " + ag.kromosom[0].bentrokDK.ToString());
            MessageBox.Show("BENTROK DOSEN LARANG: " + ag.kromosom[0].waktuWD.ToString());*/

            /*MessageBox.Show("Sesudah crossover");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ag.kromosom.Length; i++)
            {
                sb.Append("KROMOSOM " + (i + 1) + ": ");
                for (int j = 0; j < ag.kromosom[0].jumlahGen; j++)
                {

                    sb.Append(ag.kromosom[i].gen[j, 0] + ",");
                    sb.Append(ag.kromosom[i].gen[j, 1] + ",");
                    sb.Append(ag.kromosom[i].gen[j, 2] + "|");

                    
                }
                sb.Append("\n");
            }
            MessageBox.Show(sb.ToString());*/

            ag.mutasi();
            /*MessageBox.Show("Sesudah mutasi");
            StringBuilder sb2 = new StringBuilder();
            for (int i = 0; i < ag.kromosom.Length; i++)
            {
                sb2.Append("KROMOSOM " + (i + 1) + ": ");
                for (int j = 0; j < ag.kromosom[0].jumlahGen; j++)
                {

                    sb2.Append(ag.kromosom[i].gen[j, 0] + ",");
                    sb2.Append(ag.kromosom[i].gen[j, 1] + ",");
                    sb2.Append(ag.kromosom[i].gen[j, 2] + "|");


                }
                sb2.Append("\n");
            }
            MessageBox.Show(sb2.ToString());*/

            /*for(int i = 0; i < jumlahKromosom; i++)
            {
                MessageBox.Show(mataKuliah[i].ToString());
            }
            for (int i = 0; i < jumlahKromosom; i++)
            {
                MessageBox.Show(dosenMK[i].ToString());
            }

            MessageBox.Show("JUMLAH RU: " + jumlahRuangan.ToString());
            MessageBox.Show("JUMLAH WK: " + jumlahWaktu.ToString());*/
        }
    }
}
