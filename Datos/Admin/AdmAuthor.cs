using System;
using System.Collections.Generic;
using System.Data;
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

        public static List<Author> Listar(string Ciudad)
        {
            string query = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors WHERE city=@city";

            SqlCommand command = new SqlCommand(query, AdminDB.ConectarBD());
            command.Parameters.Add("@city", System.Data.SqlDbType.VarChar, 20).Value = Ciudad;

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

        public static List<Author> Listar(string Ciudad, string Estado)
        {
            string query = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors WHERE city=@city and state=@state";

            SqlCommand command = new SqlCommand(query, AdminDB.ConectarBD());
            command.Parameters.Add("@city", System.Data.SqlDbType.VarChar, 20).Value = Ciudad;
            command.Parameters.Add("@state", System.Data.SqlDbType.Char, 2).Value = Estado;

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

        public static DataTable ListarDataTable(string Ciudad)
        {
            string query = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors WHERE city=@city";

            SqlDataAdapter adapter = new SqlDataAdapter(query, AdminDB.ConectarBD());

            adapter.SelectCommand.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = Ciudad;

            DataSet ds = new DataSet();

            adapter.Fill(ds, "Authors");

            return ds.Tables["Authors"];
        }

        public static DataTable ListarSoloCiudades()
        {
            string query = "SELECT distinct city FROM dbo.authors";

            SqlDataAdapter adapter = new SqlDataAdapter(query, AdminDB.ConectarBD());

            DataSet ds = new DataSet();

            adapter.Fill(ds, "Ciudad");

            return ds.Tables["Ciudad"];
        }
    }
}
