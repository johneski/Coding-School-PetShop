﻿using DevExpress.XtraGrid.Columns;
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
        private Pet _currentPet;
        private Customer? _currentCustomer;
        private decimal _total;
        private bool _searched = false;

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
            spinPetFoodQty.Properties.MinValue = 0;

            if (pets.Count > 0)
                OnFocusRowChange(sender, null);

            grvTransaction.Columns["ObjectStatus"].FilterInfo = new ColumnFilterInfo("ObjectStatus == 'Active' and HealthStatus != 'Unhealthy'");
        }

        private void OnFocusRowChange(object sender, FocusedRowChangedEventArgs e)
        {
            _currentPet = grvTransaction.GetFocusedRow() as Pet;
            if (_currentPet == null) return;

            
            var availableBrands = _petShop.GetAvailableFoodBrands(_currentPet.AnimalType);

            if (availableBrands.Count > 0)
            {
                cmbFoodBrand.DataSource = availableBrands;
            }
            else
            {
                cmbFoodBrand.DataSource = new List<string>() { "" };
                cmbFoodBrand.SelectedIndex = -1;
            }

            var index = cmbFoodBrand.SelectedIndex;

            if(index >= 0)
                _currentPet.FoodType.Brand = availableBrands[index];

            var qty = _petShop.GetAvailableFoodQty(_currentPet.FoodType.Brand);
            if(qty > 0)
            {
                spinPetFoodQty.Value = 1;
                spinPetFoodQty.Properties.ReadOnly = false;
            }
            else
            {
                spinPetFoodQty.Value = 0;
                spinPetFoodQty.Properties.ReadOnly = true;
            }

            spinPetFoodQty.Properties.MaxValue = qty;

            CalcTotalPrice();

            cmbFoodBrand.Refresh();
        }

        private void spinPetFoodQty_EditValueChanged(object sender, EventArgs e)
        {
            CalcTotalPrice();
        }

        private void CalcTotalPrice()
        {
            _total = _petShop.GetTotalPrice(_currentPet, int.Parse(spinPetFoodQty.Value.ToString()));
            txtTotal.EditValue = _total;
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

            _currentCustomer = _petShop.GetCustomers().Find(x => x.Tin.Equals(TIN));
            if (_currentCustomer == null)
            {
                MessageBox.Show(this, "Customer not found!", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            txtName.EditValue = _currentCustomer.Name;
            txtSurName.EditValue = _currentCustomer.Surname;
            txtPhoneNumber.EditValue = _currentCustomer.PhoneNumber;

            _searched = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Are you sure you want to exit?\nAll unsaved changes will be lost!","Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
                this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_searched) return;

            string user = txtUser.Text;
            Guid petId = (Guid)_currentPet.ID;
            Guid custId = (Guid)_currentCustomer.ID;
            decimal petPrice = _currentPet.Price;
            Guid foodId = (Guid)_currentPet.FoodType.ID;
            int qty = int.Parse(spinPetFoodQty.Value.ToString());
            decimal foodPrice = _currentPet.FoodType.Price;

            TransactionView transView = new TransactionView(_petShop);
            Transaction transaction = transView.CreateView(user, custId, petId, petPrice, foodId, qty, foodPrice, _total);
            _petShop.Add(transaction);
            _petShop.Save();
        }
    }
}
