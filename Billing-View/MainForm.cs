using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billing;

namespace Billing_View
{
    public partial class MainForm : Form
    {
        public List<IEmployee> Employee;

        public MainForm()
        {
            InitializeComponent();
            Employee = new List<IEmployee>();
            iEmployeeBindingSource.DataSource = Employee;
        }

        private void buttonAddEmpl_Click(object sender, EventArgs e)
        {
            var form2 = new EmployeeForm();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                iEmployeeBindingSource.Add(form2.GetEmployee());
            }
        }

        private void buttonRemoveEmpl_Click(object sender, EventArgs e)
        {
            iEmployeeBindingSource.RemoveCurrent();
        }

 
    }
}
