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
    public partial class PetForm : Form
    {
       
        private PetShopManager _petShop;
       
        public PetForm()
        {
            InitializeComponent();
        }

        private void PetForm_Load(object sender, EventArgs e)
        {
            
            _petShop = new PetShopManager();
           
           
            
                PopulateControls();
            
            
        }

        private void PopulateControls()
        {
            var reptil = new Pet()
            {
                AnimalType = AnimalType.Reptilian,
                Breed = "Cobra",
                Status = PetStatus.OK,
                FoodType = new PetFood() { Type = FoodType.ReptilianFood, Brand = FoodBrand.Purina }
            };

            var dog = new Pet()
            {
                AnimalType = AnimalType.Mammal,
                Breed = "Labrador",
                Status = PetStatus.OK,
                FoodType = new PetFood() { Type = FoodType.DogFood, Brand = FoodBrand.Pedigree }
            };
            var cat = new Pet()
            {
                AnimalType = AnimalType.Mammal,
                Breed = "egyptian",
                Status = PetStatus.OK,
                FoodType = new PetFood() { Type = FoodType.CatFood, Brand = FoodBrand.Friskis }
            };
            var fish = new Pet()
            {
                AnimalType = AnimalType.Fish,
                Breed = "goldfish",
                Status = PetStatus.OK,
                FoodType = new PetFood() { Type = FoodType.FishFood, Brand = FoodBrand.Friskis, }
            };
            _petShop.Add(reptil);
            _petShop.Add(dog);
            _petShop.Add(cat);
            _petShop.Add(fish);

            BindingSource bsPets = new BindingSource();
            bsPets.DataSource = _petShop.GetPets();

            grdPets.DataSource = bsPets;


        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
