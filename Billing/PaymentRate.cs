using System;
using System.Security.Cryptography.X509Certificates;

namespace Billing
{
    /// <summary>
    /// Работник получающий ЗП по ставке
    /// </summary>
    public class PaymentRate: DataChecking ,IEmployee
    {
        private string _name;
        private string _surname;
        private int _age;
        private PaymentType _paymentType = PaymentType.PaymentRate;
        private const int IncomeTax = 13; 

        public string Name
        {
            get { return _name; }
            set { _name = SetChecking(value); }
        }

        public string Surname
        {
            get { return _surname;}
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
    }

}