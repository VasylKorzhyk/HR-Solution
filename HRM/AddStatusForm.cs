using HRM.BLL.Services;
using HRM.DAL;
using HRM.DAL.Entities;
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

namespace HRM
{
    public partial class AddStatusForm : Form
    {
        private readonly HumanDBContext context;
        private readonly EmployeeService employeeService;
        private readonly StatusService statusService;

        public AddStatusForm(HumanDBContext context)
        {
            InitializeComponent();

            this.context = context;
            this.employeeService = new EmployeeService(new EmployeeRepository(this.context));
            this.statusService = new StatusService(new StatusRepository(this.context));
            this.LoadDataOnForm();
        }

        private void LoadDataOnForm() 
        {
            this.personBox.DataSource = this.context.Employees.ToList();
            this.statusTypeBox.DataSource = this.context.StatusTypes.ToList();
        }

        private void addStatusButton_Click(object sender, EventArgs e)
        {
            Employee employee = (Employee)personBox.SelectedItem;
            employee.Person.WorkerStatus = new WorkerStatus
            {
                Id = Guid.NewGuid().ToString(),
                StartDate = startDatePicker.Value,
                EndDate = endDatePicker.Value,
                StatusType = (StatusType)statusTypeBox.SelectedItem
            };
            this.employeeService.Update(employee);

            this.Close();
        }
    }
}
