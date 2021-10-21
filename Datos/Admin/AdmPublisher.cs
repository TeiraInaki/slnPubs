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
        
    }
}
