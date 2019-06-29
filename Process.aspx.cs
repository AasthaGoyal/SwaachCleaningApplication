using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CleaningApplication
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["dbcleaningConnectionString"].ConnectionString;
       

        protected void Page_Load(object sender, EventArgs e)
        {
            getProcess();
        }

        public void getProcess()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "select * from tbprocess";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["processid"]) == 1)
                    {
                        lblname1.Text = reader.GetString(1);
                        lblprocess1.Text = reader.GetString(2);
                    }
                    else if (Convert.ToInt32(reader["processid"]) == 2)
                    {
                        lblname2.Text = reader.GetString(1);
                        lblProcess2.Text = reader.GetString(2);
                    }
                    else if (Convert.ToInt32(reader["processid"]) == 3)
                    {
                        lblname3.Text = reader.GetString(1);
                        lblprocess3.Text = reader.GetString(2);
                    }
                    else
                    {
                        lblname4.Text = reader.GetString(1);
                        lblprocess4.Text = reader.GetString(2);
                    }
                }
            }
        }

    }
}