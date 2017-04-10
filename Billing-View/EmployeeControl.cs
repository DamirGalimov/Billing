﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billing;

namespace Billing_View
{
    public partial class EmployeeControl : UserControl
    {
        public EmployeeControl()
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
        /// Возвращает или задает работника
        /// </summary>
        public IEmployee Employee
        {
            set
            {
                if (value is HourlyPayEmployee)
                {
                    comboBox.SelectedItem = "By Hour";
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
                    comboBox.SelectedItem = "By salary";
                    var empl = new SalaryPayEmployee();
                    empl = (SalaryPayEmployee)value;
                    textBoxName.Text = empl.Name;
                    textBoxSurname.Text = empl.Surname;
                    textBoxAge.Text = Convert.ToString(empl.Age);
                    textBoxDaysWorked.Text = Convert.ToString(empl.DaysWorked);
                    textBoxRate.Text = Convert.ToString(empl.Rate);
                    textBoxSalary.Text = Convert.ToString(empl.Salary);
                }
            }
            get
            {
                if (comboBox.SelectedItem.ToString() == "By hour")
                {
                   
                    return new HourlyPayEmployee
                    {
                        Name = textBoxName.Text,
                        Surname = textBoxSurname.Text,
                        Age = ConvertToInt(textBoxAge.Text, "Age"),
                        HourCost = ConvertToDouble(textBoxHourCost.Text, "Hour cost"),
                        HoursWorked = ConvertToInt(textBoxHoursWorked.Text, "Hours worked")
                    };
                }
                else
                {
                    return new SalaryPayEmployee
                    {
                        Name = textBoxName.Text,
                        Surname = textBoxSurname.Text,
                        Age = ConvertToInt(textBoxAge.Text, "Age"),
                        DaysWorked = ConvertToInt(textBoxDaysWorked.Text, "Days worked"),
                        Rate = ConvertToDouble(textBoxRate.Text, "Rate"),
                        Salary = ConvertToDouble(textBoxSalary.Text, "Salary")
                    };
                    
                }
            }
        }

        /// <summary>
        /// Возможность редактировать поля
        /// </summary>
        public bool ReadOnly
        {
            set; get;
        }

        private int ConvertToInt(string text, string FileName)
        {
            int view;
            try
            {
                view = Convert.ToInt32(text);
            }
            catch (FormatException)
            {
                throw new FormatException("Field '" + FileName + "' must contain only digits.");
            }
            return view;
        }

        private double ConvertToDouble(string text, string FileName)
        {
            double view;
            try
            {
                view = Convert.ToDouble(text);
            }
            catch (FormatException)
            {
                throw new FormatException("Field '" + FileName + "' must contain only digits.");
            }
            return view;
        }

        private void SalaryPayEmployeeChecked()
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
            textBoxDaysWorked.Enabled = true;
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

        private void HourlyPayEmployeeChecked()
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

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem.ToString() == "By hour")
            {
                HourlyPayEmployeeChecked();
            }
            if (comboBox.SelectedItem.ToString() == "By salary")
            {
                SalaryPayEmployeeChecked();
            }
        }

        /// <summary>
        /// Метод для выведения подсказок
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="message"></param>
        private void ErrorProvider(TextBox textBox, string message)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProviderC.SetError(textBox, message);

            }
            else
            {
                errorProviderC.SetError(textBox, null);

            }
        }


        /// <summary>
        /// Подсказка для имени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxName_Leave(object sender, EventArgs e)
        {
            ErrorProvider(textBoxName, "Name must contain only letters");
        }

        /// <summary>
        /// Подсказка для фамилии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSurname_Leave(object sender, EventArgs e)
        {
            ErrorProvider(textBoxSurname, "Surname must contain only letters.");
        }

        /// <summary>
        /// подсказка для возраста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAge_Leave(object sender, EventArgs e)
        {
            ErrorProvider(textBoxAge, "Age not less han 14 no more than 150.");
        }

        /// <summary>
        /// подсказка для оклада
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSalary_Leave(object sender, EventArgs e)
        {
            ErrorProvider(textBoxSalary, "Salary not less than 10000.");
        }


        /// <summary>
        /// Подсказка для отработанных дней
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxDaysWorked_Leave(object sender, EventArgs e)
        {
            ErrorProvider(textBoxDaysWorked, "Amount of days worked is not less than 0 and not more than 31.");
        }

        /// <summary>
        /// Подсказка для ставки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxRate_Leave(object sender, EventArgs e)
        {
            ErrorProvider(textBoxRate, "Amount of the bet is not less than 0 and not more than 1.");
        }

        /// <summary>
        /// Подсказка для стоимости часа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxHourCost_Leave(object sender, EventArgs e)
        {
            ErrorProvider(textBoxHourCost, "Cost of an hour is not less than 100.");
        }

        /// <summary>
        /// Подсказка для суммы отработанных часов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxHoursWorked_Leave(object sender, EventArgs e)
        {
            ErrorProvider(textBoxHoursWorked, "Enter the number of hours worked");
        }

       
    }

}
