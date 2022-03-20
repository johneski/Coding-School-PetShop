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

            cmbType.DataSource = Enum.GetValues(typeof(FoodType));
            cmbType.SelectedIndex = -1;
            cmbType.Text = "Please choose a type";
            cmbBrand.DataSource = Enum.GetValues(typeof(FoodBrand));
            cmbBrand.SelectedIndex = -1;
            cmbBrand.Text = "Please choose a brand";
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int foodTypeIndex = cmbType.SelectedIndex;
            int foodBrandIndex = cmbBrand.SelectedIndex;
            decimal price = Convert.ToDecimal(txtPrice.Text);
            decimal cost = Convert.ToDecimal(txtCost.Text); 

            if(foodTypeIndex >=0 && foodBrandIndex >=0 && price>=0 && cost >= 0)
            {
                if(price >= cost)
                {
                    FoodType foodType = (FoodType)foodTypeIndex;
                    FoodBrand foodBrandType = (FoodBrand)foodBrandIndex;

                    PetFood petFood = new PetFood()
                    {
                        Brand = foodBrandType,
                        Price = price,
                        Cost = cost,
                        Type = foodType,
                        ID = Guid.NewGuid(),
                    };



                    _petShop.Add(petFood);
                    _petShop.Save();

                }
                else
                {
                    MessageBox.Show("Check again the price and cost ");
                }
                
            }
            MessageBox.Show("Saved");
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cmbType_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //AnimalType animalType = (AnimalType)cmbType.SelectedIndex;
            //GetFoodType(animalType);

        }
    }
}
