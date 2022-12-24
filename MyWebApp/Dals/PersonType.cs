using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace MyWebApp.Dals
{
    public sealed class PersonType
    {
        public static DataTable GetPersonTypes()
        {
            DataSet ds = new DataSet();

            string conns = ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(conns))
            {
                MySqlCommand cmd = new MySqlCommand("select * from persontype", conn);

                using (MySqlDataAdapter adp = new MySqlDataAdapter(cmd))
                {
                    adp.Fill(ds);
                }
            }
            return ds.Tables[0];
        }

    }
}