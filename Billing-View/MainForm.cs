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

namespace Billing_View
{
    public partial class MainForm : Form
    {
        public List<IEmployee> Employee;
        BinaryFormatter formatter = new BinaryFormatter();

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
            iEmployeeBindingSource.RemoveCurrent();
        }


        /// <summary>
        /// Тестовая кнопка открыть
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenTestButton_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("Test.txt", FileMode.OpenOrCreate))
            {
                List<IEmployee> empltest = (List<IEmployee>) formatter.Deserialize(fs);
                iEmployeeBindingSource.DataSource = empltest;
            }
        }

        /// <summary>
        /// Создание объектов по нажатии кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoCreatebutton_Click(object sender, EventArgs e)
        {
            iEmployeeBindingSource.Add(new SalaryPayEmployee("Artur", "Kun", 20, 30000, 20, 1));
            iEmployeeBindingSource.Add(new HourlyPayEmployee("Artur", "Viderhspan", 20, 120, 130));
        }

        /// <summary>
        /// Кнопка для тестового сохранения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveTestButton_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("Test2.txt", FileMode.OpenOrCreate))
            {
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
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate))
                {
                    List<IEmployee> empltest = (List<IEmployee>) formatter.Deserialize(fs);
                    iEmployeeBindingSource.DataSource = empltest;
                }
            }

        }

        /// <summary>
        /// Сохранение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Employee.Count != 0)
            {
                SaveFileDialog ofd = new SaveFileDialog();
                ofd.Filter = "txt files (*.txt)|*.txt";
                ofd.RestoreDirectory = true;
                if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
                {
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, Employee);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ошибка. Файл не може быть пустым");
            }
        }

        /// <summary>
        /// закрытие всей программы через крестик
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Employee.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Save changes?", "Warning", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.OK)
                {
                    SaveFileDialog ofd = new SaveFileDialog();
                    ofd.Filter = "txt files (*.txt)|*.txt";
                    ofd.RestoreDirectory = true;
                    if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
                    {
                        using (FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate))
                        {
                            formatter.Serialize(fs, Employee);
                        }
                    }
                }
            }
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = new EmployeeForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                iEmployeeBindingSource.Add(addForm.Employee);
            }
        }

        private void removeEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iEmployeeBindingSource.RemoveCurrent();
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
                    SaveFileDialog ofd = new SaveFileDialog();
                    ofd.Filter = "txt files (*.txt)|*.txt";
                    ofd.RestoreDirectory = true;
                    if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
                    {
                        using (FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate))
                        {
                            formatter.Serialize(fs, Employee);
                        }
                    }
                    iEmployeeBindingSource.Clear();
                }
                else
                {
                    iEmployeeBindingSource.Clear();
                }
            }

        }

        private void modifyEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EmployeeForm();
            int index = iEmployeeBindingSource.IndexOf(iEmployeeBindingSource.Current);
            form.Employee = (IEmployee)iEmployeeBindingSource.Current;
            form.ShowDialog();
            var empl = form.Employee;
            Employee.RemoveAt(index);
            iEmployeeBindingSource.Insert(index, empl);
        }
    }
}
