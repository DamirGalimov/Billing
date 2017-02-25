using System;
using System.Diagnostics;

namespace Billing
{
    /// <summary>
    /// Работник получающий зарплату по почасовой оплате
    /// </summary>
    public class HourlyPay : DataChecking, IEmployee
    {
        private string _name;
        private  string _surname;
        private int _age;
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

        public string Name
        {
            get
            {return _name;}
            set
            {
                _name = SetChecking(value);
            }
        }

        public string Surname
        {
            get
            {return _surname; }

            set { _surname = SetChecking(value); }
        }

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
    
        public PaymentType PaymentType
        {
            get { return _paymentType; }
        }


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

        public double SalariesEnrollment()
        {return (_hoursWorked *_hourCost) - ((_hoursWorked * _hourCost - 400)*IncomeTax)/100; }
    }
        
}