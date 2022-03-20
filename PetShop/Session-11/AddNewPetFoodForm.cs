using PetShopLibrary;
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
    public partial class AddNewPetFoodForm : Form
    {
        private PetShopManager _petShop;
        public AddNewPetFoodForm(PetShopManager petShopManager)
        {
            InitializeComponent();
            _petShop = petShopManager;
            
        }

        private void AddNewPetFoodForm_Load(object sender, EventArgs e)
        {
            
            cmbType.DataSource = Enum.GetValues(typeof(AnimalType));
            cmbType.SelectedIndex = -1;
            //cmbAnimalType.DataSource = Enum.GetValues(typeof(AnimalType));
            //cmbAnimalType.SelectedIndex = -1;
            //cmbAnimalType.Text = "Please choose a type";
            //cmbStatus.DataSource = Enum.GetValues(typeof(PetStatus));
            //cmbStatus.SelectedIndex = -1;
            //cmbStatus.Text = "Please choose a status";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal cost = 0;
            decimal price = 0;
            var animalType = (AnimalType)cmbType.SelectedItem;
            var brand = cmbBrand.Text;
            var validCost = decimal.TryParse(txtCost.Text, out cost);
            var validPrice = decimal.TryParse(txtPrice.Text, out price);

            if(validCost && validPrice && (int)animalType != -1 && brand != String.Empty && price >= cost)
            {

                var food = new PetFood()
                {
                    Brand = brand,
                    Price = price,
                    Cost = cost,
                    Type = _petShop.GetFoodType(animalType)
                };
                _petShop.Add(food);
                _petShop.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong or empty values!");
            }

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnimalType type = (AnimalType)cmbType.SelectedIndex;
            List<string> brands = _petShop.GetFoodBrand(type);
            cmbBrand.DataSource = brands;
            

        }
    }
}
