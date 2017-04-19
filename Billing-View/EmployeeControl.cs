using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billing;


namespace Billing_View
{
    public partial class EmployeeControl : UserControl
    {
        /// <summary>
        /// Конструктор 
        /// </summary>
        public EmployeeControl()
        {
            InitializeComponent();
            hourlyPayEmployeeControl.Enabled = false;
            salaryPayEmployeeControl.Enabled = false;
        }


        /// <summary>
        /// Возвращает или задает работника
        /// </summary>
        public IEmployee Employee
        {
            get
            {
                if (comboBox.SelectedIndex == 0)
                {
                    hourlyPayEmployeeControl.Enabled = true;
                    return hourlyPayEmployeeControl.HourlyPayEmployee;
                }
                else if (comboBox.SelectedIndex == 1)
                {
                    salaryPayEmployeeControl.Enabled = true;
                    return salaryPayEmployeeControl.SalaryPayEmployee;
                }
                else
                {
                    throw new Exception("Type of employee is not selected.");
                }
            }
            set
            {
                if (value is HourlyPayEmployee)
                {
                    hourlyPayEmployeeControl.HourlyPayEmployee = (HourlyPayEmployee)value;
                    comboBox.SelectedIndex = 0;
                    hourlyPayEmployeeControl.Visible = true;
                    hourlyPayEmployeeControl.Enabled = true;
                    salaryPayEmployeeControl.Visible = false;
                }
                if (value is SalaryPayEmployee)
                {
                    salaryPayEmployeeControl.SalaryPayEmployee = (SalaryPayEmployee)value;
                    comboBox.SelectedIndex = 1;
                    salaryPayEmployeeControl.Visible = true;
                    salaryPayEmployeeControl.Enabled = true;
                    hourlyPayEmployeeControl.Visible = false;

                }
            }
        }

        /// <summary>
        /// Возможность редактировать поля
        /// </summary>
        public bool ReadOnly
        {
            set
            {
                if (value)
                {

                    hourlyPayEmployeeControl.ReadOnly = true;
                    salaryPayEmployeeControl.ReadOnly = true;
                }
                else
                {
                    hourlyPayEmployeeControl.ReadOnly = false;
                    salaryPayEmployeeControl.ReadOnly = false;
                }
            }
        }


        /// <summary>
        /// переключение между типами работников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem.ToString() == "By hour")
            {
                hourlyPayEmployeeControl.Enabled = true;
                hourlyPayEmployeeControl.Visible = true;
                salaryPayEmployeeControl.Visible = false;
            }
            if (comboBox.SelectedItem.ToString() == "By salary")
            {
                hourlyPayEmployeeControl.Visible = false;
                salaryPayEmployeeControl.Enabled = true;
                salaryPayEmployeeControl.Visible = true;
            }

        }
    }
}
