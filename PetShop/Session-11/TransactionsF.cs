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
        private List<Transaction> _transactions;
        public TransactionsF()
        {
            InitializeComponent();
        }

        private void TransactionsF_Load(object sender, EventArgs e)
        {
            
        }
    }
}
