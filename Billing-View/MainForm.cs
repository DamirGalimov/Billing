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
        private List<IEmployee> Employee;
        

        public MainForm()
        {
            InitializeComponent();
            Employee = new List<IEmployee>();
            iEmployeeBindingSource.DataSource = Employee;
#if !DEBUG
            OpenTestButton.Visible = false;
            AutoCreatebutton.Visible = false;
            SaveTestButton.Visible = false;
#endif
        }

        /// <summary>
        /// Метод для создания формы с сохранением
        /// </summary>
        /// <param name="empl"></param>
        private void CreateSaveForm(List<IEmployee> empl)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "txt files (*.dat)|*.dat";
            ofd.RestoreDirectory = true;
            if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
            {
                Serialization.Serialize(ofd.FileName, empl);
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
            }
        }

        /// <summary>
        /// Удаление объектов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveEmpl_Click(object sender, EventArgs e)
        {
            if (iEmployeeBindingSource.DataSource != null)
            {
                iEmployeeBindingSource.RemoveCurrent();
            }
            else
            {
                MessageBox.Show("Ошибка. Файл не может быть пустым");
            }
        }

        /// <summary>
        /// Тестовая кнопка открыть
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenTestButton_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("testD.dat", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                List<IEmployee> empltest = (List<IEmployee>)formatter.Deserialize(fs);
                iEmployeeBindingSource.DataSource = empltest;
            }
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
            using (FileStream fs = new FileStream("Test.dat", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, Employee);
            }
        }

        /// <summary>
        /// Открытие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
            {
                try
                {
                    Employee = Serialization.Deserialize(ofd.FileName);
                    iEmployeeBindingSource.DataSource = Employee;
                }
                catch (SerializationException)
                {
                    MessageBox.Show("Error ");
                }
            }

        }

        /// <summary>
        /// Сохранение из меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Employee.Count != 0)
            {
                CreateSaveForm(Employee);
            }
            else
            {
                MessageBox.Show("Ошибка. Файл не может быть пустым");
            }
        }

        /// <summary>
        /// закрытие всей программы через крестик
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (iEmployeeBindingSource.DataSource != null)
            {
                DialogResult dialogResult = MessageBox.Show("Save changes?", "Warning", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.OK)
                {
                    CreateSaveForm(Employee);
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
            }
            else
            {
                MessageBox.Show("Ошибка. Файл не может быть пустым");
            }
        }

        /// <summary>
        /// Закрытие файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iEmployeeBindingSource.DataSource != null)
            {
                DialogResult dialogResult = MessageBox.Show("Save changes?", "Warning", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.OK)
                {
                    CreateSaveForm(Employee);
                    iEmployeeBindingSource.Clear();
                }
                else
                {
                    iEmployeeBindingSource.Clear();
                }
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
            iEmployeeBindingSource.RemoveAt(index);
            var empl = form.Employee;
            iEmployeeBindingSource.Insert(index, empl);
        }

        /// <summary>
        /// Закрытие через меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Employee.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Save changes?", "Warning", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.OK)
                {
                    CreateSaveForm(Employee);
                }
            }
            Close();
        }

        /// <summary>
        /// Поиск работника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formSeacrh = new SearchForm(Employee);
            formSeacrh.ShowDialog();
        }

       
    }
}
