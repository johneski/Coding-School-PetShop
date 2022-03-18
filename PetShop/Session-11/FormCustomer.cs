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
        private int NUMBER_OF_PHONE_DIGITS = 10;
        private int NUMBER_OF_INT_DIGITS = 9;
        public FormCustomer()
        {
            InitializeComponent();
        }
        List<Customer> CustomerList { get; set; }
        

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            gridViewCustomers.OptionsBehavior.Editable = false;

            ctrlFullname.ReadOnly = true;
            ctrlFullname.BackColor = System.Drawing.SystemColors.Window;
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
            /*ctrlName.DataBindings.Add(new Binding("EditValue", gridCustomerList.DataSource, "Name", true));

            ctrlSurname.DataBindings.Add(new Binding("EditValue", gridCustomerList.DataSource, "Surname", true));
            ctrlFullname.DataBindings.Add(new Binding("EditValue", gridCustomerList.DataSource, "Fullname", true));
            ctrlTIN.DataBindings.Add(new Binding("EditValue", gridCustomerList.DataSource, "Tin", true));
            ctrlPhoneNumber.DataBindings.Add(new Binding("EditValue", gridCustomerList.DataSource, "PhoneNumber", true));*/
            
            
            
        }
        private bool CheckIFNumber(string stringNumber)
        {
            int numericValue;
            bool isNumber = int.TryParse(stringNumber, out numericValue);
            return (isNumber);
        }

        private bool CheckInt(string INT)
        {
            if (CheckIFNumber(INT))
            {
                return (INT.Length == NUMBER_OF_INT_DIGITS);
            }
            return (false);                
        }
        public bool ChecKPhoneNumber(string phoneNumber)
        {
            if (CheckIFNumber(phoneNumber))
            {
                return (phoneNumber.Length == NUMBER_OF_PHONE_DIGITS);
            }
            return (false);
        }
        private void bindingPetShopCustomers_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ctrlName.Undo();
            
        }

        private void ctrlName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ctrlName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridViewCustomers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Customer _customer=gridViewCustomers.GetFocusedRow() as Customer;
            ctrlName.EditValue = _customer.Name;
            ctrlSurname.EditValue= _customer.Surname;
            ctrlFullname.EditValue = _customer.Fullname;
            ctrlPhoneNumber.EditValue= _customer.PhoneNumber;
            ctrlTIN.EditValue = _customer.Tin;





        }
    }
}
