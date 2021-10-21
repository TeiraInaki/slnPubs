using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos.Models;
using Datos.Server;

namespace Datos.Admin
{
    public static class AdmAuthor
    {
        public static List<Author> Listar()
        {
            string query = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors";
            SqlCommand command = new SqlCommand(query, AdminDB.ConectarBD());

            SqlDataReader dataReader;

            dataReader = command.ExecuteReader();

            List<Author> authors = new List<Author>();

            while (dataReader.Read())
            {
                authors.Add(new Author()
                {
                    au_id = (string)dataReader["au_id"],
                    au_lname = (string)dataReader["au_lname"],
                    au_fname = (string)dataReader["au_fname"],
                    phone = (string)dataReader["phone"],
                    address = (string)dataReader["address"],
                    city = (string)dataReader["city"],
                    state = (string)dataReader["state"],
                    zip = (string)dataReader["zip"],
                    contract = (bool)dataReader["contract"],
                });
            }

            AdminDB.ConectarBD().Close();
            dataReader.Close();

            return authors;

        }
    }
}
