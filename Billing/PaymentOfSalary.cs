using System;

namespace Billing
{
    /// <summary>
    /// Работник получающий ЗП по окладу
    /// </summary>
    public class PaymentOfSalary: DataChecking, IEmployee
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
        private PaymentType _paymentType = PaymentType.HourlyPay;
        /// <summary>
        /// ставка НДЛФ в процентах
        /// </summary>
        private const int IncomeTax = 13;
        /// <summary>
        /// Размер оклада за месяц
        /// </summary>
        private int _salary;
        /// <summary>
        /// количество рабочих дней в месяце
        /// </summary>
        private month _workingDays;
        /// <summary>
        /// Количество отработанных дней
        /// </summary>
        private int _daysWorked;


        /// <summary>
        /// Аксессор получения имени
        /// </summary>
        public string Name
        {
            get
            { return _name; }
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
            { return _surname; }

            set { _surname = SetChecking(value); }
        }

        /// <summary>
        /// Аксессорполучения возраста
        /// </summary>
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 150 || value < 14)
                    throw new ArgumentException();
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
        /// 
        /// </summary>
        public int Salary 
        {
            get { return _salary;}
            set
            {
                if (value < 10000)
                {
                    throw new ArgumentException();
                }
                _salary = value;
            }
        }

        public month WorkingDays
        {
            get { return _workingDays;}
            set { _workingDays = value; }
            
        }

        public int DaysWorked
        {
            get { return _daysWorked; }
            set
            {
                if (value < 17 || value > 23)
                {
                    throw new ArgumentException();
                }
                _daysWorked = value;
            }
        }

        public double SalariesEnrollment()
        {
            return (((_salary) - ((_salary - 400)*IncomeTax)/100)*_daysWorked)/Convert.ToInt32(_workingDays);
        }
    }
}