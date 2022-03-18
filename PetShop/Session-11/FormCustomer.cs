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
        private int NUMBER_OF_PHONE_DIGITS = 9;
        private int NUMBER_OF_INT_DIGITS = 10;

        private Customer _customer = new Customer();
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
            Customer K = new Customer("Kyriakos", "Mousias", "123456789", "0123456789");
            Customer G = new Customer("Giannis", "Eskioglou", "234567891", "2345678901");
            Customer A = new Customer("Axilleas", "Mplekos", "345678912", "3456789012");
            Customer D = new Customer("Dimitris", "Mantikidis", "456789123", "4567890123");

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
          /*  int numericValue; str.All(char.IsDigit)
            bool isNumber = int.TryParse(stringNumber, out numericValue);*/
            return (stringNumber.All(char.IsDigit));
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
        public bool CheckValidSave(string phoneNumber, string INT)
        {
            return (CheckInt(INT) && ChecKPhoneNumber(phoneNumber));
        }
        private void bindingPetShopCustomers_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
        }

        private void ctrlName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ctrlName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridViewCustomers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _customer=gridViewCustomers.GetFocusedRow() as Customer;
            ctrlName.EditValue = _customer.Name;
            ctrlSurname.EditValue= _customer.Surname;
            ctrlFullname.EditValue = _customer.Fullname;
            ctrlPhoneNumber.EditValue= _customer.PhoneNumber;
            ctrlTIN.EditValue = _customer.Tin;





        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            


            if(CheckValidSave(ctrlPhoneNumber.Text, ctrlTIN.Text))
            {
                _customer = gridViewCustomers.GetFocusedRow() as Customer;
                var _rowStudent = (gridViewCustomers.GetFocusedRow() as Customer);
                /*(gridViewCustomers.GetFocusedRow() as Customer).Tin = ctrlTIN.Text;
                (gridViewCustomers.GetFocusedRow() as Customer).PhoneNumber=ctrlPhoneNumber.Text;
    */
                _rowStudent.Tin = ctrlTIN.Text;
                _rowStudent.Name = ctrlName.Text;
                _rowStudent.Surname = ctrlSurname.Text;
                _rowStudent.PhoneNumber = ctrlPhoneNumber.Text;
                


            }
            



        }
    }
}
