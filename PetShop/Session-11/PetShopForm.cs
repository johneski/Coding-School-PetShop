using PetShopLibrary;

namespace Session_11
{
    public partial class PetShopForm : Form
    {
        private PetShopManager _petShop;
        public PetShopForm(PetShopManager petShop)
        {
            InitializeComponent();
            _petShop = petShop;
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                   
        }


        private void petsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PetForm petForm = new PetForm(_petShop);
            petForm.ShowDialog();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm(_petShop);
            transactionForm.ShowDialog();
        }

        private void petFoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PetFoodsForm form = new PetFoodsForm(_petShop);
            form.ShowDialog();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new EmployeesForm();
            employeesForm.ShowDialog();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer form = new FormCustomer(_petShop);
            form.ShowDialog();
        }

        private void PetShopForm_Load(object sender, EventArgs e)
        {
            //PetShopForm.CenterToScreen
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
        }
    }
}