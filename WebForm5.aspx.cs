using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CleaningApplication
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
                string body = "<h1> Hello admin </h1> <br/>";
                body += "<br/>You have received a new message regarding 'Swaach Cleaning Services'. The details are as follows: <br/>";
                body += "<br/> Customer Name: " + txtname.Text + "<br/>";
                body += "<br/> Email Id: " + txtEmail.Text + "<br/>";
                body += "<br/> Phone No: " + txtPhoneNo.Text + "<br/>";
                body += "<br/> Message: " + txtMessage.Text + ".";


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
                    nc.Password = "Goyal0412Aa$h1";
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = nc;
                    smtp.Port = 587;
                    smtp.Send(message);

                    lblMessage.Text = "We have received your query and would be in contact shortly";
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Error " + ex.Message;
                }
            
        }
    }
}