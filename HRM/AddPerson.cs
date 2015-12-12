using HRM.BLL.Services;
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

namespace HRM
{
    public partial class AddPerson : Form
    {
        private readonly HumanDBContext context;
        public AddPerson(HumanDBContext context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
