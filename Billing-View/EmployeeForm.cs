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
        private IEmployee getEmployee;

        public IEmployee Employee
        {
           
                get
            {
                if (radioButtonHourlyPayEmployee.Checked)
                {
                    var emplHourlyPay = new HourlyPayEmployee();
                    emplHourlyPay.Name = textBoxName.Text;
                    emplHourlyPay.Surname = textBoxSurname.Text;
                    emplHourlyPay.Age = Convert.ToInt32(textBoxAge.Text);
                    emplHourlyPay.HourCost = Convert.ToDouble(textBoxHourCost.Text);
                    emplHourlyPay.HoursWorked = Convert.ToInt32(textBoxHoursWorked.Text);
                    return emplHourlyPay;
                }
                else
                {
                    var emplPaymentOfSalary = new SalaryPayEmployee();
                    emplPaymentOfSalary.Name = textBoxName.Text;
                    emplPaymentOfSalary.Surname = textBoxSurname.Text;
                    emplPaymentOfSalary.Age = Convert.ToInt32(textBoxAge.Text);
                    emplPaymentOfSalary.DaysWorked = Convert.ToInt32(textBoxDaysWorked.Text);
                    emplPaymentOfSalary.Rate = Convert.ToDouble(textBoxRate.Text);
                    emplPaymentOfSalary.Salary = Convert.ToDouble(textBoxSalary.Text);
                    return emplPaymentOfSalary;
                }
            }

            set
            {
                if (value is HourlyPayEmployee)
                {
                    radioButtonHourlyPayEmployee.Checked = true;
                    var empl = new HourlyPayEmployee();
                    empl = (HourlyPayEmployee)value;
                    textBoxName.Text = empl.Name;
                    textBoxSurname.Text = empl.Surname;
                    textBoxAge.Text = Convert.ToString(empl.Age);
                    textBoxHoursWorked.Text = Convert.ToString(empl.HoursWorked);
                    textBoxHourCost.Text = Convert.ToString(empl.HourCost);
                }

                if (value is SalaryPayEmployee)
                {
                    radioButtonSalaryPayEmployee.Checked = true;
                    var empl = new SalaryPayEmployee();
                    empl = (SalaryPayEmployee) value;
                    textBoxName.Text = empl.Name;
                    textBoxSurname.Text = empl.Surname;
                    textBoxAge.Text = Convert.ToString(empl.Age);
                    textBoxDaysWorked.Text = Convert.ToString(empl.DaysWorked);
                    textBoxRate.Text = Convert.ToString(empl.Rate);
                    textBoxSalary.Text = Convert.ToString(empl.Salary);

                }
            }
        }

        public EmployeeForm()
        {
            InitializeComponent();
            textBoxName.Enabled = false;
            textBoxSurname.Enabled = false;
            textBoxAge.Enabled = false;
            textBoxDaysWorked.Enabled = false;
            textBoxHourCost.Enabled = false;
            textBoxHoursWorked.Enabled = false;
            textBoxRate.Enabled = false;
            textBoxSalary.Enabled = false;

            labelName.Enabled = false;
            labelSurname.Enabled = false;
            labelAge.Enabled = false;

            labelDaysWorked.Enabled = false;
            labelRate.Enabled = false;
            labelSalary.Enabled = false;
            labelHourCost.Enabled = false;
            labelHoursWorked.Enabled = false;
        }

        /// <summary>
        /// Кнопка выбора работника с почасовой оплатой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonHourlyPayEmployee_CheckedChanged(object sender, EventArgs e)
        {
            textBoxName.Enabled = true;
            textBoxSurname.Enabled = true;
            textBoxAge.Enabled = true;
            textBoxDaysWorked.Enabled = false;
            textBoxHourCost.Enabled = true;
            textBoxHoursWorked.Enabled = true;
            textBoxRate.Enabled = false;
            textBoxSalary.Enabled = false;

            labelName.Enabled = true;
            labelSurname.Enabled = true;
            labelAge.Enabled = true;

            labelHoursWorked.Enabled = true;
            labelHourCost.Enabled = true;

            labelDaysWorked.Enabled = false;
            labelRate.Enabled = false;
            labelSalary.Enabled = false;
        }

        /// <summary>
        /// Кнопка выбора работника с начислением ЗП по окладу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonSalaryPayEmployee_CheckedChanged(object sender, EventArgs e)
        {
            textBoxName.Enabled = true;
            textBoxSurname.Enabled = true;
            textBoxAge.Enabled = true;
            textBoxDaysWorked.Enabled = true;
            textBoxHourCost.Enabled = false;
            textBoxHoursWorked.Enabled = false;
            textBoxRate.Enabled = true;
            textBoxSalary.Enabled = true;

            labelName.Enabled = true;
            labelSurname.Enabled = true;
            labelAge.Enabled = true;

            labelDaysWorked.Enabled = true;
            labelRate.Enabled = true;
            labelSalary.Enabled = true;

            labelHourCost.Enabled = false;
            labelHoursWorked.Enabled = false;
        }

        /// <summary>
        /// Кнопка ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
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

        
    }
}
