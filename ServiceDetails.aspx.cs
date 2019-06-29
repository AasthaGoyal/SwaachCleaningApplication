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
       
        int id ;
        string connectionString = ConfigurationManager.ConnectionStrings["dbcleaningConnectionString"].ConnectionString;
        SqlConnection connection;

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["categoryid"]);
            if(id == 1)
            {
               
            
              //  Response.Redirect("EndOfTenancy.aspx");
            }
            else if(id == 2)
            {
               ovenDetails();
            }
            else if(id == 3)
            {
                   
              Response.Redirect("Carpet.aspx");   
            }
            else if(id == 4)
            {
              blindCleaning();

            }
            else if(id == 5)
            {
                curtainCleaning();
            }
            else if(id == 6)
            {
                sofaCleaning();
            }
            else if(id == 7)
            {
                vinylCleaning();
            }
            else if(id == 8)
            {
                mouldCleaning();
            }
            else if(id == 13)
            {
                rugCleaning();
            }
            else
            {
                //remove the heading of customizing
            }
        }

       


        protected void btnclick_Click(object sender, EventArgs e)
        {
            List<int> totalPrice = new List<int>();

           

            TableRow row2 = new TableRow();
            string[] random = dpFilter.SelectedItem.Text.Split('-');
            TableCell cell3 = new TableCell();
            cell3.Text = random[0];
            TableCell cell4 = new TableCell();
            totalPrice.Add(Convert.ToInt32(random[1].Substring(2)));
            cell4.Text = random[1];
            row2.Cells.Add(cell3);
            row2.Cells.Add(cell4);
            myTable.Rows.Add(row2);

            int subtotal = 0;
            foreach (int item in totalPrice)
            {
                subtotal = subtotal + item;
            }
            lblTotal.Text = "$" + subtotal.ToString();

            List<ListItem> selected = new List<ListItem>();
            foreach (ListItem item in cbExtras.Items)
            {
                if (item.Selected)
                {
                    selected.Add(item);
                }
            }

            foreach (ListItem item in selected)
            {
                TableRow rw = new TableRow();
                string[] extras = item.ToString().Split('-');
                TableCell cell7 = new TableCell();
                cell7.Text = extras[0];
                TableCell cell8 = new TableCell();
                totalPrice.Add(Convert.ToInt32(extras[1].Substring(3)));
                cell8.Text = extras[1];

                rw.Cells.Add(cell7);
                rw.Cells.Add(cell8);
                myTable.Rows.Add(rw);
            }

            int subsubtotal = 0;
            foreach (int item in totalPrice)
            {
                subsubtotal = subsubtotal + item;
            }
            lblTotal.Text = "$" + subsubtotal.ToString();

        }

        public void ovenDetails()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query2 = "select ovenName, oPrice from tbOven";
            string name="";
            decimal price=0;
            SqlCommand cmd = new SqlCommand(query2, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            dpFilter.Visible = true;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    name = reader.GetString(0);
                    price = reader.GetDecimal(1);

                    dpFilter.Items.Add(name + "- $" + price.ToString());
                }
            }

           

        }

      public void blindCleaning()
      {

            connection = new SqlConnection(connectionString);
            connection.Open();
            string query2 = "select bname, bprice from tbBlind";
            string name = "";
            decimal price = 0;
            SqlCommand cmd = new SqlCommand(query2, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            dpFilter.Visible = true;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    name = reader.GetString(0);
                    price = reader.GetDecimal(1);

                    dpFilter.Items.Add(name + "- $" + price.ToString());
                }
            }
            reader.Close();

            string query3 = "select extraName, eprice from tbExtras where serviceid =8";
            SqlCommand cmd3 = new SqlCommand(query3, connection);

            SqlDataReader reader2 = cmd3.ExecuteReader();

            if(reader2.HasRows)
            {
                while(reader2.Read())
                {
                    cbExtras.Items.Add(reader2.GetString(0) + "- $ " + reader2.GetInt32(1));
                }
            }
            reader2.Close();
      }

      public void curtainCleaning()
      {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query2 = "select cname, cprice from tbcurtain";
            string name = "";
            decimal price = 0;
            SqlCommand cmd = new SqlCommand(query2, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            dpFilter.Visible = true;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    name = reader.GetString(0);
                    price = reader.GetDecimal(1);

                    dpFilter.Items.Add(name + "- $" + price.ToString());
                }
            }
            reader.Close();

            string query3 = "select extraName, eprice from tbExtras where serviceid =9";
            SqlCommand cmd3 = new SqlCommand(query3, connection);

            SqlDataReader reader2 = cmd3.ExecuteReader();

            if (reader2.HasRows)
            {
                while (reader2.Read())
                {
                    cbExtras.Items.Add(reader2.GetString(0) + "- $ " + reader2.GetInt32(1));
                }
            }
            reader2.Close();
        }

        public void sofaCleaning()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query2 = "select sname, sprice from tbsofa";
            string name = "";
            decimal price = 0;
            SqlCommand cmd = new SqlCommand(query2, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            dpFilter.Visible = true;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    name = reader.GetString(0);
                    price = reader.GetDecimal(1);

                    dpFilter.Items.Add(name + "- $" + price.ToString());
                }
            }
            reader.Close();

            string query3 = "select extraName, eprice from tbExtras where serviceid =10";
            SqlCommand cmd3 = new SqlCommand(query3, connection);

            SqlDataReader reader2 = cmd3.ExecuteReader();

            if (reader2.HasRows)
            {
                while (reader2.Read())
                {
                    cbExtras.Items.Add(reader2.GetString(0) + "- $ " + reader2.GetInt32(1));
                }
            }
            reader2.Close();
        }

        public void vinylCleaning()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query2 = "select vname, vprice from tbvinyl";
            string name = "";
            decimal price = 0;
            SqlCommand cmd = new SqlCommand(query2, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            dpFilter.Visible = true;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    name = reader.GetString(0);
                    price = reader.GetDecimal(1);

                    dpFilter.Items.Add(name + "- $" + price.ToString());
                }
            }
            reader.Close();

            string query3 = "select extraName, eprice from tbExtras where serviceid =11";
            SqlCommand cmd3 = new SqlCommand(query3, connection);

            SqlDataReader reader2 = cmd3.ExecuteReader();

            if (reader2.HasRows)
            {
                while (reader2.Read())
                {
                    cbExtras.Items.Add(reader2.GetString(0) + "- $ " + reader2.GetInt32(1));
                }
            }
            reader2.Close();
        }

        public void mouldCleaning()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query2 = "select mname, mprice from tbmould";
            string name = "";
            decimal price = 0;
            SqlCommand cmd = new SqlCommand(query2, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            dpFilter.Visible = true;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    name = reader.GetString(0);
                    price = reader.GetDecimal(1);

                    dpFilter.Items.Add(name + "- $" + price.ToString());
                }
            }
            reader.Close();

            string query3 = "select extraName, eprice from tbExtras where serviceid =12";
            SqlCommand cmd3 = new SqlCommand(query3, connection);

            SqlDataReader reader2 = cmd3.ExecuteReader();

            if (reader2.HasRows)
            {
                while (reader2.Read())
                {
                    cbExtras.Items.Add(reader2.GetString(0) + "- $ " + reader2.GetInt32(1));
                }
            }
            reader2.Close();
        }

        public void rugCleaning()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query2 = "select rname, rprice from tbrug";
            string name = "";
            decimal price = 0;
            SqlCommand cmd = new SqlCommand(query2, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            dpFilter.Visible = true;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    name = reader.GetString(0);
                    price = reader.GetDecimal(1);

                    dpFilter.Items.Add(name + "- $" + price.ToString());
                }
            }
            reader.Close();

            string query3 = "select extraName, eprice from tbExtras where serviceid =13";
            SqlCommand cmd3 = new SqlCommand(query3, connection);

            SqlDataReader reader2 = cmd3.ExecuteReader();

            if (reader2.HasRows)
            {
                while (reader2.Read())
                {
                    cbExtras.Items.Add(reader2.GetString(0) + "- $ " + reader2.GetInt32(1));
                }
            }
            reader2.Close();
        }
    }
}