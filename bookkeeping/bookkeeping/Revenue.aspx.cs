using System;
using System.Collections.Generic;
using System.Linq;
using bookkeeping.App_Data;


namespace bookkeeping
{


    public partial class Revenue : System.Web.UI.Page
    {
        DataClassesDataContext _dc = new DataClassesDataContext();

        //protected void Page_Load(object sender, EventArgs e)
        //{

        //}

        protected void btnRevenueSubmit_Click(object sender, EventArgs e)
        {
            //Declare variables and save values from form
            string name = txtName.Text;
            string desc = txtDescription.Text;
            decimal amount = Convert.ToDecimal(txtAmount.Text);

            //Insert Transaction into the database
            TransactionInsert(name, desc, amount);
        }

        /// <summary>
        /// Inserts a Transaction (Revenue or Expense) into the database
        /// </summary>
        /// <param name="name">Name of the Transaction (Revenue or Expense)</param>
        /// <param name="description">Description of the Transaction (Revenue or Expense)</param>
        /// <param name="amount">Amount of the Transaction (Revenue or Expense)</param>
        public void TransactionInsert(string name, string description, decimal amount)
        {
            //Put together LINQ statement and INSERT into the database
            transaction rev = new transaction
            {
                transaction_name = name,
                transaction_description = description,
                transaction_amount = amount
            };

            _dc.transactions.InsertOnSubmit(rev);
            _dc.SubmitChanges();
        }
    }
}