using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShopLibrary;

namespace Session_11
{
    public partial class PetFoodsForm : Form
    {
       
        private PetShopManager _petShop;
        public PetFoodsForm()
        {
            InitializeComponent();
        }

        private void PetFoodsForm_Load(object sender, EventArgs e)
        {
            _petShop = new PetShopManager();
            
            

            PopulateControls();

        }

        private void PopulateControls()
        {
            var CatFood = new PetFood()
            {
               Price = 40,
               Brand = FoodBrand.Purina,
               Cost = 30,
               ID = Guid.NewGuid(),
               Type = FoodType.CatFood
            };
            var DogFood = new PetFood()
            {
                Price = 60,
                Brand = FoodBrand.Purina,
                Cost = 50,
                ID = Guid.NewGuid(),
                Type = FoodType.DogFood
            };
            var BirdFood = new PetFood()
            {
                Price = 30,
                Brand = FoodBrand.Purina,
                Cost = 20,
                ID = Guid.NewGuid(),
                Type = FoodType.BirdFood
            };
            var ReptilFood = new PetFood()
            {
                Price = 50,
                Brand = FoodBrand.Purina,
                Cost = 20,
                ID = Guid.NewGuid(),
                Type = FoodType.ReptilianFood
            };
            var FishFood = new PetFood()
            {
                Price = 20,
                Brand = FoodBrand.Purina,
                Cost = 10,
                ID = Guid.NewGuid(),
                Type = FoodType.FishFood
            };

            _petShop.Add(CatFood);
            _petShop.Add(DogFood);
            _petShop.Add(FishFood);
            _petShop.Add(ReptilFood);
            _petShop.Add(BirdFood);


            BindingSource bsPetFood = new BindingSource();
            bsPetFood.DataSource = _petShop.GetPetFoods();
            grdPetFoods.DataSource = bsPetFood;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddNewPetFoodForm addNeewPetFoodForm = new AddNewPetFoodForm(_petShop);
            addNeewPetFoodForm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
