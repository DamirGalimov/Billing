using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Billing.DataChecking;

namespace Billing
{
    /// <summary>
    /// Базовый класс работников
    /// </summary>
    [Serializable]
    public  abstract class EmployeeBase : IEmployee
    {
        /// <summary>
        /// Имя работника
        /// </summary>
        private string _name;
        /// <summary>
        /// Фамилия работника
        /// </summary>
        private string _surname;
        /// <summary>
        /// Возраст работника
        /// </summary>
        private int _age;
        

        /// <summary>
        /// Аксессор получения имени
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = SetChecking(value);
            }
        }
        /// <summary>
        /// Аксессор получения фамилии
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                _surname = SetChecking(value);
            }
        }

        /// <summary>
        /// Аксессорполучения возраста
        /// </summary>
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 150 || value < 14)
                    throw new ArgumentException("Incorrecly entered the age, not less than 14, not more than 150.");
                _age = value;
            }
        }

        /// <summary>
        /// Аксессор для получения информации о типе начисления ЗП
        /// </summary>
        public abstract PaymentType PaymentType
        {
            get;
        }
        

        /// <summary>
        /// Получение размера ЗП
        /// </summary>
        public double Wages
        {
            get
            {
                return SalariesEnrollment();
            }
        }

        /// <summary>
        /// Метод расчета заработанной платы
        /// </summary>
        /// <returns></returns>
        public abstract double SalariesEnrollment();
    }
}
