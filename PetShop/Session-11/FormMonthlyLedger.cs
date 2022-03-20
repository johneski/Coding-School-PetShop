﻿using PetShopLibrary;
using PetShopLibrary.DataObjects;
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
    public partial class FormMonthlyLedger : Form
    {
        decimal RENT = 2000;


        private List<Transaction> _listOfTransactions;
        private List<PetFood> _listPetFoods;
        private List<Pet> _listOfPet;
        private PetShopManager _petShopManager = new PetShopManager();
        private int _month;
        private int _year;

        private CustomerPolicies _customerPolicies=new CustomerPolicies();
        


        public FormMonthlyLedger()
        {
            InitializeComponent();
        }

        #region FormCustomer_UI
        private void FormMonthlyLedger_Load(object sender, EventArgs e)
        {
            

            
            GetInitial();

            DisplayQualities();





            var t1 = new Transaction();
            var t2 = new Transaction();
            var t3 = new Transaction();
            _listOfTransactions.Add(t1);
            _listOfTransactions.Add(t2);
            _listOfTransactions.Add(t3);



            

        }

        

        private void btnEnter_Click(object sender, EventArgs e)
        {
            ClearResult();
            _month =GetMonth();
            

            if (ValidMonthAndYear(_month, ctrlYear.Text))
            {
                IncomeExpensesTotal(_month, ctrlYear.Text);

            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        public void IncomeExpensesTotal(int month, string year)
        {
            decimal _income = 0;
            decimal? _expenses = 0;


            var _listOfMonthYearTransactions = _listOfTransactions.Where(x => (x.Date.Month == month) && x.Date.Year == Int32.Parse(year));

            foreach (Transaction transaction in _listOfMonthYearTransactions)
            {
                _income += transaction.TotalPrice;

                var _petfoodID = transaction.PetFoodID;
                var _petID = transaction.PetID;

                var _specificPetfood = _listPetFoods.FirstOrDefault(y => y.ID == _petfoodID);
                var _specificPet = _listOfPet.FirstOrDefault(y => y.ID == _petID);

                if (_specificPetfood != null && _specificPet != null)
                {
                    _expenses += _specificPetfood.Cost * (transaction.PetFoodQty - 1);
                    _expenses += _specificPet.Cost;
                }


            }
            _expenses += RENT;

            ctrlExpenses.Text = _expenses.ToString();
            ctrlIncome.Text = _income.ToString();
            ctrlTotal.Text = (_income - _expenses).ToString();

        }
        private void DisplayQualities()
        {
            comboBoxMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            ctrlExpenses.ReadOnly = true;
            ctrlIncome.ReadOnly = true;
            ctrlTotal.ReadOnly = true;

            ctrlExpenses.BackColor = System.Drawing.SystemColors.Window;
            ctrlIncome.BackColor = System.Drawing.SystemColors.Window;
            ctrlTotal.BackColor = System.Drawing.SystemColors.Window;
        }

        private void GetInitial()
        {
           

            _listOfTransactions = _petShopManager.GetTransactions();
            _listPetFoods = _petShopManager.GetPetFoods();
            _listOfPet = _petShopManager.GetPets();


            
           
        }

        private int GetMonth()
        {
            
            return comboBoxMonth.SelectedIndex + 1;
        }
        private bool ValidMonth(int month)
        {
            
            if (month == 0)
            {
                MessageBox.Show("You have not selected a month");
                return false;
            }
            return true;

        }
        private bool ValidDate(string year,int month)
        {
            if (_customerPolicies.CheckIFNumber(year))
            {
                _year = Int32.Parse(year);
                
                if (_year > DateTime.Now.Year ||(_year == DateTime.Now.Year && month> DateTime.Now.Month))
                {
                    MessageBox.Show("We can not predict your future income yet, please enter a valid date");
                    return false;

                }   
                else if (_year < 1945)
                {
                    MessageBox.Show("The Petshop was founded in 1946, please enter a valid year");
                    return false;
                }
                else
                {
                    return true;
                }
               
            }
            else
            {
                MessageBox.Show("Year must be a number, try again");
                return false;
            }
        }

        private bool ValidMonthAndYear(int month,string year)
        {
            if (ValidMonth(month))
            {
                return (ValidDate(year,month));
            }
            return false;
        }

        private void ClearResult()
        {
            ctrlExpenses.Text = string.Empty;
            ctrlIncome.Text = string.Empty;
            ctrlTotal.Text = string.Empty;
        }

       





        








    }
   

} 
    
