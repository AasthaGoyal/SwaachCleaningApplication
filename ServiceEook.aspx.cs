using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CleaningApplication
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> col1 = new List<string>();
            List<string> col2 = new List<string>();

            if(Session["column1"] != null && Session["column2"] != null)
            {
                col1.Add(Session["column1"].ToString());
                col2.Add(Session["column2"].ToString());
            }
            else
            {
                lblmessage.Text = "Session is null";
            }
           

          

        }
    }
}