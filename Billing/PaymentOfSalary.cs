using System;

namespace Billing
{
    /// <summary>
    /// Работник получающий ЗП по окладу
    /// </summary>
    public class PaymentOfSalary: DataChecking, IEmployee
    {
        private string _name;
        private string _surname;
        private int _age;
        private PaymentType _paymentType = PaymentType.PaymentOfSalary;
        private const int IncomeTax = 13;
        /// <summary>
        /// Оклад за месяц в рублях
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


        public string Name
        {
            get
            { return _name; }
            set
            {
                _name = SetChecking(value);
            }
        }

        public string Surname
        {
            get
            { return _surname; }

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
            set
            {
                
            }
            
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