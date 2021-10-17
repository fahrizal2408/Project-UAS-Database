using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Koneksi
    {
        private MySqlConnection konDB;
        #region properties
        public MySqlConnection KonDB { get => konDB; private set => konDB = value; }
        #endregion

        #region methods
        public void Connect()
        {
            if (KonDB.State == System.Data.ConnectionState.Open)
            {
                KonDB.Close();
            }
            KonDB.Open();
        }
        #endregion

        #region
        public Koneksi(string _server, string _database, string _username, string _password)
        {
            string strCon = "server=" + _server + ";database=" + _database + ";uid=" + _username + ";password=" + _password + ";SSL Mode=None"; //buat connectionstring
            KonDB = new MySqlConnection(); //inisialisasi koneksi
            KonDB.ConnectionString = strCon; //set connection string dgn strCon
            Connect(); //panggil method connect
        }
        #endregion
        //kontorukontorukontoru
    }
}
