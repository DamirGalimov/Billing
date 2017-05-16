using System;
using System.Diagnostics;
//TODO: аналогично замечанию в базовом классе
using static Billing.DataChecking;


namespace Billing
{
    //TODO: если базовый класс реализует интерфейс, то указывать его в наследнике уже не надо
    /// <summary>
    /// Работник получающий зарплату по почасовой оплате
    /// </summary>
    [Serializable]
    public class HourlyPayEmployee : EmployeeBase, IEmployee
    {
        /// <summary>
        /// ставка НДЛФ в процентах
        /// </summary>
        private const int IncomeTax = 13;
        /// <summary>
        /// Стоимость часа в рублях
        /// </summary>
        private double _hourCost;
        /// <summary>
        /// сумма отработанных часов
        /// </summary>
        private int _hoursWorked;


        /// <summary>
        /// Базовый конструктор
        /// </summary>
        public HourlyPayEmployee()
        { }

        /// <summary>
        /// Конструктор класса 
        /// </summary>
        /// <param name="name">имя работника</param>
        /// <param name="surname">фамилия работника</param>
        /// <param name="age">возраст работника</param>
        /// <param name="hourCost">стоимость часа в рублях на занимаемой должности</param>
        /// <param name="hoursWorked">сумма отработанных часов работником</param>
        public HourlyPayEmployee(string name, string surname, int age, double hourCost, int hoursWorked)
        {
            Name = name;
            Surname = surname;
            Age = age;
            HourCost = hourCost;
            HoursWorked = hoursWorked;
        }
        
        /// <summary>
        /// Аксессор для получения информации о типе начисления ЗП
        /// </summary>
        public override PaymentType PaymentType
        {
            get
            {
                return PaymentType.HourlyPay;
            }
        }

        /// <summary>
        /// Аксессор получения стоимости часа в рублях.
        /// По закону не меньше 100 руб/час
        /// </summary>
        public double HourCost
        {
            get { return _hourCost;}
            set
            {
                if (value < 100)
                {
                    throw new ArgumentException("Incorrecly entered hour cost, not less than 100.");
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
                    throw new ArgumentException("Incorrecly entered amount of hours worked, " +
                                                "not less than 0, not more than 300");
                }
                _hoursWorked = value;
            }
        }

        /// <summary>
        /// Расчет ЗП с учетом НДЛФ(13%) и вычетов. 
        /// 400руб - стандартный вычет для резидентов РФ.
        /// </summary>
        /// <returns>ЗП в рублях расчитанная по формуле с учетом НДЛФ и вычетов</returns>
        public override double SalariesEnrollment()
        {
            return Math.Round((_hoursWorked *_hourCost) - ((_hoursWorked * _hourCost - 400)*IncomeTax)/100);
        }
    }      
}