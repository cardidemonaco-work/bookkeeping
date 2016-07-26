using System;
using System.Collections.Generic;
using System.Linq;
using bookkeeping.App_Data;
using bookkeeping.Common;

namespace bookkeeping.Common
{
    public class Party
    {
        DataClassesDataContext _dc = new DataClassesDataContext();

        public void Insert(string name)
        {
            //Put together LINQ statement and INSERT into the database
            party p = new party
            {
                party_name = name,
            };

            _dc.parties.InsertOnSubmit(p);
            _dc.SubmitChanges();
        }

        public void Insert(string name, string description)
        {


        }

        public IQueryable<bookkeeping.App_Data.party> GetAllParties()
        {

            IQueryable<bookkeeping.App_Data.party> allParties = from p in _dc.parties
                                                                orderby p.party_name
                                                                select p;


            return allParties;
        }
    }
}