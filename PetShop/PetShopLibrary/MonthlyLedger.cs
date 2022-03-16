using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary
{
    interface IMonthlyLedger
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expences { get; set; }

        public decimal Total { get; set; }

        public class MonthlyLedger : IMonthlyLedger
        {
            public int Year { get; set; }
            public int Month { get; set; }
            public decimal Income { get; set; }
            public decimal Expences { get; set; }

            public decimal Total { get; set; }




            public MonthlyLedger()
            {

            }
        }
    }
}
