using System;
using static Billing.DataChecking;

namespace Billing
{
    /// <summary>
    /// Работник получающий ЗП по окладу
    /// </summary>
    public class SalaryPayEmployee: IEmployee
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
        /// Информация о том как начисляется ЗП
        /// </summary>
        private PaymentType _paymentType = PaymentType.PaymentOfSalary;
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
        /// Аксессор получения возраста
        /// </summary>
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 150 || value < 14)
                    throw new ArgumentException("Неверно введет возраст, не менее 14, не более 150");
                _age = value;
            }
        }

        /// <summary>
        /// Аксессор для получения информации о типе начисления ЗП
        /// </summary>
        public PaymentType PaymentType
        {
            get { return _paymentType; }
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
                    throw new ArgumentException("Неверно введен размер оклада, не меньше 10000 рублей");
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
                if (value < 0)
                {
                    throw new ArgumentException("Неверно введено количество отработанных дней");
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
                    throw new ArgumentException("Неверно введена ставка");
                }
                _rate = value;
            }
        }

        /// <summary>
        /// Расчет ЗП с учетом НДЛФ(13%) и вычетов. 
        /// 400руб - стандартный вычет для резидентов РФ.
        /// </summary>
        /// <returns>ЗП в рублях расчитанная по формуле с учетом НДЛФ, вычетов и ставки</returns>
        public double SalariesEnrollment()
        {
            return Math.Round((((_salary) - ((_salary - 400) * IncomeTax) / 100) * _daysWorked  * _rate) / 
                WorkingCalendare.WorkingDaysInMonth[(DateTime.Now.Month-1)]); 
        }

        public double Wages
        {
            get
            {
                return SalariesEnrollment();
            }
        }
    }
}