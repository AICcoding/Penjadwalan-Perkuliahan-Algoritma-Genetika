using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Penjadwalan_Perkuliahan_Algoritma_Genetika
{
    class conectionservice
    {
        public static MySqlConnection getconection()
        {
            MySqlConnection conn = null;
            try
            {
                string connstr = "server=localhost; database=jadwal_kuliah; uid=root; password=root;";
                conn = new MySqlConnection(connstr);

            }
            catch (MySqlException sqlx)
            {
                throw new Exception(sqlx.Message.ToString());
            }
            return conn;
        }
    }
}
