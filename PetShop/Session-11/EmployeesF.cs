﻿using System;
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
    public partial class EmployeesF : Form
    {
        private List<Employee> _employees;
        private Employee _employee;
        public EmployeesF()
        {
            InitializeComponent();
        }

        private void EmployeesF_Load(object sender, EventArgs e)
        {
            PopulateControls();
            _employee = new Employee();
            _employees = new List<Employee>();



        }

        private void PopulateControls()
        {
            //EmployeeTypePopulate
            Dictionary<TypeEnum, string> Types = new Dictionary<TypeEnum, string>;

        }

    }
}
