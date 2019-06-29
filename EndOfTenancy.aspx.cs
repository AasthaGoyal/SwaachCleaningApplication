using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CleaningApplication
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        DataAccessLayer dao = new DataAccessLayer();
     
        string connectionString = ConfigurationManager.ConnectionStrings["dbcleaningConnectionString"].ConnectionString;
       



        protected void Page_Load(object sender, EventArgs e)
        {
           
            getBedrooms();
            getBathrooms();
            getCeiling();
            getWindows();
            getGarage();
            getExtras();



        }

       
        public void getBedrooms()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            string query = "select noOfBedrooms, bprice from tbBedrooms";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    dpBedrooms.Items.Add(reader.GetInt32(0).ToString() + " Bedroom(s) - $ " + reader.GetDecimal(1).ToString());

                }
            }

        }

        public void getBathrooms()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            string query = "select noOfBathrooms, bathprice from tbBathrooms";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    dpBathrooms.Items.Add(reader.GetInt32(0).ToString() + " Bathroom(s) - $ " + reader.GetDecimal(1).ToString());

                }
            }

        }

        public void getGarage()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            string query = "select noOfGarage, gPrice from tbGarage";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    dpGarages.Items.Add(reader.GetInt32(0).ToString() + " Garage(s) - $ " + reader.GetDecimal(1).ToString());

                }
            }

        }

        public void getCeiling()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            string query = "select noBeds, cPrice from tbCeiling";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    dpCeiling.Items.Add(reader.GetInt32(0).ToString() + " Bedroom(s) - $ " + reader.GetDecimal(1).ToString());

                }
            }

        }

        public void getWindows()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            string query = "select side, noOfBedrooms, wPrice from tbWindows";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    cbWindows.Items.Add(reader.GetInt32(1).ToString() + " Bedrooms(s) side (" + reader.GetString(0) + ") - $ " + reader.GetDecimal(2).ToString());

                }
            }

        }





        protected void btnclick_Click(object sender, EventArgs e)
        {

            List<int> totalPrice = new List<int>();

            TableRow row = new TableRow();
            TableCell cell1 = new TableCell();
            string[] name = dpBedrooms.SelectedItem.Text.Split('-');
            cell1.Text = name[0];
            TableCell cell2 = new TableCell();
          
            totalPrice.Add(Convert.ToInt32(name[1].Substring(3)));
            cell2.Text = name[1];
            row.Cells.Add(cell1);
            row.Cells.Add(cell2);
            myTable.Rows.Add(row);

            TableRow row2 = new TableRow();
            string[] bath = dpBathrooms.SelectedItem.Text.Split('-');
            TableCell cell3 = new TableCell();
            cell3.Text = bath[0];
            TableCell cell4 = new TableCell();
            totalPrice.Add(Convert.ToInt32(bath[1].Substring(3)));
            cell4.Text = bath[1];
            row2.Cells.Add(cell3);
            row2.Cells.Add(cell4);
            myTable.Rows.Add(row2);

            if (cbExtraToilet.Checked)
            {
                TableRow roww = new TableRow();
                string[] extraToilet = cbExtraToilet.Text.Split('-');
                TableCell celll = new TableCell();
                celll.Text = extraToilet[0];
                TableCell celll2 = new TableCell();
                totalPrice.Add(Convert.ToInt32(extraToilet[1].Substring(3)));
                celll2.Text = extraToilet[1];
                roww.Cells.Add(celll);
                roww.Cells.Add(celll2);
                myTable.Rows.Add(roww);
            }

            TableRow row3 = new TableRow();
            string[] garage = dpGarages.SelectedItem.Text.Split('-');
            TableCell cell5 = new TableCell();
            cell5.Text = garage[0];
            TableCell cell6 = new TableCell();
            totalPrice.Add(Convert.ToInt32(garage[1].Substring(3)));
            cell6.Text = garage[1];
            row3.Cells.Add(cell5);
            row3.Cells.Add(cell6);
            myTable.Rows.Add(row3);


            List<ListItem> selected = new List<ListItem>();
            foreach (ListItem item in cbWindows.Items)
            {
                if (item.Selected)
                {
                    selected.Add(item);
                }
            }

            foreach (ListItem item in selected)
            {
                TableRow rw = new TableRow();
                string[] windows = item.ToString().Split('-');
                TableCell cell7 = new TableCell();
                cell7.Text = windows[0];
                TableCell cell8 = new TableCell();
                totalPrice.Add(Convert.ToInt32(windows[1].Substring(3)));
                cell8.Text = windows[1];

                rw.Cells.Add(cell7);
                rw.Cells.Add(cell8);
                myTable.Rows.Add(rw);
            }

            TableRow crow = new TableRow();
            string[] ceiling = dpCeiling.SelectedItem.Text.Split('-');
            TableCell ccell1 = new TableCell();
            ccell1.Text = ceiling[0];
            TableCell ccell2 = new TableCell();
            totalPrice.Add(Convert.ToInt32(ceiling[1].Substring(3)));
            ccell2.Text = ceiling[1];
            crow.Cells.Add(ccell1);
            crow.Cells.Add(ccell2);
            myTable.Rows.Add(crow);


            List<ListItem> extraSelected = new List<ListItem>();
            foreach (ListItem item in cbExtras.Items)
            {
                if (item.Selected)
                {
                    extraSelected.Add(item);
                }
            }

            foreach (ListItem item in extraSelected)
            {
                TableRow erow = new TableRow();
                string[] extras = item.ToString().Split('-');
                TableCell ecell1 = new TableCell();
                ecell1.Text = extras[0];
                TableCell ecell2 = new TableCell();
                totalPrice.Add(Convert.ToInt32(extras[1].Substring(3)));
                ecell2.Text = extras[1];

                erow.Cells.Add(ecell1);
                erow.Cells.Add(ecell2);
                myTable.Rows.Add(erow);
            }

           
            int subtotal=0;
            foreach(int item in totalPrice)
            {
                subtotal = subtotal + item;
            }
            lblTotal.Text = "$" + subtotal.ToString();
            
        }



        public void getExtras()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            string query = "select extraName, eprice from tbExtras where serviceid =6";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    cbExtras.Items.Add(reader.GetString(0) + " - $ " + reader.GetInt32(1).ToString());

                }
            }

        }

    }


}