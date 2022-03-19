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
        public List<Pet> _pets;
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
                ObjectStatus = PetShopLibrary.DataObjects.Status.Inactive,
                AnimalType = AnimalType.Reptilian,
                Breed = "Cobra",
                HealthStatus = PetStatus.OK,
                FoodType = new PetFood() { Type = FoodType.ReptilianFood, Brand = FoodBrand.Rats}
            };

            var dog = new Pet()
            {
                AnimalType = AnimalType.Mammal,
                Breed = "Labrador",
                HealthStatus = PetStatus.Recovering,
                FoodType = new PetFood() { Type = FoodType.DogFood, Brand = FoodBrand.Pedigree }
            };
            var cat = new Pet()
            {
                AnimalType = AnimalType.Mammal,
                Breed = "egyptian",
                HealthStatus = PetStatus.OK,
                FoodType = new PetFood() { Type = FoodType.CatFood, Brand = FoodBrand.Friskis }
            };
            var fish = new Pet()
            {
                AnimalType = AnimalType.Fish,
                Breed = "goldfish",
                HealthStatus = PetStatus.OK,
                FoodType = new PetFood() { Type = FoodType.FishFood, Brand = FoodBrand.Friskis }
            };
            _petShop.Add(reptil);
            _petShop.Add(dog);
            _petShop.Add(cat);
            _petShop.Add(fish);

            BindingSource bsPets = new BindingSource();
            bsPets.DataSource = _petShop.GetPets();
            grdPets.DataSource = bsPets;
            DevExpress.XtraGrid.Columns.ColumnFilterInfo cinfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo($"HealthStatus != 'Unhealthy' and ObjectStatus = 'Active'");
            grvPets.Columns["HealthStatus"].FilterInfo = cinfo;
            


        }
     }
}
