using Datos.Models;
using Datos.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Admin
{
    public static class AdmPublisher
    {
        public static List<Publisher> Listar()
        {
            string query = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers";
            SqlCommand command = new SqlCommand(query, AdminDB.ConectarBD());

            SqlDataReader dataReader;

            dataReader = command.ExecuteReader();

            List<Publisher> publishers = new List<Publisher>();

            while (dataReader.Read())
            {
                publishers.Add(new Publisher()
                {
                    pub_id = (dataReader["pub_id"] == DBNull.Value)? string.Empty : (string)dataReader["pub_id"],
                    pub_name = (dataReader["pub_name"] == DBNull.Value)? string.Empty : (string)dataReader["pub_name"],
                    city = (dataReader["city"] == DBNull.Value)? string.Empty : (string)dataReader["city"],
                    state = (dataReader["state"] == DBNull.Value)? string.Empty : (string)dataReader["state"],
                    country = (dataReader["country"] == DBNull.Value)? string.Empty : (string)dataReader["country"],
                });
            }

            AdminDB.ConectarBD().Close();
            dataReader.Close();

            return publishers;
        }

        public static List<Publisher> Listar(string City)
        {
            string query = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers WHERE city=@city";
            SqlCommand command = new SqlCommand(query, AdminDB.ConectarBD());
            command.Parameters.Add("@city", System.Data.SqlDbType.VarChar, 20).Value = City;

            SqlDataReader dataReader;

            dataReader = command.ExecuteReader();

            List<Publisher> publishers = new List<Publisher>();

            while (dataReader.Read())
            {
                publishers.Add(new Publisher()
                {
                    pub_id = (dataReader["pub_id"] == DBNull.Value) ? string.Empty : (string)dataReader["pub_id"],
                    pub_name = (dataReader["pub_name"] == DBNull.Value) ? string.Empty : (string)dataReader["pub_name"],
                    city = (dataReader["city"] == DBNull.Value) ? string.Empty : (string)dataReader["city"],
                    state = (dataReader["state"] == DBNull.Value) ? string.Empty : (string)dataReader["state"],
                    country = (dataReader["country"] == DBNull.Value) ? string.Empty : (string)dataReader["country"],
                });
            }

            AdminDB.ConectarBD().Close();
            dataReader.Close();

            return publishers;
        }

        public static List<Publisher> Listar(string City, string State)
        {
            string query = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers WHERE city=@city";
            SqlCommand command = new SqlCommand(query, AdminDB.ConectarBD());
            command.Parameters.Add("@city", System.Data.SqlDbType.VarChar, 20).Value = City;
            command.Parameters.Add("@city", System.Data.SqlDbType.Char, 2).Value = State;

            SqlDataReader dataReader;

            dataReader = command.ExecuteReader();

            List<Publisher> publishers = new List<Publisher>();

            while (dataReader.Read())
            {
                publishers.Add(new Publisher()
                {
                    pub_id = (dataReader["pub_id"] == DBNull.Value) ? string.Empty : (string)dataReader["pub_id"],
                    pub_name = (dataReader["pub_name"] == DBNull.Value) ? string.Empty : (string)dataReader["pub_name"],
                    city = (dataReader["city"] == DBNull.Value) ? string.Empty : (string)dataReader["city"],
                    state = (dataReader["state"] == DBNull.Value) ? string.Empty : (string)dataReader["state"],
                    country = (dataReader["country"] == DBNull.Value) ? string.Empty : (string)dataReader["country"],
                });
            }

            AdminDB.ConectarBD().Close();
            dataReader.Close();

            return publishers;
        }

        public static List<Publisher> Listar(string City, string State, string Country)
        {
            string query = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers WHERE city=@city";
            SqlCommand command = new SqlCommand(query, AdminDB.ConectarBD());
            command.Parameters.Add("@city", System.Data.SqlDbType.VarChar, 20).Value = City;
            command.Parameters.Add("@city", System.Data.SqlDbType.Char, 2).Value = State;
            command.Parameters.Add("@city", System.Data.SqlDbType.VarChar, 30).Value = Country;

            SqlDataReader dataReader;

            dataReader = command.ExecuteReader();

            List<Publisher> publishers = new List<Publisher>();

            while (dataReader.Read())
            {
                publishers.Add(new Publisher()
                {
                    pub_id = (dataReader["pub_id"] == DBNull.Value) ? string.Empty : (string)dataReader["pub_id"],
                    pub_name = (dataReader["pub_name"] == DBNull.Value) ? string.Empty : (string)dataReader["pub_name"],
                    city = (dataReader["city"] == DBNull.Value) ? string.Empty : (string)dataReader["city"],
                    state = (dataReader["state"] == DBNull.Value) ? string.Empty : (string)dataReader["state"],
                    country = (dataReader["country"] == DBNull.Value) ? string.Empty : (string)dataReader["country"],
                });
            }

            AdminDB.ConectarBD().Close();
            dataReader.Close();

            return publishers;
        }

    }
}
