using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary
{
    public class PetShopManager
    {
        private const string FILE_NAME = "petShop.json";
        private PetShop _petShop;

        public PetShopManager()
        {

        }

        public PetShopManager(PetShop petShop)
        {
            _petShop = petShop;
        }

        public void Save()
        {

        }

        public void Delete()
        {

        }


    }
}
