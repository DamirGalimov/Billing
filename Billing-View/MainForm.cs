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
        private string fileName;
        /// <summary>
        /// Конструктор
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            EnableMainForm(false);
            Employees = new List<IEmployee>();
            iEmployeeBindingSource.DataSource = Employees;

#if !DEBUG
            OpenTestButton.Visible = false;
            AutoCreatebutton.Visible = false;
            SaveTestButton.Visible = false;
#endif
        }

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
        }

        /// <summary>
        ///Фиксация изменений
        /// </summary>
        private void Change(bool check)
        {
            if (check)
            {
                this.Text = fileName.Substring(fileName.LastIndexOf("\\")+1) + "* - KLaboratory";
            }
            else
            {
                if (fileName != null)
                {
                    this.Text = fileName.Substring(fileName.LastIndexOf("\\") + 1) + " - KLabaratory";
                }
                else
                {
                    this.Text = "Employees Manager - KLaboratory";
                }
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
                fileName = dialog.FileName;
                EnableMainForm(true);
            }
            Change(false);
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
                Change(true);
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
                Change(true);
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
                    iEmployeeBindingSource.DataSource = Serializer.Deserialize(dialog.FileName);
                }
                catch (SerializationException)
                {
                    MessageBox.Show("Error. Empty file");
                }
                fileName = dialog.FileName;
                EnableMainForm(true);
                Change(false);
            }
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
                Change(true);
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
                Change(true);
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
                fileName = null;
                EnableMainForm(false);
                Change(false);
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

            form.ShowDialog();
            if (form.ShowDialog() == DialogResult.OK)
            {
                iEmployeeBindingSource.RemoveAt(index);
                var empl = form.Employee;
                iEmployeeBindingSource.Insert(index, empl);
                Change(true);
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
            Change(false);
        }
    }


}

