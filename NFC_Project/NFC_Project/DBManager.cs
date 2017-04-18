using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Oracle.ManagedDataAccess.Client;
using System.Data.SqlClient;

namespace NFC_Project
{
    class DBManager
    {
        SqlConnection con;
        public void Connect()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=localhost/SQLEXPRESS;Database=master;Trusted_Connection=True;";

            con.Open();

            System.Windows.Forms.MessageBox.Show(con.State.ToString());

            con.Close();
        }
    }
}
