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
    public partial class WebForm3 : System.Web.UI.Page
    {
        DataAccessLayer dao = new DataAccessLayer();
        string name;
        string connectionString = ConfigurationManager.ConnectionStrings["dbcleaningConnectionString"].ConnectionString;
          

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["categoryid"]);
            name = dao.getCatName(id);
            lblname.Text = name;
            getBedrooms();
        }

        public void getBedrooms()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

        
            string query = "select noOfBedrooms, bprice from tbBedrooms";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

           if(reader.HasRows)
            {
                while(reader.Read())
                {
                    dpBedrooms.Items.Add(reader.GetInt32(0).ToString() + "-" + reader.GetDecimal(1).ToString());

                }
            }
           
        }


    }

    
}