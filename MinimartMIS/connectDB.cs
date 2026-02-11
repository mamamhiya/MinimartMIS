using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace MinimartMIS
{
    internal class connectDB
    {
        public static SqlConnection ConnectMinimart()
        {
            string server = @".\SqlExpress"; 
            string db = "Minimart"; 
            string strCon = string.Format("Data Source={0};Initial Catalog={1};"+ "Integrated Security=True;Encrypt=False", server, db);
            
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            return conn;
        }
    }
}
