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
                   
        }


        private void petsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PetForm petForm = new PetForm();
            petForm.ShowDialog();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.ShowDialog();
        }

        private void petFoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PetFoodsForm form = new PetFoodsForm();
            form.ShowDialog();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new EmployeesForm();
            employeesForm.ShowDialog();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer form = new FormCustomer();
            form.ShowDialog();
        }
    }
}