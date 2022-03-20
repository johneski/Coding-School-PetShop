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
        public PetFoodsForm(PetShopManager petShop)
        {
            InitializeComponent();
            _petShop = petShop;
        }

        private void PetFoodsForm_Load(object sender, EventArgs e)
        {

            BindingSource bsPetFood = new BindingSource();
            bsPetFood.DataSource = _petShop.GetPetFoods();
            grdPetFoods.DataSource = bsPetFood;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddNewPetFoodForm addNeewPetFoodForm = new AddNewPetFoodForm(_petShop);
            addNeewPetFoodForm.ShowDialog();
            grvPetFoods.RefreshData();
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
