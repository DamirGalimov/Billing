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
        /// Конструктор. Активность и неактивность кнопок
        /// </summary>
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
        /// Создание или изменение работника
        /// </summary>
        public IEmployee Employee
        {

            get
            {
                if (radioButtonHourlyPayEmployee.Checked)
                {
                    return new HourlyPayEmployee
                    {
                        Name = textBoxName.Text,
                        Surname = textBoxSurname.Text,
                        Age = Convert.ToInt32(textBoxAge.Text),
                        HourCost = Convert.ToDouble(textBoxHourCost.Text),
                        HoursWorked = Convert.ToInt32(textBoxHoursWorked.Text)
                    }; 
                }
                else
                {
                    return new SalaryPayEmployee
                    {
                        Name = textBoxName.Text,
                        Surname = textBoxSurname.Text,
                        Age = Convert.ToInt32(textBoxAge.Text),
                        DaysWorked = Convert.ToInt32(textBoxDaysWorked.Text),
                        Rate = Convert.ToDouble(textBoxRate.Text),
                        Salary = Convert.ToDouble(textBoxSalary.Text)
                    }; 
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


        /// <summary>
        /// Кнопка выбора работника с почасовой оплатой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonHourlyPayEmployee_CheckedChanged(object sender, EventArgs e)
        {
            //Текстбоксы почасовой оплаты
            textBoxName.Visible = true;
            textBoxSurname.Visible = true;
            textBoxAge.Visible = true;
            textBoxHourCost.Visible = true;
            textBoxHoursWorked.Visible = true;

            textBoxName.Enabled = true;
            textBoxSurname.Enabled = true;
            textBoxAge.Enabled = true;
            textBoxHourCost.Enabled = true;
            textBoxHoursWorked.Enabled = true;

            //Текстбоксы оплаты по ставке
            textBoxRate.Visible = false;
            textBoxSalary.Visible = false;
            textBoxDaysWorked.Visible = false;

            //Лейблы почасовой оплаты
            labelName.Visible = true;
            labelSurname.Visible = true;
            labelAge.Visible = true;
            labelHoursWorked.Visible = true;
            labelHourCost.Visible = true;

            labelName.Enabled = true;
            labelSurname.Enabled = true;
            labelAge.Enabled = true;
            labelHoursWorked.Enabled = true;
            labelHourCost.Enabled = true;

            //Лейблы оплаты по окладу
            labelDaysWorked.Visible = false;
            labelRate.Visible = false;
            labelSalary.Visible = false;

            textBoxHourCost.Location = textBoxSalary.Location;
            textBoxHoursWorked.Location = textBoxDaysWorked.Location;
            labelHourCost.Location = labelSalary.Location;
            labelHoursWorked.Location = labelDaysWorked.Location;

        }

        /// <summary>
        /// Кнопка выбора работника с начислением ЗП по окладу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonSalaryPayEmployee_CheckedChanged(object sender, EventArgs e)
        {
            //Текстбоксы оплаты по окладу
            textBoxName.Visible = true;
            textBoxSurname.Visible = true;
            textBoxAge.Visible = true;
            textBoxDaysWorked.Visible = true;
            textBoxRate.Visible = true;
            textBoxSalary.Visible = true;

            textBoxName.Enabled = true;
            textBoxSurname.Enabled = true;
            textBoxAge.Enabled = true;
            textBoxDaysWorked.Enabled= true;
            textBoxRate.Enabled = true;
            textBoxSalary.Enabled = true;

            //Текстбоксы почасовой оплаты
            textBoxHourCost.Visible = false;
            textBoxHoursWorked.Visible = false;
            
            //Лейблы оплаты по окладу
            labelName.Enabled = true;
            labelSurname.Enabled = true;
            labelAge.Enabled = true;
            labelDaysWorked.Enabled = true;
            labelRate.Enabled = true;
            labelSalary.Enabled = true;


            labelDaysWorked.Visible = true;
            labelRate.Visible = true;
            labelSalary.Visible = true;

            //Лейблы почасовой оплаты
            labelHourCost.Visible = false;
            labelHoursWorked.Visible = false;
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
                var employee = Employee;
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message, "Предупреждение",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
