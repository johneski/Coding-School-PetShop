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
        //LOad from jsonfile
        //Petshop petshop=load(json)
        //PetShop petShop = new PetShop();
        private Customer _customer = new Customer();
        private List<Customer> CustomerList ;
        private PetShopManager _petshopManager;
        private bool allowChange = false;
     
        public FormCustomer(PetShopManager petshopManager)
        {
            InitializeComponent();
            _petshopManager = petshopManager;
        }

        #region FormCustomer
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            InitialView();

            //DummyCustomers();

            LoadToCustomerList();

            //sbisto
            //ummyCustomers();

            SetDataBindings();
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
            
            FillControlsWithGrid(_customer);





        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            var _customerpolicies = new CustomerPolicies();

            SaveCustomerToGrid(_customerpolicies);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*DeleteOn();
            MessageBox.Show("Click the Customer you want to delete");*/
            DeleteCustomer();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewCustomer();
        }

        private void gridCustomerList_Click(object sender, EventArgs e)
        {
           
            
        }

        private void FormCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            KeepChanges();

        }


        #endregion

        private void FillControlsWithGrid(Customer _customer)
        {
            if (_customer.Tin !="Insert TIN") 
            {
                ctrlName.EditValue = _customer.Name;
                ctrlSurname.EditValue = _customer.Surname;
                ctrlFullname.EditValue = _customer.Fullname;
                ctrlPhoneNumber.EditValue = _customer.PhoneNumber;
                ctrlTIN.EditValue = _customer.Tin;

            }
            else
            {
                ctrlName.EditValue = _customer.Name;
                ctrlSurname.EditValue = _customer.Surname;
                ctrlFullname.EditValue = "It will be autofilled";
                ctrlPhoneNumber.EditValue = _customer.PhoneNumber;
                ctrlTIN.EditValue = _customer.Tin;

            }
            
        }
        private void SaveCustomerToGrid(CustomerPolicies _customerpolicies)
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
            gridViewCustomers.FocusedRowChanged += OnRowFocusChange;

            gridViewCustomers.OptionsBehavior.Editable = false;

            ctrlFullname.ReadOnly = true;
            ctrlFullname.BackColor = System.Drawing.SystemColors.Window;
        }
        private void DummyCustomers()
        {
            //initialization

            Customer K = new Customer("Kyriakos", "Mousias", "0123456789", "123456789");
            Customer G = new Customer("Giannis", "Eskioglou", "2345678901", "234567891");
            Customer A = new Customer("Axilleas", "Mplekos", "3456789012", "345678912");
            Customer D = new Customer("Dimitris", "Mantikidis", "4567890123", "456789123");

            CustomerList = new List<Customer>();

            CustomerList.Add(K);
            CustomerList.Add(G);
            CustomerList.Add(A);
            CustomerList.Add(D);
            //petShop.Customers = CustomerList;
            
            //SOS
            //need to put_petshop public

            //_petshopManager._petShop.Customers = CustomerList;
            //end initialization
        }

        private void SetDataBindings()
        {
            BindingSource bsCustomers = new BindingSource();
            bsCustomers.DataSource = CustomerList;
            gridCustomerList.DataSource = bsCustomers.DataSource;



        }

        private void OnRowFocusChange(object sender, EventArgs e)
        {
            var row = gridViewCustomers.GetRow(gridViewCustomers.RowCount - 1) as Customer;
            if (row.Tin == "Insert TIN" && allowChange)
            {
                gridViewCustomers.DeleteRow(gridViewCustomers.RowCount - 1);
                allowChange = true;
            }
                
        }

        private void NewCustomer()
        {
            if (CustomerList.Count == 0 || CustomerList[^1].Tin != "Insert TIN")
            {
                var _newcustomer = new Customer();
                _newcustomer.Name = "Insert Name";
                _newcustomer.Surname = "Insert SurName";
                //ctrlFullname.Text = empty.string
                _newcustomer.Tin = "Insert TIN";
                _newcustomer.PhoneNumber = "Insert Phonenumber";
                CustomerList.Add(_newcustomer);
                gridViewCustomers.RefreshData();
                allowChange = false;
                gridViewCustomers.FocusedRowHandle = gridViewCustomers.RowCount - 1;
                allowChange = true;
                //SOSOSOS bug waiting on the corner if fullname changes 
            }
        }
        private void DeleteCustomer()
        {
            
            var index = gridViewCustomers.FocusedRowHandle;
            var msg = string.Format("  Are you sure you want to delete{0}", CustomerList[index].Fullname);



            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(msg, "Delete Window", buttons);
            if (result == DialogResult.Yes)
            {
                CustomerList.RemoveAt(index);
                gridViewCustomers.RefreshData();

            }
            else
            {
                var msg2 = string.Format("Delete of {0} was cancelled", CustomerList[index].Fullname);
                MessageBox.Show(msg2);
            }

        }
        private void RemoveEmptyNewCustomerAndSave()
        {
            //_petshopManager._petShop = petShop;
            

            try
            {
                if (CustomerList[^1].Tin == "Insert TIN")//can it be 0???
                {
                    CustomerList.RemoveAt(CustomerList.Count - 1);
                    _petshopManager.Save();
                    MessageBox.Show("Json file is saved");
                }
                else
                {
                    _petshopManager.Save();
                    MessageBox.Show("Json file is saved");
                }

            }
            catch (Exception)
            {

                
            }
            


        }

       private void KeepChanges()
        {
            var msg2 = "Do you want to save the changes?";
            MessageBoxButtons buttons1 = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(msg2, "Exit", buttons1);
            if (result == DialogResult.Yes)
            {
                RemoveEmptyNewCustomerAndSave();

            }
            else
            {


            }
        }

       private void LoadToCustomerList()
        {
            CustomerList = _petshopManager.GetCustomers();
        }

     



    }
}
