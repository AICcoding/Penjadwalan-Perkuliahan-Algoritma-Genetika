using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penjadwalan_Perkuliahan_Algoritma_Genetika
{
    class Kromosom
    {
        public int[,] gen;
        int[] dosenMK; //Biar tau dosennya siapa di MK itu.
        public int[,] tabelBentrok;

        public double fitness;
        public double probabilitasFitness;
        //public double kumulatifMin;
        public double kumulatifMax;

        public int jumlahGen;
        List<int> indexSkip;
        public int bentrokDK; //Dosen & Matkul (Dosen yang sama mengajar di matkul beda dalam suatu waktu yang sama)
        public int bentrokBR; //Ruangan yang digunakan sama di waktu yang sama.
        public int waktuWD; //Waktu dosen dilanggar

        public Kromosom(Random r1, int[] mataKuliah, int[] dosenMK, List<int> ruangan, List<int> waktu, int[,] tabelBentrok)
        {
            this.jumlahGen = mataKuliah.Length;
            this.dosenMK = new int[jumlahGen];
            this.tabelBentrok = tabelBentrok;

            gen = new int[jumlahGen, 3];


            for (int i = 0; i < jumlahGen; i++)
            {
                gen[i, 0] = mataKuliah[i];
                gen[i, 1] = ruangan[r1.Next(0, ruangan.Count)];
                gen[i, 2] = waktu[r1.Next(0, waktu.Count)];
                this.dosenMK[i] = dosenMK[i];
            }
        }

        public void hitungFitness()
        {
            hitungDosenBentrok();
            hitungBentrokRuangan();
            hitungWaktuDosen();

            fitness = 1F / (1F + ((float)bentrokDK + (float)bentrokBR + (float)waktuWD));
        }

        public void hitungDosenBentrok() //Dosen ngajar lebih dari 1 dalam suatu waktu tapi beda matkul
        {
            bentrokDK = 0;
            bool sudah;
            indexSkip = new List<int>();

            for (int i = 0; i < jumlahGen - 1; i++)
            {
                sudah = false;
                if (!indexSkip.Contains(i))
                {
                    for (int j = i + 1; j < jumlahGen; j++)
                    {
                        if (!indexSkip.Contains(j))
                        {
                            if ((dosenMK[i] == dosenMK[j]) && (gen[i, 2] == gen[j, 2]))
                            {
                                if (sudah == false)
                                {
                                    bentrokDK++;
                                }
                                sudah = true;

                                indexSkip.Add(j);
                                //MessageBox.Show("Skip dosen bentrok BD index ke-: " + j);
                            }
                        }
                    }
                }
            }
        }

        public void hitungBentrokRuangan() //ruangan bentrok dalam suatu waktu
        {
            bentrokBR = 0;
            bool sudah;
            indexSkip = new List<int>();

            for (int i = 0; i < jumlahGen - 1; i++)
            {
                sudah = false;
                if (!indexSkip.Contains(i))
                {
                    for (int j = i + 1; j < jumlahGen; j++)
                    {
                        if (!indexSkip.Contains(j))
                        {
                            if ((gen[i, 1] == gen[j, 1]) && (gen[i, 2] == gen[j, 2]))
                            {
                                if (sudah == false)
                                {
                                    bentrokBR++;
                                }
                                sudah = true;

                                indexSkip.Add(j);
                                //MessageBox.Show("Skip dosen bentrok BR Skip index ke-: " + j);
                            }
                        }
                    }
                }
            }
        }

        public void hitungWaktuDosen() //Pelanggaran waktu dosen
        {
            waktuWD = 0;

            for (int i = 0; i < jumlahGen; i++)
            {
                for(int j = 0; j < (tabelBentrok.Length/2); j++)
                {
                    if ((dosenMK[i] == tabelBentrok[j, 0]) && (gen[i, 2] == tabelBentrok[j, 1]))
                    {
                        //MessageBox.Show(dosenMK[i].ToString() + " == " + tabelBentrok[j, 0].ToString() + " ) && ( " + gen[i, 2].ToString() + " == " + tabelBentrok[j, 1].ToString());
                        //MessageBox.Show("INDEX MK = " + i);
                        waktuWD++;
                    }
                }
            }
        }
    }
}
