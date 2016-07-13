using System;
using System.Collections.Generic;
using System.Linq;

namespace bookkeeping.Common
{
    public class Database
    {
        DataClassesDataContext _dc = new DataClassesDataContext();

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
            _dc.transactions.SubmitChanges();
        }

    }
}