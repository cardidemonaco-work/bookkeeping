using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bookkeeping
{
    public partial class Revenue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRevenueSubmit_Click(object sender, EventArgs e)
        {
            //Declare varibles and save values from form
            string name = txtName.Text;
            string desc = txtDescription.Text;

            //string s2 = string.Format("{0:#,0.#}", float.Parse(s));
            //https://social.msdn.microsoft.com/Forums/vstudio/en-US/c9adb495-2077-4084-b779-380b97f8c60f/convert-string-value-to-currency-format?forum=csharpgeneral
            string amount = txtAmount.Text;
            //amount = string.Format("{0:#,0.#}", float.Parse(amount));


            bool lowlevel = cbLowLevel.Checked;
            App_Data.DataClassesDataContext dc = new App_Data.DataClassesDataContext();
            

            //Put together LINQ statement and insert into the database
            App_Data.transaction rev = new App_Data.transaction
            {
                transaction_name = name,
                transaction_description = desc,
                transaction_amount = 10.33M, //CURRENTLY STATIC
                transaction_low_level = 1 //1=true CURRENTLY STATIC
            };

            dc.transactions.InsertOnSubmit(rev);
            dc.SubmitChanges();

        }
    }
}