using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace pdd
{
    public class dataconnection
    {
        public SqlConnection connect()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Plant detection\pdd\leafdd.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            return con;
        }

        public String genfilename()
        {
            String dt = System.DateTime.Now.Ticks.ToString();
            return dt;
        }


        public DateTime getdatetime()
        {
            DateTime dt = System.DateTime.Now;
            return dt;
        }


    }
}