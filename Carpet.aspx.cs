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
    public partial class WebForm9 : System.Web.UI.Page
    {
        DataAccessLayer dao = new DataAccessLayer();

        string connectionString = ConfigurationManager.ConnectionStrings["dbcleaningConnectionString"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                loadData();
                loadExtra();
            }
           

        }

        public void loadData()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string name;
            decimal price;
            string query = "select top 2 name,price from tbcarpet";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    name = reader.GetString(0);
                    price = reader.GetDecimal(1);
                    dpCarpet.Items.Add(name + " - (per sq met.)$" + price.ToString());
                }
            }


        }

        public void loadExtra()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string name;
            decimal price;
            string query = "select extraName,eprice from tbextras where serviceid =7";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    name = reader.GetString(0);
                    price = reader.GetDecimal(1);
                    cbExtra.Text = name + "- $" + price;
                }
            }


        }

        protected void txtarea_TextChanged(object sender, EventArgs e)
        {
          
           
            
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            List<int> totalPrice = new List<int>();

            int area = Convert.ToInt32(txtarea.Text);


            string[] carpet = dpCarpet.SelectedItem.Text.Split('$');
            // int price = Convert.ToInt32(garage[1].Substring(3));
            int price = Convert.ToInt32(carpet[1]);
            int catPrice = area * price;
            TableRow row = new TableRow();
            TableCell cell1 = new TableCell();

            cell1.Text = dpCarpet.SelectedItem.Text;
            TableCell cell2 = new TableCell();

            totalPrice.Add(catPrice);
            cell2.Text = "$ " + catPrice.ToString();
            row.Cells.Add(cell1);
            row.Cells.Add(cell2);
            myTable.Rows.Add(row);


            if (cbExtra.Checked)
            {
                string[] extra = cbExtra.Text.Split('-');
                totalPrice.Add(Convert.ToInt32(extra[1].Substring(3)));
               
                TableRow rowq = new TableRow();
                TableCell cell1q = new TableCell();
                
                cell1q.Text = extra[0];
                TableCell cell2q = new TableCell();

                totalPrice.Add(Convert.ToInt32(extra[1].Substring(3)));
                cell2q.Text = extra[1];
                rowq.Cells.Add(cell1q);
                rowq.Cells.Add(cell2q);
                myTable.Rows.Add(rowq);

            }

            int subtotal = 0;
            foreach (int item in totalPrice)
            {
                subtotal = subtotal + item;
            }
            lblTotal.Text = "$" + subtotal.ToString();
        }
    }
}