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
       
        public PetShopManager _petShop;
        
       
        public PetForm(PetShopManager petShop)
        {
            InitializeComponent();
            _petShop = petShop;
        }

        private void PetForm_Load(object sender, EventArgs e)
        {

            
            //PopulateControls();
            BindingSource bsPets = new BindingSource();
            bsPets.DataSource = _petShop.GetPets();

            grdPets.DataSource = bsPets;
            grvPets.RefreshData();

        }
        



        private void btnNew_Click(object sender, EventArgs e)
        {
            
            AddNewPetForm addNewPetForm = new AddNewPetForm(_petShop);
            addNewPetForm.ShowDialog();
            grvPets.RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
