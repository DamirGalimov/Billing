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
    //TODO: кнопки cancel и ok на форме переставить местами, как это принято
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            //TODO: лучше задавать через дизайнер
            employeeControl.ReadOnly = false;
        }

        /// <summary>
        /// Переменная для хранения работника
        /// </summary>
        private IEmployee _employee;

        /// <summary>
        /// Устанавливает или возвращает работника
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
        /// Кнопка ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {  
                _employee = employeeControl.Employee;
                this.DialogResult = DialogResult.OK;
                Close();
            }

            catch (Exception de)
            {//TODO: пустую строку убрать

                //TODO: сообщение по-русски, другие по-английски. Сделать единообразно.
                MessageBox.Show(de.Message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        /// <summary>
        /// Кнопка Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        
    }
}
