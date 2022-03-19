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
            
            //cmbType.DataSource = Enum.GetValues(Typ)
            //cmbAnimalType.DataSource = Enum.GetValues(typeof(AnimalType));
            //cmbAnimalType.SelectedIndex = -1;
            //cmbAnimalType.Text = "Please choose a type";
            //cmbStatus.DataSource = Enum.GetValues(typeof(PetStatus));
            //cmbStatus.SelectedIndex = -1;
            //cmbStatus.Text = "Please choose a status";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
