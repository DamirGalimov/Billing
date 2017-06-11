using System;
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
    //TODO: все контролы стоит переместить в подпапку.
    //TODO: в текстбоксы с часами и стоимостью можно вводить символы. 
    // Сделать обработку таким образом, чтобы вводились только цифры
    public partial class SalaryPayEmployeeControl : UserControl
    {
        public SalaryPayEmployeeControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает или принимает объект типа SalaryPayEmployee
        /// </summary>
        [DefaultValue(null)]
        public SalaryPayEmployee SalaryPayEmployee
        {
            get
            {
                if (textBoxName.Text == string.Empty)
                    return null;
                return new SalaryPayEmployee
                {
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Age = ConvertCheck.ConvertToInt(textBoxAge.Text, "Age"),
                    DaysWorked = ConvertCheck.ConvertToInt(textBoxDaysWorked.Text, "Days worked"),
                    Rate = ConvertCheck.ConvertToDouble(textBoxRate.Text, "Rate"),
                    Salary = ConvertCheck.ConvertToDouble(textBoxSalary.Text, "Salary")
                };
            }
            set
            {
                //TODO: условие лучше инвертировать
                if (value != null)
                {
                    //TODO: неправильное имя локальной переменной
                    var empl = value;
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
        /// Возможность редактировать поля
        /// </summary>
        public bool ReadOnly
        {
            set
            {
                //TODO: посмотри на ветвление внимательно. Разве нельзя избавиться от дублирования?
                if (value)
                {
                    textBoxName.ReadOnly = true;
                    textBoxSurname.ReadOnly = true;
                    textBoxAge.ReadOnly = true;
                    textBoxDaysWorked.ReadOnly = true;
                    textBoxRate.ReadOnly = true;
                    textBoxSalary.ReadOnly = true;
                }
                else
                {
                    textBoxName.ReadOnly = false;
                    textBoxSurname.ReadOnly = false;
                    textBoxAge.ReadOnly = false;
                    textBoxDaysWorked.ReadOnly = false;
                    textBoxRate.ReadOnly = false;
                    textBoxSalary.ReadOnly = false;
                }
            }
        }

        //TODO: переименовать метод. Метод назван как класс - от существительного
        /// <summary>
        /// Метод для выведения подсказок
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="message"></param>
        private void ErrorProvider(TextBox textBox, string message)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, message);
            }
            else
            {
                errorProvider.SetError(textBox, null);
            }
        }

        /// <summary>
        /// Подсказка для имени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0)
            {
                MessageBox.Show("Name must contain only letters");
            }
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
    }
}
