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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Переменная для хранения работника
        /// </summary>
        private IEmployee _employee;

        public IEmployee Employee
        {
            get
            {
                return _employee;
            }
            set
            {
                //employeeControl.Employee = value;
            }
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {

                //_employee = employeeControl.Employee;

                this.DialogResult = DialogResult.OK;
                Close();
            }

            catch (Exception de)
            {

                MessageBox.Show(de.Message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
