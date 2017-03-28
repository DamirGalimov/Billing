using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billing;
using static Billing.PaymentType;


namespace Billing_View
{
    public partial class SearchForm : Form
    {
        List<IEmployee> SearchList = new List<IEmployee>();
            
        public SearchForm(List<IEmployee> list)
        {
            InitializeComponent();
            SearchList = list;
            
        }

        /// <summary>
        /// Кнопка поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string ss = textBoxSearch.Text;
            string criterion = Convert.ToString(comboBoxSearch.SelectedItem);
            switch (criterion)
            {
                case "Name":
                    {
                        iEmployeeBindingSource.DataSource = SearchList.FindAll(delegate (IEmployee empl)
                        {
                            return empl.Name == ss;
                        });
                        break;
                    }
                case "Surname":
                    iEmployeeBindingSource.DataSource = SearchList.FindAll(delegate (IEmployee empl)
                    {
                        return empl.Surname == ss;
                    });
                    break;
                case "Age":
                    {
                        int age = Convert.ToInt32(textBoxSearch.Text);
                        iEmployeeBindingSource.DataSource = SearchList.FindAll(delegate (IEmployee empl)
                        {
                            return empl.Age == age;
                        });
                        break;
                    }
                case "Payment type":
                    {
                        iEmployeeBindingSource.DataSource = SearchList.FindAll(delegate (IEmployee empl)
                        {
                            PaymentType pt = ConvertPaymentType.ToPaymentType(ss);
                            return empl.PaymentType == pt;
                        });
                        break;
                    }
            }
        }

        /// <summary>
        /// Кнопка очистить таблицу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            iEmployeeBindingSource.Clear();
        }

        private void textBoxSearch_MouseHover(object sender, EventArgs e)
        {
            if (comboBoxSearch.SelectedItem.ToString() == "Payment type")
            {
                toolTip.Show("Enter 'By hour' or 'By salary'", textBoxSearch);
            }
           
        }
    }
}
