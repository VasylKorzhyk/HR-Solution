using HRM.DAL;
using HRM.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRM.BLL.Services;
using HRM.DAL.Entities;

namespace HRM
{
    public partial class Form1 : Form
    {
        private readonly HumanDBContext context;
        private readonly EmployeeService employeeService;
        private readonly 
        public Form1()
        {
            context = new HumanDBContext();
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddPerson(this.context).Show();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            new AddEmployee(this.context).Show();
        }
    }
}
