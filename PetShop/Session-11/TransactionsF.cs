using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopLibrary;
using System.Windows.Forms;

namespace Session_11
{
    public partial class TransactionsF : Form
    {
        private PetShopManager _petShop;
        
        public TransactionsF()
        {
            InitializeComponent();
        }

        private void TransactionsF_Load(object sender, EventArgs e)
        {
            _petShop = new PetShopManager();
            DummyData();
            BindingSource bsTransactions = new BindingSource(_petShop.GetTransactions(), null);

            grdTransactions.DataSource = bsTransactions;
            HideColumns();


        }

        private void DummyData()
        {
            Transaction t = new Transaction();
            Transaction t1 = new Transaction();
            Transaction t2 = new Transaction();
            Transaction t3 = new Transaction();
            _petShop.Add(t);
            _petShop.Add(t1);
            _petShop.Add(t2);
            _petShop.Add(t3);
        }

        private void HideColumns()
        {
            grdViewTransactions.Columns["ID"].Visible = false;
            grdViewTransactions.Columns["CustomerID"].Visible = false;
            grdViewTransactions.Columns["EmployeeID"].Visible = false;
            grdViewTransactions.Columns["PetID"].Visible = false;
            grdViewTransactions.Columns["PetPrice"].Visible = false;
            grdViewTransactions.Columns["PetFoodID"].Visible = false;
            grdViewTransactions.Columns["PetFoodQty"].Visible = false;
            grdViewTransactions.Columns["PetFoodPrice"].Visible = false;
            grdViewTransactions.Columns["TotalPrice"].Visible = false;
        }
    }
}
