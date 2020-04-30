using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace warehouse
{
    class Connection
    {
        static string serverName = "SAITO-PC\\SQLEXPRESS";
        static string tableName = "warehouse";
        static string userName = "mylogin";
        static string password = "mylogin";
        public static SqlConnection conn;

        public static bool OpenConnection()
        {
            try
            {
                conn = new SqlConnection("server=" + serverName +"; Database=" + tableName + "; uid=" + userName + "; pwd=" + password);
                conn.Open();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
