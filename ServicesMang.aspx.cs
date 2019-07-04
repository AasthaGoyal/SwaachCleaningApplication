using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CleaningApplication
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        DataAccessLayer dao = new DataAccessLayer();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gdCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdCategories.SelectedRow;
            txtcategoryid.Text = row.Cells[1].Text;
            txtname.Text = row.Cells[2].Text;
            txtDescription.Text = row.Cells[4].Text;
            txtrank.Text = row.Cells[5].Text;
           string path = row.Cells[3].Text;
            imgPhoto.ImageUrl = path;
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}