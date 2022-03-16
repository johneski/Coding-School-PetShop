using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary
{
    public interface IPetReport
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public enum AnimalType { dog, cat, parrot }

        public int TotalSold { get; set; }
    }



    public class PetReport:IPetReport
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public enum AnimalType { dog, cat, parrot }

        public int TotalSold { get; set; }

        public PetReport()
        {

        }
    }
}
