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

namespace Session_11
{
    public partial class EmployeesForm : Form
    {
        private List<Employee> _employees;
        private PetShopManager _petShopManager;
        //private Employee _employee;
        public EmployeesForm()
        {
            InitializeComponent();
        }


        private void EmployeesF_Load(object sender, EventArgs e)
        {
            _petShopManager = new PetShopManager();
            //_employee = new Employee();
            _employees = new List<Employee>();
            PopulateControls();

            BindingSource bsEmployees = new BindingSource();
            bsEmployees.DataSource = _petShopManager.GetEmployees();
            grdEmployees.DataSource = bsEmployees;
            
        }

        private void PopulateControls()
        {
            var employee3 = new Employee()
            {
                Name = "Dimitris",
                Surname = "Mantikidis",
                Type = EmployeeType.Employee,
                Salary = 1000
            };

            var manager = new Employee()
            {
                Name = "Giannis",
                Surname = "Eskioglou",
                Type = EmployeeType.Manager,
                Salary = 1000
            };
            var employee1 = new Employee()
            {
                Name = "Achileas",
                Surname = "M",
                Type = EmployeeType.Employee,
                Salary = 1000
            };
            var employee2 = new Employee()
            {
                Name = "Kyriakos",
                Surname = "M",
                Type = EmployeeType.Employee,
                Salary = 1000
            };
            _petShopManager.Add(employee1);
            _petShopManager.Add(employee2);
            _petShopManager.Add(employee3);
            _petShopManager.Add(manager);

        }

        private void EmployeesF_Load_1(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewEmployeeForm form = new NewEmployeeForm();
            form.ShowDialog();
        }
    }
}
