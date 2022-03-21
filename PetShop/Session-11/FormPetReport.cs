using PetShopLibrary;
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
    public partial class FormPetReport : Form
    {
        private List<Transaction> _listOfTransactions;
        
        private List<Pet> _listOfPet;
        public PetShopManager petShopManager=new PetShopManager();
        private AnimalType _animalType;
        private int _month;
        private int _year;

        private CustomerPolicies _customerPolicies = new CustomerPolicies();



        public FormPetReport()
        {
            InitializeComponent();
        }
        #region FormPetReport_UI
        private void FormPetReport_Load(object sender, EventArgs e)
        {
            GetInitial();

            DisplayQualities();

            comboBoxAnimalType.Properties.Items.AddRange(Enum.GetValues(typeof(AnimalType)));

        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            ClearResult();
            _month = GetMonth();


            if (ValidMonthAndYear(_month, ctrlYear.Text) && CheckAnimalType(comboBoxAnimalType.SelectedIndex))
            {
                IncomeExpensesTotal(_month, ctrlYear.Text);

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        private void GetInitial()
        {
            _listOfTransactions = petShopManager.GetTransactions();
            
            _listOfPet = petShopManager.GetPets();
        }

        private void DisplayQualities()
        {
            comboBoxMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            comboBoxAnimalType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            ctrlTotalSold.ReadOnly = true;
                        
            ctrlTotalSold.BackColor = System.Drawing.SystemColors.Window;
            
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
        private bool ValidDate(string year, int month)
        {
            if (_customerPolicies.CheckIFNumber(year))
            {
                _year = Int32.Parse(year);

                if (_year > DateTime.Now.Year || (_year == DateTime.Now.Year && month > DateTime.Now.Month))
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

        private bool ValidMonthAndYear(int month, string year)
        {
            if (ValidMonth(month))
            {
                return (ValidDate(year, month));
            }
            return false;
        }

         
        private bool CheckAnimalType(int animalType)
        {
            if (animalType == -1){
                MessageBox.Show("You need to select an animal type");

            }
            return !(animalType == -1); 
        }
        private void ClearResult()
        {
            ctrlTotalSold.Text = string.Empty;
            
        }

        public void IncomeExpensesTotal(int month, string year)
        {
            
            decimal? _totalSold = 0;


            var _listOfMonthYearTransactions = _listOfTransactions.Where(x => (x.Date.Month == month) && x.Date.Year == Int32.Parse(year));

            _animalType = (AnimalType)comboBoxAnimalType.SelectedIndex;

            foreach (Transaction transaction in _listOfMonthYearTransactions)
            {


                var _petID = transaction.PetID;

                
                var _specificPet = _listOfPet.FirstOrDefault(y => y.ID == _petID);
                

                if (_specificPet.AnimalType == _animalType && _specificPet != null) 
                {
                    _totalSold++;
                   
                }


            }
            

            
            ctrlTotalSold.Text = (_totalSold).ToString();

        }

       
    }
}
