using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using Billing;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.Serialization;

namespace Billing_View
{
    public partial class MainForm : Form
    {
        private List<IEmployee> Employees;
        private bool _change = false;
        private string _fileName;
        
        /// <summary>
        /// Конструктор
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            EnableMainForm(false);
            iEmployeeBindingSource.DataSource = Employees = new List<IEmployee>();

#if !DEBUG
            OpenTestButton.Visible = false;
            AutoCreatebutton.Visible = false;
            SaveTestButton.Visible = false;
#endif
        }

        /// <summary>
        /// Анктивация кнопок
        /// </summary>
        /// <param name="var"></param>
        private void EnableMainForm(bool var)
        {
            groupBoxEmployees.Enabled = var;
            groupBoxSearch.Enabled = var;
            billingGridView.Enabled = var;
            groupBoxEmployees.Enabled = var;
            buttonAddEmpl.Enabled = var;
            buttonRemoveEmployee.Enabled = var;
            buttonSearch.Enabled = var;
            buttonReturnList.Enabled = var;
            buttonAutoCreate.Enabled = var;
            buttonOpenTest.Enabled = var;
            buttonSaveTest.Enabled = var;
            addEmployeeToolStripMenuItem.Enabled = var;
            removeEmployeeToolStripMenuItem.Enabled = var;
            modifyEmployeeToolStripMenuItem.Enabled = var;
        }

        /// <summary>
        ///Изменения заголовка файла
        /// </summary>
        private void IsDataChange(bool check)
        {
            if (check)
            {
                this.Text = _fileName.Substring(_fileName.LastIndexOf("\\") + 1) + "* - KLaboratory";
                _change = true;
            }
            else
            {
                if (_fileName != null)
                {
                    this.Text = _fileName.Substring(_fileName.LastIndexOf("\\") + 1) + " - KLabaratory";
                }
                else
                {
                    this.Text = "Employees Manager - KLaboratory";
                }
                _change = false;
            }
        }

        /// <summary>
        /// Метод для создания формы с сохранением
        /// </summary>
        /// <param name="empl"></param>
        private void CreateSaveForm(List<IEmployee> empl)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "txt files (*.dat)|*.dat";
            dialog.RestoreDirectory = true;
            if (!(dialog.FileName == null || dialog.ShowDialog() == DialogResult.Cancel))
            {
                Serializer.Serialize(dialog.FileName, empl);
                _fileName = dialog.FileName;
                EnableMainForm(true);
            }
            IsDataChange(false);
        }

        /// <summary>
        /// Добавление объекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddEmpl_Click(object sender, EventArgs e)
        {
            var addForm = new EmployeeForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                iEmployeeBindingSource.Add(addForm.Employee);
                IsDataChange(true);
                _change = true;
            }
        }

        /// <summary>
        /// Удаление объектов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveEmpl_Click(object sender, EventArgs e)
        {
            if (iEmployeeBindingSource.Count != 0)
            {
                iEmployeeBindingSource.RemoveCurrent();
                IsDataChange(true);
                _change = true;
            }
            else
            {
                MessageBox.Show("Error. File can not be empty");
            }
        }

        /// <summary>
        /// Тестовая кнопка открыть
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenTestButton_Click(object sender, EventArgs e)
        {
            iEmployeeBindingSource.DataSource = Serializer.Deserialize("test2.dat");

        }

        /// <summary>
        /// Создание объектов по нажатию кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoCreatebutton_Click(object sender, EventArgs e)
        {
            iEmployeeBindingSource.Add(new SalaryPayEmployee("Artur", "Kun", 20, 30000, 20, 1));
            iEmployeeBindingSource.Add(new HourlyPayEmployee("Ivan", "Viderhspan", 20, 120, 130));
            IsDataChange(true);
        }

        /// <summary>
        /// Кнопка для тестового сохранения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveTestButton_Click(object sender, EventArgs e)
        {
            Serializer.Serialize("testD.dat", Employees);
        }

        /// <summary>
        /// Открытие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files (*.dat)|*.dat";
            if (!(dialog.FileName == null || dialog.ShowDialog() == DialogResult.Cancel))
            {
                try
                {
                    iEmployeeBindingSource.DataSource = Employees = Serializer.Deserialize(dialog.FileName);
                }
                catch (SerializationException)
                {
                    MessageBox.Show("Error. Empty file");
                }
                _fileName = dialog.FileName;
                EnableMainForm(true);
                IsDataChange(false);
                _change = false;
            }
        }

        /// <summary>
        /// Сохраненить как, из меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iEmployeeBindingSource.Count != 0)
            {
                CreateSaveForm(Employees);
            }
            else
            {
                MessageBox.Show("Error. Empty file");
            }
        }

        /// <summary>
        /// закрытие всей программы через крестик
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (iEmployeeBindingSource.Count != 0 && _change != false)
            {
                DialogResult dialogResult = MessageBox.Show("Save changes?", "Warning", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {
                    CreateSaveForm(Employees);
                }
                if (dialogResult == DialogResult.No)
                {
                }
                if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
        }

        /// <summary>
        /// Добавление работника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = new EmployeeForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                iEmployeeBindingSource.Add(addForm.Employee);
                IsDataChange(true);
            }
        }

        /// <summary>
        /// Удаление работника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iEmployeeBindingSource.DataSource != null)
            {
                iEmployeeBindingSource.RemoveCurrent();
                IsDataChange(true);
            }
            else
            {
                MessageBox.Show("Error. Empty file");
            }
        }

        /// <summary>
        /// Закрытие файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iEmployeeBindingSource.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Save changes?", "Warning", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {
                    CreateSaveForm(Employees);
                    iEmployeeBindingSource.Clear();
                }
                if (dialogResult == DialogResult.No)
                {
                    iEmployeeBindingSource.Clear();
                }
                _fileName = null;
                EnableMainForm(false);
                IsDataChange(false);
            }
            else
            {
                MessageBox.Show("Error. Empty file");
            }

        }

        /// <summary>
        /// Изменение работника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifyEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EmployeeForm();
            int index = iEmployeeBindingSource.IndexOf(iEmployeeBindingSource.Current);
            form.Employee = (IEmployee)iEmployeeBindingSource.Current;
            if (form.ShowDialog() == DialogResult.OK)
            {
                iEmployeeBindingSource.RemoveAt(index);
                var empl = form.Employee;
                iEmployeeBindingSource.Insert(index, empl);
                IsDataChange(true);
                _change = true;
            }

        }

        /// <summary>
        /// Закрытие через меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iEmployeeBindingSource.DataSource != null)
            {
                DialogResult dialogResult = MessageBox.Show("Save changes?", "Warning", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.OK)
                {
                    CreateSaveForm(Employees);
                }
            }
            Close();
        }

        /// <summary>
        /// Поиск работника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string text = textBoxSearch.Text;
            string criterion = Convert.ToString(comboBoxSearch.SelectedItem);
            switch (criterion)
            {
                case "Name":
                    {
                        iEmployeeBindingSource.DataSource = Employees.FindAll(delegate (IEmployee empl)
                        {
                            return empl.Name == text;
                        });
                        break;
                    }
                case "Surname":
                    iEmployeeBindingSource.DataSource = Employees.FindAll(delegate (IEmployee empl)
                    {
                        return empl.Surname == text;
                    });
                    break;
                case "Age":
                    {
                        int age = Convert.ToInt32(textBoxSearch.Text);
                        iEmployeeBindingSource.DataSource = Employees.FindAll(delegate (IEmployee empl)
                        {
                            return empl.Age == age;
                        });
                        break;
                    }
                case "Payment type":
                    {
                        iEmployeeBindingSource.DataSource = Employees.FindAll(delegate (IEmployee empl)
                        {
                            PaymentType pt = ConvertPaymentType.ToPaymentType(text);
                            return empl.PaymentType == pt;
                        });
                        break;
                    }
            }
        }

        /// <summary>
        /// Вернуть список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReturnList_Click(object sender, EventArgs e)
        {
            iEmployeeBindingSource.DataSource = Employees;
        }

        /// <summary>
        /// Создание файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CreateSaveForm(Employees);
            IsDataChange(false);
        }

        /// <summary>
        /// Сохранение из меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iEmployeeBindingSource.Count != 0)
            {
                Serializer.Serialize(_fileName, Employees);
                IsDataChange(false);
            }
            else
            {
                MessageBox.Show("Error. Empty file");
            }
        }

        


        /// <summary>
        /// Панель с информацией о работнике
        /// </summary>
        /// <param name="employee"></param>
        private void EmployeeInformation(IEmployee employee)
        {
            if (employee is SalaryPayEmployee)
            {
               var empl =  new SalaryPayEmployee();
                empl = (SalaryPayEmployee) employee;
                textBoxName.Text = empl.Name;
                textBoxSurname.Text = empl.Surname;
                textBoxAge.Text = empl.Age.ToString();
                textBoxPaymentType.Text = ConvertPaymentType.ToStringPayment(empl.PaymentType);
                textBoxSalary.Text = empl.Salary.ToString();
                textBoxDaysWorked.Text = empl.DaysWorked.ToString();
                textBoxRate.Text = empl.Rate.ToString();
                textBoxWages.Text = empl.Wages.ToString();

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
            else
            {
                var empl = new HourlyPayEmployee();
                empl = (HourlyPayEmployee) employee;
                textBoxName.Text = empl.Name;
                textBoxSurname.Text = empl.Surname;
                textBoxAge.Text = empl.Age.ToString();
                textBoxPaymentType.Text = ConvertPaymentType.ToStringPayment(empl.PaymentType);
                textBoxHourCost.Text = empl.HourCost.ToString();
                textBoxHoursWorked.Text = empl.HoursWorked.ToString();
                textBoxWages.Text = empl.Wages.ToString();

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

                //Положения лейблов и текстбоксов
                textBoxHourCost.Location = textBoxSalary.Location;
                textBoxHoursWorked.Location = textBoxDaysWorked.Location;
                labelHourCost.Location = labelSalary.Location;
                labelHoursWorked.Location = labelDaysWorked.Location;

            }
        }

        private void billingGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
                EmployeeInformation((IEmployee)iEmployeeBindingSource.Current);
        }
    }


}

