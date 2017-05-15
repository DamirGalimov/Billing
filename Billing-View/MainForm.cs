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
        private List<IEmployee> _employees;
        private bool _change = false;
        private string _fileName;
        private BillingProject _billingProject;
        public string[] args;
        
        /// <summary>
        /// Конструктор
        /// </summary>
        public MainForm(string[] args)
        {
            
            InitializeComponent();
            EnableMainForm(false);
            iEmployeeBindingSource.DataSource = _employees = new List<IEmployee>();
            employeeControl1.ReadOnly = true;
            _billingProject = new BillingProject();
            _billingProject.Employees = _employees;
            _billingProject.Filename = string.Empty;
            buttonOpenTest.Enabled = true;
#if !DEBUG
            buttonSaveTest.Visible = false;
            buttonOpenTest.Visible = false;
            buttonAutoCreate.Visible = false;
#endif
            if (args.Length > 0)
            {
                try
                {
                    _billingProject = Serializer.Deserialize(args[0]);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Invalid file extension!");
                }
                iEmployeeBindingSource.DataSource = _employees = _billingProject.Employees;
                _fileName = _billingProject.Filename;
                EnableMainForm(true);
                IsDataChange(false);
                _change = false;
            }
            
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
            _billingProject = SerializeElement.OpenDeserialize();
            iEmployeeBindingSource.DataSource = _employees = _billingProject.Employees;
            _fileName = _billingProject.Filename;
            EnableMainForm(true);
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
            //Serializer.SaveSerialize("testD.dat", Employees);
        }

        /// <summary>
        /// Открытие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _billingProject = SerializeElement.OpenDeserialize();
            if (_billingProject != null)
            {
                iEmployeeBindingSource.DataSource = _employees = _billingProject.Employees;
                _fileName = _billingProject.Filename;
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
               bool a = SerializeElement.SaveSerialize(_billingProject);
                if (a)
                {
                    _fileName = _billingProject.Filename;
                }
                IsDataChange(a);
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
                    SerializeElement.SaveSerialize(_billingProject);
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
                    SerializeElement.SaveSerialize(_billingProject);
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
                    SerializeElement.SaveSerialize(_billingProject);
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
                        iEmployeeBindingSource.DataSource = _employees.FindAll(delegate (IEmployee empl)
                        {
                            return empl.Name == text;
                        });
                        break;
                    }
                case "Surname":
                    iEmployeeBindingSource.DataSource = _employees.FindAll(delegate (IEmployee empl)
                    {
                        return empl.Surname == text;
                    });
                    break;
                case "Age":
                    {
                        int age = Convert.ToInt32(textBoxSearch.Text);
                        iEmployeeBindingSource.DataSource = _employees.FindAll(delegate (IEmployee empl)
                        {
                            return empl.Age == age;
                        });
                        break;
                    }
                case "Payment type":
                    {
                        iEmployeeBindingSource.DataSource = _employees.FindAll(delegate (IEmployee empl)
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
            iEmployeeBindingSource.DataSource = _employees;
        }

        /// <summary>
        /// Создание файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SerializeElement.SaveSerialize(_billingProject);
            _fileName = _billingProject.Filename;
            EnableMainForm(true);
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
                Serializer.Serialize(_billingProject, _fileName);
                IsDataChange(false);
            }
            else
            {
                MessageBox.Show("Error. Empty file");
            }
        }

        /// <summary>
        /// Информация о работнике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void billingGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            employeeControl1.Employee = (IEmployee)iEmployeeBindingSource.Current;
        }
    }

}

