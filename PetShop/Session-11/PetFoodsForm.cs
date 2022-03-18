using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class PetFoodsForm : Form
    {
        public List<PetFood> _petFoods;
        private PetFood _petFood;
        public PetFoodsForm()
        {
            InitializeComponent();
        }

        private void PetFoodsForm_Load(object sender, EventArgs e)
        {
            _petFood = new PetFood();
            _petFoods = new List<PetFood>();

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

            _petFoods.Add(CatFood);
            _petFoods.Add(DogFood);
            _petFoods.Add(FishFood);
            _petFoods.Add(ReptilFood);
            _petFoods.Add(BirdFood);


            BindingSource bsPetFood = new BindingSource();
            bsPetFood.DataSource = _petFoods;
            grdPetFoods.DataSource = bsPetFood;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
