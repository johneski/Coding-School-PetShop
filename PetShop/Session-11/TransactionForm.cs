using DevExpress.XtraGrid.Views.Base;
using PetShopLibrary;
using PetShopLibrary.DataObjects;
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
    public partial class TransactionForm : Form
    {
        private PetShopManager _petShop;
        public TransactionForm(PetShopManager petShop)
        {
            InitializeComponent();
            _petShop = petShop;
        }

        private void TransactionForm_Load_1(object sender, EventArgs e)
        {
            txtDate.EditValue = DateTime.UtcNow;
            List<Pet> pets = _petShop.GetPets();
            bsPets.DataSource = pets;
            grdTransaction.DataSource = bsPets;

            grvTransaction.FocusedRowChanged += OnFocusRowChange;
            grvTransaction.OptionsBehavior.Editable = false;

            if (pets.Count > 0)
                OnFocusRowChange(sender, null);            
        }

        private void OnFocusRowChange(object sender, FocusedRowChangedEventArgs e)
        {
            Pet? pet = grvTransaction.GetFocusedRow() as Pet;
            if (pet == null) return;

            var availableBrands = _petShop.GetAvailableFoodBrands(pet.AnimalType);

            if(availableBrands.Count > 0) cmbFoodBrand.DataSource = availableBrands;
            else cmbFoodBrand.DataSource = new List<string>() { ""};

            pet.FoodType.Brand = cmbFoodBrand.SelectedText;

            txtTotal.EditValue = _petShop.GetTotalPrice(pet, (int) spinPetFoodQty.Value);

            cmbFoodBrand.Refresh();
        }

        private void txtTIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) return;

            string TIN = (string)txtTIN.EditValue;
            CustomerPolicies policy = new CustomerPolicies();

            if (!policy.CheckInt(TIN))
            {
                MessageBox.Show(this, "Wrong TIN format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var customer = _petShop.GetCustomers().Find(x => x.Tin.Equals(TIN));
            if (customer == null)
            {
                MessageBox.Show(this, "Customer not found!", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            txtName.EditValue = customer.Name;
            txtSurName.EditValue = customer.Surname;
            txtPhoneNumber.EditValue = customer.PhoneNumber;

        }

    }
}
