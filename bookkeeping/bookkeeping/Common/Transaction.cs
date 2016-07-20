using System;
using System.Collections.Generic;
using System.Linq;
using bookkeeping.App_Data;

namespace bookkeeping
{
    public class Transaction
    {
        public Transaction()
        {
            //asdf
        }

        DataClassesDataContext _dc = new DataClassesDataContext();

        /// <summary>
        /// Inserts a Transaction (Revenue or Expense) into the database
        /// </summary>
        /// <param name="name">Name of the Transaction (Revenue or Expense)</param>
        /// <param name="description">Description of the Transaction (Revenue or Expense)</param>
        /// <param name="amount">Amount of the Transaction (Revenue or Expense)</param>
        public void Insert(string name, string description, decimal amount)
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