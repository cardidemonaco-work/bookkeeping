using System;
using System.Collections.Generic;
using System.Linq;
using bookkeeping.App_Data;

namespace bookkeeping
{
    public class Transaction
    {
        DataClassesDataContext _dc = new DataClassesDataContext();

        public Transaction()
        {
            //asdf
        }

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

        public void Update(int key, string name, string description, decimal amount)
        {
            transaction rev = new transaction
            {
                transaction_id = key,
                transaction_name = name,
                transaction_description = description,
                transaction_amount = amount
            };

            _dc.SubmitChanges(); //Will the UPDATE run? I don't think so... need to figure out how to update
           
        }

        public void Delete(int key)
        {
           
        }
    }
}