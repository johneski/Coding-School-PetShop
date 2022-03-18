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
using PetShopLibrary.DataObjects;

namespace Session_11
{
    public partial class FormCustomer : Form
    {
        

        private Customer _customer = new Customer();
        
        public FormCustomer()
        {
            InitializeComponent();
        }
        List<Customer> CustomerList { get; set; }
        

        private void FormCustomer_Load(object sender, EventArgs e)
        {


            InitialView();

            //sbisto
            DummyCustomers();
            //



            SetDataBindings();


        }

       

# region FormCustomer
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

            FillControlsWithGrid(_customer);





        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            var _customerpolicies = new CustomerPolicies();

            SaveCustomer(_customerpolicies);





        }

        #endregion

        private void FillControlsWithGrid(Customer _customer)
        {
            ctrlName.EditValue = _customer.Name;
            ctrlSurname.EditValue = _customer.Surname;
            ctrlFullname.EditValue = _customer.Fullname;
            ctrlPhoneNumber.EditValue = _customer.PhoneNumber;
            ctrlTIN.EditValue = _customer.Tin;
        }
        private void SaveCustomer(CustomerPolicies _customerpolicies)
        {//mou lipe to jsonsave mono
            if (_customerpolicies.CheckValidSave(ctrlPhoneNumber.Text, ctrlTIN.Text))
            {

                var _rowStudent = (gridViewCustomers.GetFocusedRow() as Customer);

                _rowStudent.Tin = ctrlTIN.Text;
                _rowStudent.Name = ctrlName.Text;
                _rowStudent.Surname = ctrlSurname.Text;
                _rowStudent.PhoneNumber = ctrlPhoneNumber.Text;
                gridViewCustomers.RefreshData();

            }
            else
            {


                

                MessageBox.Show("Invalid Input, could not save.","Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign);
            }
        }
        private void InitialView()
        {

            gridViewCustomers.OptionsBehavior.Editable = false;

            ctrlFullname.ReadOnly = true;
            ctrlFullname.BackColor = System.Drawing.SystemColors.Window;
        }
        private void DummyCustomers()
        {
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
        }

        private void SetDataBindings()
        {
            BindingSource bsCustomers = new BindingSource();
            bsCustomers.DataSource = CustomerList;
            gridCustomerList.DataSource = bsCustomers.DataSource;



        }
    }
}
