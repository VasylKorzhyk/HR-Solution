using HRM.BLL.Services;
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
        private readonly StatusService statusService;
        public AddStatusForm(StatusService statusService)
        {
            InitializeComponent();

            this.statusService = statusService;
        }
    }
}
