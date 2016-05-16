using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penjadwalan_Perkuliahan_Algoritma_Genetika
{
    class AG
    {
        Random r1 = new Random();

        public int jumlahKromosom;
        public Kromosom[] kromosom;

        Kromosom[] hasilSeleksi;
        double[] randomSeleksi;

        double[] randomCrossover;
        List<int> crossoverTerpilih; //kromosom yang akan dicrossover
        double probabilitasCrossover = 0.5;

        double[] randomMutasi;
        List<int> waktu;
        double probabilitasMutasi = 0.1;

        public double totalFitness;

        public AG(int jumlahKromosom, int[] mataKuliah, int[] dosenMK, List<int> ruangan, List<int> waktu, int[,] tabelBentrok)
        {
            this.jumlahKromosom = jumlahKromosom;
            this.waktu = waktu;

            kromosom = new Kromosom[jumlahKromosom];
            hasilSeleksi = new Kromosom[jumlahKromosom];

            for (int i = 0; i < jumlahKromosom; i++)
            {
                kromosom[i] = new Kromosom(r1, mataKuliah, dosenMK, ruangan, waktu, tabelBentrok);
            }
        }

        public void hitungFitness()
        {
            for (int i = 0; i < jumlahKromosom; i++)
            {
                kromosom[i].hitungFitness();
            }
        }

        public void seleksi()
        {
            totalFitness = 0F;
            
            //cari total fitness semua kromosom
            for (int i = 0; i < jumlahKromosom; i++)
            {
                totalFitness += (double)kromosom[i].fitness;
                //MessageBox.Show("Fitnes : "+ kromosom[i].fitness + "\nTOTAL FITNESS: " + totalFitness.ToString());
            }
            
            //cari probabilitas masing-masing fitness
            for (int i = 0; i < jumlahKromosom; i++)
            {
                kromosom[i].probabilitasFitness = kromosom[i].fitness / totalFitness;
                //MessageBox.Show("kromosom "+(i+1)+" -> "+ kromosom[i].fitness + "/"+ totalFitness+" = "+ kromosom[i].probabilitasFitness);
            }

            //cari kumulatif masing-masing fitness
            for (int i = 0; i < jumlahKromosom; i++)
            {
                if (i != 0)
                {
                    kromosom[i].kumulatifMax = kromosom[i - 1].kumulatifMax + kromosom[i].probabilitasFitness;
                }
                else // i==0
                {
                    kromosom[i].kumulatifMax = kromosom[i].probabilitasFitness;
                }
                //MessageBox.Show("kromosom "+(i+1)+" x-"+ kromosom[i].kumulatifMax);

            }


            Random r = new Random();
            randomSeleksi = new double[jumlahKromosom];
            hasilSeleksi = (Kromosom[])kromosom.Clone();

            for (int i = 0; i < jumlahKromosom; i++)
            {
                int terpilih = 0;
                randomSeleksi[i] = r.NextDouble();
                //MessageBox.Show("bilanga random " + randomSeleksi[i]);

                //cari di mana probabilitasnya yang cocok
                for (int j = 0; j < jumlahKromosom; j++)
                {
                    if (randomSeleksi[i] < kromosom[j].kumulatifMax)
                    {
                        terpilih = j;
                        //MessageBox.Show("ternyata masuk ke kromosom " + (j + 1));
                        break;
                    }
                }

                hasilSeleksi[i].gen = (int[,])kromosom[terpilih].gen.Clone();
            }

            kromosom = hasilSeleksi;
        }


        public void crossover()
        {
            Random r = new Random();
            randomCrossover = new double[jumlahKromosom];
            crossoverTerpilih = new List<int>();

            for (int i = 0; i < jumlahKromosom; i++)
            {
                randomCrossover[i] = r.NextDouble();

                if (randomCrossover[i] <= probabilitasCrossover)
                {
                    crossoverTerpilih.Add(i);
                    //MessageBox.Show("Kromosom ke " + (i + 1));
                }
            }

            if (crossoverTerpilih.Count >= 2)
            {
                Random r2 = new Random();
                int titik = r2.Next(0, kromosom[0].jumlahGen - 1);

                int[] temp = new int[3];

                //MessageBox.Show("titik potong berada pada angka " + titik + " brow");
                

                for (int i = 0; i < crossoverTerpilih.Count - 1; i++)
                {
                    for (int j = i + 1; j < crossoverTerpilih.Count; j++)
                    {
                        MessageBox.Show("Kromosom " + (i + 1) + " >< Kromosom " + (j + 1));
                        StringBuilder sbelum1 = new StringBuilder();
                        StringBuilder sbelum2 = new StringBuilder();
                        StringBuilder sesudah1 = new StringBuilder();
                        StringBuilder sesudah2 = new StringBuilder();


                        for (int jj = 0; jj < 4; jj++)
                        {
                            sbelum1.Append(kromosom[crossoverTerpilih[i]].gen[jj, 0] + " ");
                            sbelum1.Append(kromosom[crossoverTerpilih[i]].gen[jj, 1] + " ");
                            sbelum1.Append(kromosom[crossoverTerpilih[i]].gen[jj, 2] + " | ");

                            sbelum2.Append(kromosom[crossoverTerpilih[j]].gen[jj, 0] + " ");
                            sbelum2.Append(kromosom[crossoverTerpilih[j]].gen[jj, 1] + " ");
                            sbelum2.Append(kromosom[crossoverTerpilih[j]].gen[jj, 2] + " | ");
                        }

                        for (int x = titik; x < kromosom[0].jumlahGen; x++)
                        {
                            temp[0] = kromosom[crossoverTerpilih[i]].gen[x, 0];
                            temp[1] = kromosom[crossoverTerpilih[i]].gen[x, 1];
                            temp[2] = kromosom[crossoverTerpilih[i]].gen[x, 2];

                            kromosom[crossoverTerpilih[i]].gen[x, 0] = kromosom[crossoverTerpilih[j]].gen[x, 0];
                            kromosom[crossoverTerpilih[i]].gen[x, 1] = kromosom[crossoverTerpilih[j]].gen[x, 1];
                            kromosom[crossoverTerpilih[i]].gen[x, 2] = kromosom[crossoverTerpilih[j]].gen[x, 2];

                            kromosom[crossoverTerpilih[j]].gen[x, 0] = temp[0];
                            kromosom[crossoverTerpilih[j]].gen[x, 1] = temp[1];
                            kromosom[crossoverTerpilih[j]].gen[x, 2] = temp[2];
                        }

                        for (int jj = 0; jj < 4; jj++)
                        {
                            sesudah1.Append(kromosom[crossoverTerpilih[i]].gen[jj, 0] + " ");
                            sesudah1.Append(kromosom[crossoverTerpilih[i]].gen[jj, 1] + " ");
                            sesudah1.Append(kromosom[crossoverTerpilih[i]].gen[jj, 2] + " | ");

                            sesudah2.Append(kromosom[crossoverTerpilih[j]].gen[jj, 0] + " ");
                            sesudah2.Append(kromosom[crossoverTerpilih[j]].gen[jj, 1] + " ");
                            sesudah2.Append(kromosom[crossoverTerpilih[j]].gen[jj, 2] + " | ");
                        }

                        //MessageBox.Show("Sebelum \nKromosom " + (i + 1) + " : " + sbelum1 + "\nKromosom " + (j + 1) + " : " + sbelum2+"\n\nSesudah \nKromosom " + (i + 1) + " : " + sesudah1 + "\nKromosom " + (j + 1) + " : " + sesudah2 + "\n\n");
                    }
                }        
            }
            else
            {
                MessageBox.Show("krossover terpilih kurang dari 2 boss");
            }

        }

        public void mutasi()
        {
            Random r = new Random();
            randomMutasi = new double[jumlahKromosom * kromosom[0].jumlahGen];

            //int totalGenMutasi = (int)Math.Round(jumlahKromosom * kromosom[0].jumlahGen * probabilitasMutasi);
            for (int i = 0; i < (jumlahKromosom * kromosom[0].jumlahGen); i++)
            {
                randomMutasi[i] = r.NextDouble();

                if(randomMutasi[i] < probabilitasMutasi)
                {
                    int baris, kolom; //posisi mutasi
                    baris = (int)Math.Floor((double)i / (double)kromosom[0].jumlahGen);
                    kolom = i % kromosom[0].jumlahGen;

                    int index = waktu.IndexOf(kromosom[baris].gen[kolom, 2]);
                    if (index == (waktu.Count - 1)) //jika terakhir
                    {
                        index = 0;
                    }
                    kromosom[baris].gen[kolom, 2] = waktu[index + 1];
                }
            }

        }
    }
}
