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
    public partial class HourlyPayEmployeeControl : UserControl
    {
        public HourlyPayEmployeeControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает или принимает объект типа HourlyPayEmployee
        /// </summary>
        [DefaultValue(null)]
        public HourlyPayEmployee HourlyPayEmployee
        {
            get
            {
                if (textBoxName.Text == string.Empty)
                    return null;

                try
                {
                    return new HourlyPayEmployee
                    {
                        Name = textBoxName.Text,
                        Surname = textBoxSurname.Text,
                        Age = ConvertCheck.ConvertToInt(textBoxAge.Text, "Age"),
                        HourCost = ConvertCheck.ConvertToDouble(textBoxHourCost.Text, "Hour cost"),
                        HoursWorked = ConvertCheck.ConvertToInt(textBoxHoursWorked.Text, "Hours worked")
                    };
                }
                catch (Exception )
                {
                    throw new Exception("");
                }
            }
            set
            {
                if (value != null)
                {
                    var empl = value;
                    textBoxName.Text = empl.Name;
                    textBoxSurname.Text = empl.Surname;
                    textBoxAge.Text = Convert.ToString(empl.Age);
                    textBoxHoursWorked.Text = Convert.ToString(empl.HoursWorked);
                    textBoxHourCost.Text = Convert.ToString(empl.HourCost);
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
                    textBoxName.ReadOnly = true;
                    textBoxSurname.ReadOnly = true;
                    textBoxAge.ReadOnly = true;
                    textBoxHourCost.ReadOnly = true;
                    textBoxHoursWorked.ReadOnly = true;
                }
                else
                {
                    textBoxName.ReadOnly = false;
                    textBoxSurname.ReadOnly = false;
                    textBoxAge.ReadOnly = false;
                    textBoxHourCost.ReadOnly = false;
                    textBoxHoursWorked.ReadOnly = false;
                }
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
