using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web.SessionState;

namespace CleaningApplication
{
    public class DataAccessLayer
    {
        public SqlConnection connection = null;
        String connectionString = null;


        public void openConnection()
        {
            connectionString = ConfigurationManager.ConnectionStrings["dbcleaningConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public string getCatName(int id)
        {
            openConnection();

            string query = "select categoryName from tbcategory where categoryid='" + id + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            string name = cmd.ExecuteScalar().ToString();

            return name;
        }

        

    }
}