using MySql.Data.MySqlClient;
using MyWebApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace MyWebApp.Dals
{
    public sealed class Person
    {

        public static DataTable GetPersons()
        {
            DataSet ds = new DataSet();

            string conns = ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(conns))
            {
                MySqlCommand cmd = new MySqlCommand("select * from person", conn);

                using (MySqlDataAdapter adp = new MySqlDataAdapter(cmd))
                {
                    adp.Fill(ds);
                }
            }
            return ds.Tables[0];
        }

        public static Object GetPersons(int id)
        {
            DataSet ds = new DataSet();

            string conns = ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(conns))
            {
               
                MySqlCommand cmd = new MySqlCommand("select * from person where id=?", conn);
                cmd.Parameters.Add(new MySqlParameter("id", id));

                using (MySqlDataAdapter adp = new MySqlDataAdapter(cmd))
                {
                    adp.Fill(ds);
                }

            }
            return ds.Tables[0];

        }

        public static int PostPersons(MPerson  person)
        {
            DataSet ds = new DataSet();

            string conns = ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(conns))
            {

                MySqlCommand cmd = new MySqlCommand("insert into person values(?,?,?,?);SELECT LAST_INSERT_ID();", conn);
                cmd.Parameters.Add(new MySqlParameter("id", person.Id));
                cmd.Parameters.Add(new MySqlParameter("firtname", person.FirstName));
                cmd.Parameters.Add(new MySqlParameter("lastname", person.LastName));
                cmd.Parameters.Add(new MySqlParameter("persontypeid", person.PersonTypeId));

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());   
            }
        }

        public static void PutPerson(int id, MPerson person)
        {

        }

        public static void DeletePerson(int id)
        {

        }
    }
}