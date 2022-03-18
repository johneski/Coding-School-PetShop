﻿using System;
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
       public List<PetFoodType> _petFoodTypes = new List<PetFoodType>();
        private PetShopLibrary.PetShop _petShop;
        public PetFoodsForm()
        {
            InitializeComponent();
        }

        private void PetFoodsForm_Load(object sender, EventArgs e)
        {
            _petShop= new PetShopLibrary.PetShop();
            _petShop.PetFoods = new List<PetFood>();

            PopulateControls();

        }

        private void PopulateControls()
        {
            var dry = new PetFoodType();
            var canned = new PetFoodType();
            var home_cooked = new PetFoodType();
            var raw = new PetFoodType();

            _petShop.PetFoods.Add(dry);
            _petShop.PetFoods.Add(dry);
            _petShop.PetFoods.Add(dry);
            _petShop.PetFoods.Add(dry);






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
