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
    //TODO: стоит создать в проекте подпапку EmployeeControls и переместить все контролы туда.
    public partial class EmployeeControl : UserControl
    {
        public EmployeeControl()
        {
            InitializeComponent();
            //TODO: большинство свойств лучше задать через дизайнер, а не программно.
            hourlyPayEmployeeControl.Enabled = false;
            salaryPayEmployeeControl.Enabled = false;
            comboBox.SelectedIndex = 0;
            label2.Visible = true;
            label1.Visible = false;
            comboBox.Visible = false;
            label2.Text = "";
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
                    
                    return hourlyPayEmployeeControl.HourlyPayEmployee;
                } //TODO: если под условием стоит оператор return, то else дальше писать не надо.
                else if (comboBox.SelectedIndex == 1)
                {
                    
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
                    //TODO: следующие три строки не нужны, 
                    // так как они прописаны в обработчике combobox_SelectedIndexChanged
                    hourlyPayEmployeeControl.Visible = true;
                    hourlyPayEmployeeControl.Enabled = true;
                    salaryPayEmployeeControl.Visible = false;
                    //TODO: эту строку лучше перенести в обработчик комбобокса
                    label2.Text = "Type of payment: hourly";
                }
                if (value is SalaryPayEmployee)
                {
                    salaryPayEmployeeControl.SalaryPayEmployee = (SalaryPayEmployee)value;
                    comboBox.SelectedIndex = 1;
                    //TODO: следующие три строки не нужны,
                    // так как они прописаны в обработчике combobox_SelectedIndexChanged
                    salaryPayEmployeeControl.Visible = true;
                    salaryPayEmployeeControl.Enabled = true;
                    hourlyPayEmployeeControl.Visible = false;
                    //TODO: эту строку лучше перенести в обработчик комбобокса
                    label2.Text = "Type of payment: salary";
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
                //TODO: избавиться от дублирования
                if (value)
                {
                    hourlyPayEmployeeControl.ReadOnly = true;
                    salaryPayEmployeeControl.ReadOnly = true;
                    label2.Visible = true;
                    label1.Visible = false;
                    comboBox.Visible = false;
                }
                else
                {
                    hourlyPayEmployeeControl.ReadOnly = false;
                    salaryPayEmployeeControl.ReadOnly = false;
                    label2.Visible = false;
                    label1.Visible = true;
                    comboBox.Visible = true;
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
            //TODO: лучше обращаться единообразно. Если выше работаешь по индексам,
            // то и здесь по индексам
            if (comboBox.SelectedItem.ToString() == "By hour")
            {
                //TODO: зачем менять Enabled, если ты дальше меняешь его видимость?
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

