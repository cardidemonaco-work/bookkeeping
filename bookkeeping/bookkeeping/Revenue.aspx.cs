using System;
using System.Collections.Generic;
using System.Linq;
using bookkeeping.Common;

namespace bookkeeping
{
    public partial class Revenue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Party p = new Party();
                ddlRevenueParty.DataSource = p.GetAllParties();
                ddlRevenueParty.DataTextField = "party_name";
                ddlRevenueParty.DataValueField = "party_id";
                ddlRevenueParty.DataBind();
                ddlRevenueParty.Items.Insert(0, "-- Select a Party --");
            }
        }

        protected void btnRevenueSubmit_Click(object sender, EventArgs e)
        {
            //Declare variables and save values from form
            string name = txtName.Text;
            string desc = txtDescription.Text;
            decimal amount = Convert.ToDecimal(txtAmount.Text);

            //Insert Transaction into the database
            Transaction t = new Transaction();
            t.Insert(name, desc, amount);          
        }
    }
}