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
        private bool _change = false;
        private BillingProject _billingProject;
        private string[] args;
        
        /// <summary>
        /// Конструктор
        /// </summary>
        public MainForm(string[] args)
        {
            InitializeComponent();
            EnableMainForm(false);
            employeeControl1.ReadOnly = true;
            _billingProject = new BillingProject();
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
                iEmployeeBindingSource.DataSource = _billingProject.Employees;
                //_fileName = _billingProject.Filename;
                EnableMainForm(true);
                IsDataChange(false);
                _change = false;
            }
            
        }

        /// <summary>
        /// Анктивация кнопок
        /// </summary>
        /// <param name="flag"></param>
        private void EnableMainForm(bool flag)
        {
            groupBoxEmployees.Enabled = flag;
            groupBoxSearch.Enabled = flag;
            billingGridView.Enabled = flag;
            groupBoxEmployees.Enabled = flag;
            buttonAddEmpl.Enabled = flag;
            buttonRemoveEmployee.Enabled = flag;
            buttonSearch.Enabled = flag;
            buttonReturnList.Enabled = flag;
            buttonAutoCreate.Enabled = flag;
            
            buttonSaveTest.Enabled = flag;
            addEmployeeToolStripMenuItem.Enabled = flag;
            removeEmployeeToolStripMenuItem.Enabled = flag;
            modifyEmployeeToolStripMenuItem.Enabled = flag;
        }

        /// <summary>
        ///Изменения заголовка файла
        /// </summary>
        private void IsDataChange(bool check)
        {
            if (check)
            {
                this.Text = _billingProject.Filename.Substring(_billingProject.Filename.LastIndexOf("\\") + 1) + "* - KLaboratory";
                _change = true;
            }
            else
            {
                if (_billingProject.Filename != null)
                {
                    this.Text = _billingProject.Filename.Substring(_billingProject.Filename.LastIndexOf("\\") + 1) + " - KLabaratory";
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
            iEmployeeBindingSource.DataSource = _billingProject.Employees;
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
        /// Открытие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _billingProject = SerializeElement.OpenDeserialize();
            if (_billingProject != null)
            {
                iEmployeeBindingSource.DataSource = _billingProject.Employees;
                EnableMainForm(true);
                IsDataChange(false);
            }
        }

        /// <summary>
        /// Сохраненить как, из меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Место с ошибкой
            if (iEmployeeBindingSource.Count != 0)
            {
               bool a = SerializeElement.SaveSerialize(_billingProject);
                if (a)
                {
                    //_fileName = _billingProject.Filename;
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
                _billingProject.Filename = null;
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
                        iEmployeeBindingSource.DataSource = _billingProject.Employees.FindAll(delegate (IEmployee empl)
                        {
                            return empl.Name == text;
                        });
                        break;
                    }
                case "Surname":
                    iEmployeeBindingSource.DataSource = _billingProject.Employees.FindAll(delegate (IEmployee empl)
                    {
                        return empl.Surname == text;
                    });
                    break;
                case "Age":
                    {
                        int age = Convert.ToInt32(textBoxSearch.Text);
                        iEmployeeBindingSource.DataSource = _billingProject.Employees.FindAll(delegate (IEmployee empl)
                        {
                            return empl.Age == age;
                        });
                        break;
                    }
                case "Payment type":
                    {
                        iEmployeeBindingSource.DataSource = _billingProject.Employees.FindAll(delegate (IEmployee empl)
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
            iEmployeeBindingSource.DataSource = _billingProject.Employees;
        }

        /// <summary>
        /// Создание файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SerializeElement.SaveSerialize(_billingProject);
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
                Serializer.Serialize(_billingProject, _billingProject.Filename);
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

