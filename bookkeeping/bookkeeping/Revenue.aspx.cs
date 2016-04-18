using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bookkeeping
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRevenueSubmit_Click(object sender, EventArgs e)
        {
            //Declare varibles and save values from form
            string name = txtName.Text;
            string desc = txtDescription.Text;
            string amount = txtAmount.Text;
            bool lowlevel = cbLowLevel.Checked;

            //Insert the data into the database





        }
    }
}