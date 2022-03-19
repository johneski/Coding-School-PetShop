using PetShopLibrary;

namespace Session_11
{
    public partial class PetShopForm : Form
    {
        private PetShop _petShop;
        public PetShopForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // if filename does not exist then
            // create data and save
            // LoadData            
        }

        private void Save()
        {

        }

        private void Load()
        {

        }

        private void CreateCustomer()
        {
            Customer customer = new Customer()
            {
                Name = "John",
                Surname = "Eski",
                PhoneNumber = "1234567",
                Tin = "1234"
            };

            _petShop.Customers.Add(customer);
        }

        private void CreatePet()
        {

        }

        private void CreatePetFood()
        {

        }

        private void CreateEmployee()
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void petsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PetForm petForm = new PetForm();
            petForm.ShowDialog();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}