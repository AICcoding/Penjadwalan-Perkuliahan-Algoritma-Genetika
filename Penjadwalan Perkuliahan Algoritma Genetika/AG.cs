using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penjadwalan_Perkuliahan_Algoritma_Genetika
{
    class AG
    {
        Random r1 = new Random();

        int jumlahKromosom;
        public Kromosom[] kromosom;

        Kromosom[] hasilSeleksi;
        double[] randomSeleksi;

        double[] randomCrossover;
        List<int> crossoverTerpilih;
        double probabilitasCrossover = 0.5;

        double[] randomMutasi;

        double totalFitness;

        public AG(int jumlahKromosom, int[] mataKuliah, int[] dosenMK, List<int> ruangan, List<int> waktu, int[,] tabelBentrok)
        {
            this.jumlahKromosom = jumlahKromosom;

            kromosom = new Kromosom[jumlahKromosom];
            hasilSeleksi = new Kromosom[jumlahKromosom];

            for (int i = 0; i < jumlahKromosom; i++)
            {
                kromosom[i] = new Kromosom(r1, mataKuliah, dosenMK, ruangan, waktu, tabelBentrok);
            }
        }

        public void seleksi()
        {
            totalFitness = 0;

            //cari total fitness semua kromosom
            for (int i = 0; i < jumlahKromosom; i++)
            {
                totalFitness += kromosom[i].fitness;
            }

            //cari probabilitas masing-masing fitness
            for (int i = 0; i < jumlahKromosom; i++)
            {
                kromosom[i].probabilitasFitness = kromosom[i].fitness / totalFitness;
            }

            //cari kumulatif masing-masing fitness
            for (int i = 0; i < jumlahKromosom; i++)
            {
                if (i != 0 && i != (jumlahKromosom - 1))
                {
                    kromosom[i].kumulatifMax = kromosom[i - 1].kumulatifMax + kromosom[i].probabilitasFitness;
                }
                else // i==0
                {
                    kromosom[i].kumulatifMax = kromosom[i].probabilitasFitness;
                }
            }

            Random r = new Random();
            randomSeleksi = new double[jumlahKromosom];

            for (int i = 0; i < jumlahKromosom; i++)
            {
                int terpilih = 0;
                randomSeleksi[i] = r.NextDouble();

                //cari di mana probabilitasnya yang cocok
                for (int j = 0; j < jumlahKromosom; j++)
                {
                    if (randomSeleksi[i] < kromosom[j].kumulatifMax)
                    {
                        terpilih = j;
                        break;
                    }
                }

                hasilSeleksi[i] = kromosom[terpilih];
            }
        }


        public void crossover()
        {
            Random r = new Random();
            randomCrossover = new double[jumlahKromosom];

            for (int i = 0; i < jumlahKromosom; i++)
            {
                randomCrossover[i] = r.NextDouble();

                if (randomCrossover[i] < probabilitasCrossover)
                {
                    crossoverTerpilih.Add(i);
                }
            }

            if (crossoverTerpilih.Count > 1)
            {
                Random r2 = new Random();
                int titik = r2.Next(0, kromosom[0].jumlahGen - 1);

                int[] temp = new int[3];

                for (int i = 0; i < crossoverTerpilih.Count - 1; i++)
                {
                    for (int j = i + 1; j < crossoverTerpilih.Count; j++)
                    {
                        for (int x = titik, t = 0; x < kromosom[0].jumlahGen; x++, t++)
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
                    }
                }
            }

        }

        public void mutasi()
        {

        }
    }
}
