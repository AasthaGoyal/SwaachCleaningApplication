using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CleaningApplication
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        DataAccessLayer dao = new DataAccessLayer();
        string connectionString = ConfigurationManager.ConnectionStrings["dbcleaningConnectionString"].ConnectionString;
        List<String> colnames = new List<String>();

        protected void Page_Load(object sender, EventArgs e)
        {
           
         
        }

        protected void dpcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            dpdetails.Items.Clear();
            string input = dpcategory.SelectedItem.Text;
            int id = dao.getCatid(input);

            if(id ==1)
            {
                dpdetails.Items.Add("Bedrooms");
                dpdetails.Items.Add("Bathrooms");
                dpdetails.Items.Add("Garage");
                dpdetails.Items.Add("Windows");
                dpdetails.Items.Add("Ceiling");
                
            }
            else if(id == 2)
            {
                dpdetails.Items.Add("Oven");
            }
            else if(id ==9)
            {
                dpdetails.Enabled = false;
            }
            else if(id == 3)
            {
                dpdetails.Items.Add("carpet");
            }
            else if(id == 4)
            {
                dpdetails.Items.Add("Blind");
            }
            else if(id ==5)
            {
                dpdetails.Items.Add("curtain");
            }
            else if (id ==6)
            {
                dpdetails.Items.Add("sofa");
            }
            else if(id ==13)
            {
                dpdetails.Items.Add("Rug");
            }
            else if(id ==7)
            {
                dpdetails.Items.Add("Vinyl");
            }
            else if(id == 8)
            {
                dpdetails.Items.Add("Mould");
            }
            else if(id == 12)
            {
                dpdetails.Enabled = false;
            }

            loadDetailsData();
        }

        public void loadExtraData()
        {
            string input = dpcategory.SelectedItem.Text;
            int id = dao.getCatid(input);

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from tbExtras where ", connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            gdExtras.DataSource = ds;
            gdExtras.DataBind();

        }
    

        protected void dpdetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                loadDetailsData();
            }
           
           

        }

        public void loadDetailsData()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            if (!string.IsNullOrEmpty(dpdetails.SelectedValue))
            {

                // var dbPath = Server.MapPath(@"\App_Data\Database1.mdf");
                //  var scon = "Data Source=aago001;Initial catalog=dbcleaning; Integrated Security=True";
                var cmd = "select * from tb" + dpdetails.SelectedValue;

                var dt = new DataTable();
                var da = new SqlDataAdapter(cmd, connection);
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            txtid.Text = row.Cells[1].Text;
            txtname.Text = row.Cells[2].Text;
            txtprice.Text = row.Cells[3].Text;
            

            foreach (DataControlFieldCell cell in row.Cells)
            {
                if (cell.ContainingField is BoundField)
                {
                    colnames.Add(((BoundField)cell.ContainingField).DataField);
                    
                }
                    
            }


            StringBuilder query = new StringBuilder();
            foreach (string item in colnames)
            {
                query.Append("," + item);
            }
            lblMessage.Text = query.ToString();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string[] getcolns = lblMessage.Text.Split(',');

             string query = "update tb" + dpdetails.SelectedValue + " set " + getcolns[2] + "='" + txtname.Text + "', " + getcolns[3] + "='" + txtprice.Text + "' where " + getcolns[1] + "= '" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.ExecuteNonQuery();
            lblMessage.Text = "The service was updated successfully";



        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string[] getcolns = lblMessage.Text.Split(',');

            string query = "delete from tb" + dpdetails.SelectedValue + " where " + getcolns[1] + "= '" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.ExecuteNonQuery();
            lblMessage.Text = "The service was deleted successfully";

        }
    }
}