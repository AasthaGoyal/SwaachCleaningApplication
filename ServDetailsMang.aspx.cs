using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CleaningApplication
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        DataAccessLayer dao = new DataAccessLayer();
        string connectionString = ConfigurationManager.ConnectionStrings["dbcleaningConnectionString"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void dpcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string input = dpcategory.SelectedItem.Text;
            int id = dao.getCatid(input);

            if(id == 1)
            {
                dpdetails.Items.Add("Bedrooms");
                dpdetails.Items.Add("Bathrooms");
                dpdetails.Items.Add("Garage");
                dpdetails.Items.Add("Window");
                dpdetails.Items.Add("Ceiling");
                dpdetails.Items.Add("Extras");

            }
            else
            {
                dpdetails.Visible = false;
                if(id == 2)
                {
                    load2();
                }
                
            }
        }


        public void load2()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from tbOven", connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            gdInfo.DataSource = ds;
            gdInfo.DataBind();
        }
    }
}