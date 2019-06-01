﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace CleaningApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public SqlConnection con = null;
        String connectionString = null;
        SqlCommand cmd;
       
        SqlDataAdapter da;


        protected void Page_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["dbcleaningConnectionString"].ConnectionString;
            con = new SqlConnection(connectionString);

            if (!IsPostBack)
            {

                RepeterData();



            }
            

            con.Close();
        }

        protected void btnConfirm_OnClick(object sender, EventArgs e)
        {
            lblMessage.Text = "Its working";
        }

        public void RepeterData()
        {
            con.Open();

            cmd = new SqlCommand("Select * from tbcategory", con);
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            RepterDetails.DataSource = ds;
            RepterDetails.DataBind();



            con.Close();
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            string body = "<h1> Hello admin </h1> <br/>";
            body += "<br/>You have received a new message regarding 'Swaach Cleaning Services'. The details are as follows: <br/>";
            body += "<br/> Customer Name: " + txtname.Text + "<br/>";
            body += "<br/> Email Id: " + txtemailid.Text + "<br/>";
            body += "<br/> Phone No: " + txtPhone.Text + "<br/>";
            body += "<br/> Message: " + txtmessage.Text + ".";


            lblMessage.Text = "Code reaching";

            try
            {
                MailMessage message = new MailMessage();
                message.To.Add("aastha2150@gmail.com");
                message.From = new MailAddress("aastha2150@gmail.com");
                message.Subject = "A new message received!";
                message.Body = body;
                message.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential nc = new NetworkCredential();
                nc.UserName = "aastha2150@gmail.com";
                nc.Password = "Goyal0412aastha";
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = nc;
                smtp.Port = 587;
                smtp.Send(message);

                lblMessage.Text = "* We have received your query and would be in contact shortly";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "* Error! " + ex.Message;
            }
        }
    }
}