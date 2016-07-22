using System;
using System.Collections.Generic;
using System.Linq;
using bookkeeping;

namespace bookkeeping
{
    public partial class Revenue : System.Web.UI.Page
    {
        //DataClassesDataContext _dc = new DataClassesDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            string test;
            test = "test";
            test = "new test";
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