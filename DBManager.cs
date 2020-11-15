using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Lastproject
{
    class DBManager
    {
        private static DBManager instance_ = new DBManager();

        public static DBManager GetInstance()
        {
            return instance_;
        }

        private String Connection_stirng = "Server=49.50.174.201;Database=tnp;Uid=tnp;Pwd=tnp1234;Charset=utf8";


        private DBManager()
        {

        }
        public List<string> SelectTaskList(string query)
        {
            List<string> temp = new List<string>();
            using (MySqlConnection conn = new MySqlConnection(Connection_stirng))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    temp.Add(rdr["id"] + "");
                    temp.Add(rdr["maincategory"] + "");
                    temp.Add(rdr["middlecategory"] + "");
                    temp.Add(rdr["subcategory"] + "");

                }

                rdr.Close();
            }
            return temp;
        }


        public void SendQuery(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(Connection_stirng))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public void showdataGridView(string query, DataGridView dataGridView)
        {
            using (MySqlConnection conn = new MySqlConnection(Connection_stirng))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(rdr);

                dataGridView.DataSource = dt;
                rdr.Close();

            }
        }
    }
}
