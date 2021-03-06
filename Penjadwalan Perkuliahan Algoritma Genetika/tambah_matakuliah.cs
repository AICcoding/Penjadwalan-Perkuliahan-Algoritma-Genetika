﻿using MySql.Data.MySqlClient;
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
    public partial class tambah_matakuliah : Form
    {
        MySqlConnection conn = conectionservice.getconection();
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["matakuliah"];


        public tambah_matakuliah()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nama, sks, semester;
                nama = textBox2.Text;
                sks = numericUpDown1.Value.ToString();
                semester = numericUpDown2.Value.ToString();

                nama = nama.Trim();
                if (nama == "")
                {
                    MessageBox.Show("Form masukan belum diisi !", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string SQL = "INSERT INTO matkul (nama, sks, semester) VALUES ('" + nama + "', '" + sks + "', '" + semester + "');";
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(SQL, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                    }
                    conn.Close();
                    MessageBox.Show("Berhasil menambahkan data", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((matakuliah)f).tampilkan_data();
                }           
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
    }
}
