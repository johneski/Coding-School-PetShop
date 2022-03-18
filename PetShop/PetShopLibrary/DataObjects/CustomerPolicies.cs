using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary.DataObjects
{
    public  class CustomerPolicies
    {
        private int NUMBER_OF_INT_DIGITS=10;
        private int NUMBER_OF_PHONE_DIGITS = 9;
        public CustomerPolicies()
        {

        }

        private bool CheckIFNumber(string stringNumber)
        {
            /*  int numericValue; str.All(char.IsDigit)
              bool isNumber = int.TryParse(stringNumber, out numericValue);*/
            return (stringNumber.All(char.IsDigit));
        }

        private bool CheckInt(string INT)
        {
            if (CheckIFNumber(INT))
            {
                return (INT.Length == NUMBER_OF_INT_DIGITS);
            }
            return (false);
        }
        public bool ChecKPhoneNumber(string phoneNumber)
        {
            if (CheckIFNumber(phoneNumber))
            {
                return (phoneNumber.Length == NUMBER_OF_PHONE_DIGITS);
            }
            return (false);
        }
        public bool CheckValidSave(string phoneNumber, string INT)
        {
            return (CheckInt(INT) && ChecKPhoneNumber(phoneNumber));
        }
    }
}
