using System;
using static Billing.DataChecking;

namespace Billing
{
    /// <summary>
    /// Работник получающий ЗП по окладу
    /// </summary>
    [Serializable]
    public class SalaryPayEmployee: EmployeeBase, IEmployee
    {
        /// <summary>
        /// ставка НДФЛ в процентах
        /// </summary>
        private const int IncomeTax = 13;
        /// <summary>
        /// Размер оклада за месяц
        /// </summary>
        private double _salary;
        /// <summary>
        /// Количество отработанных дней
        /// </summary>
        private int _daysWorked;
        /// <summary>
        /// Ставка работника
        /// </summary>
        private double _rate;

        /// <summary>
        /// Базовый конструктор
        /// </summary>
        public SalaryPayEmployee()
            { }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">имя работника</param>
        /// <param name="surname">фамилия работника</param>
        /// <param name="age">возраст работника</param>
        /// <param name="salary">размер оклада на занимаемой должности</param>
        /// <param name="rate">ставка работника</param>
        /// <param name="daysWorked">количество отработанных дней работником</param>
        public SalaryPayEmployee(string name, string surname, int age, double salary, int daysWorked, double rate)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
            DaysWorked = daysWorked;
            Rate = rate;
        }

        /// <summary>
        /// Аксессор для получения информации о типе начисления ЗП
        /// </summary>
        public override PaymentType PaymentType
        {
            get
            {
                return PaymentType.PaymentOfSalary;
            }
        }

        /// <summary>
        /// Аксессор получения оклада. Минимум 10000руб
        /// </summary>
        public double Salary 
        {
            get { return _salary;}
            set
            {
                if (value < 10000)
                {
                    throw new ArgumentException("Incorrecly entered size of salary, not less than 10000");
                }
                _salary = value;
            }
        }

        /// <summary>
        /// Аксессор получения количества отработанных дней работником.
        /// </summary>
        public int DaysWorked
        {
            get { return _daysWorked; }
            set
            {
                if (value < 0 || value >31)
                {
                    throw new ArgumentException("Incorrecly entered amount days worked.");
                }
                _daysWorked = value;
            }
        }

        /// <summary>
        /// Размер ставки работника
        /// </summary>
        public double Rate
        {
            get
            {
                return _rate;
            }
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Incorrecly entered size of rate.");
                }
                _rate = value;
            }
        }

        /// <summary>
        /// Расчет ЗП с учетом НДЛФ(13%) и вычетов. 
        /// 400руб - стандартный вычет для резидентов РФ.
        /// </summary>
        /// <returns>ЗП в рублях расчитанная по формуле с учетом НДЛФ, вычетов и ставки</returns>
        public override double SalariesEnrollment()
        {
            return Math.Round((((_salary) - ((_salary - 400) * IncomeTax) / 100) 
                * _daysWorked  * _rate) / 
                WorkingCalendare.WorkingDaysInMonth[(DateTime.Now.Month-1)]); 
        }
    }
}