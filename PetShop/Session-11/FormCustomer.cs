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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }
        List<Customer> CustomerList { get; set; }
        

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            //initialization
            Customer K = new Customer("Kyriakos", "Mousias", "6923411238", "324511234");
            Customer G = new Customer("Giannis", "Nesk", "6923410008", "326421234");
            Customer A = new Customer("Axilleas", "Papas", "692347778", "32477774");
            Customer D = new Customer("Dimitris", "Zanos", "6923333238", "333333234");

            CustomerList = new List<Customer>();
            CustomerList.Add(K);
            CustomerList.Add(G);
            CustomerList.Add(A);
            CustomerList.Add(D);
            //end initialization

            BindingSource bsCustomers = new BindingSource();
            bsCustomers.DataSource = CustomerList;
            gridCustomerList.DataSource = bsCustomers.DataSource;
            SetDataBindings();


        }

        private void SetDataBindings()
        {
            ctrlName.DataBindings.Add(new Binding("EditValue", gridCustomerList.DataSource, "Name", true));

            ctrlSurname.DataBindings.Add(new Binding("EditValue", gridCustomerList.DataSource, "Surname", true));
            ctrlFullname.DataBindings.Add(new Binding("EditValue", gridCustomerList.DataSource, "Fullname", true));
            ctrlTIN.DataBindings.Add(new Binding("EditValue", gridCustomerList.DataSource, "Tin", true));
            ctrlPhoneNumber.DataBindings.Add(new Binding("EditValue", gridCustomerList.DataSource, "PhoneNumber", true));
            
            
            
        }

        private void CheckInt()
        {

        }
        public void ChechPhoneNumber()
        {

        }
        private void bindingPetShopCustomers_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
