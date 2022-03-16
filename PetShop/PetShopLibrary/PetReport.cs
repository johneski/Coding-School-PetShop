using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary
{
    public enum AnimalType { dog, cat, parrot}
    public interface IPetReport
    {
        int Year { get; set; }
        int Month { get; set; }
        AnimalType Type { get; set; }

        int TotalSold { get; set; }
    }



    public class PetReport:IPetReport
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public AnimalType Type { get; set; }
        public int TotalSold { get; set; }
        

        public PetReport(int year, int month, List<Transaction> transactions)
        {
            Year = year;
            Month = month;
        }
    }
}
