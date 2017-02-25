using System;
using System.Diagnostics;

namespace Billing
{
    /// <summary>
    /// Работник получающий зарплату по почасовой оплате
    /// </summary>
    public class HourlyPay : DataChecking, IEmployee
    {
        /// <summary>
        /// Имя работника
        /// </summary>
        private string _name;
        /// <summary>
        /// Фамилия работника
        /// </summary>
        private  string _surname;
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
        /// Стоимость часа в рублях
        /// </summary>
        private int _hourCost;
        /// <summary>
        /// сумма отработанных часов
        /// </summary>
        private int _hoursWorked;

        /// <summary>
        /// Аксессор получения имени
        /// </summary>
        public string Name
        {
            get
            {return _name;}
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
            {return _surname; }

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
        /// Аксессор получения стоимости часа в рублях.
        /// По закону не меньше 100 руб/час
        /// </summary>
        public int HourCost
        {
            get { return _hourCost;}
            set
            {
                if (value < 100)
                {
                    throw new ArgumentException();
                }
                _hourCost = value;
            }
        }

        /// <summary>
        /// Аксессор получения суммы отработанных часов.
        /// По закону не больше 300 часов
        /// </summary>
        public int HoursWorked
        {
            get { return _hoursWorked;}
            set
            {
                if (value < 0 || value >300)
                {
                    throw new ArgumentException();
                }
                _hoursWorked = value;
            }
        }

        /// <summary>
        /// Расчет ЗП с учетом НДЛФ(13%) и вычетов. 
        /// 400руб - стандартный вычет для резидентов РФ.
        /// (Сумма_отработанных_часов*стоимость_часа)- 
        /// </summary>
        /// <returns>ЗП в рублях расчитанная по формуле с учетом НДЛФ и вычетов</returns>
        public double SalariesEnrollment()
        {return (_hoursWorked *_hourCost) - ((_hoursWorked * _hourCost - 400)*IncomeTax)/100; }
    }
        
}