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
        /// <summary>
        /// Переменная для хранения работника
        /// </summary>
        private IEmployee _employee;

        /// <summary>
        /// Свойство принимающее или возвращающее работника
        /// </summary>
        public IEmployee Employee
        {
            get
            {
                return _employee;
            }
            set
            {
                employeeControl.Employee = value;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public EmployeeForm()
        {
            InitializeComponent();

        }


        /// <summary>
        /// Кнопка отмены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Кнопка ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                _employee = employeeControl.Employee;
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            catch (ArgumentException fe)
            {
                MessageBox.Show(fe.Message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
