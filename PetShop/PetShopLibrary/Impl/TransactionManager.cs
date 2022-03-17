using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary
{
    public class TransactionManager
    {
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        public TransactionManager()
        {

        }

        //TODO: implementation
        public MonthlyLedger GetLedger(int year, int month)
        {
            throw new NotImplementedException();
        }

        //TODO: implementation
        public PetReport GetPetReport(int year, int month)
        {
            throw new NotImplementedException();
        }


        //TODO: implementation
        public void LoadTransactions()
        {
            throw new NotImplementedException();
        }


        
    }

}



