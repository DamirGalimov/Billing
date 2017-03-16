using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
    /// <summary>
    /// Интерфейс работника
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Имя работника
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Фамилия работника
        /// </summary>
        string Surname { get; set; }
        /// <summary>
        /// Возраст работника
        /// </summary>
        int Age { get; set; }
        /// <summary>
        /// Информация о способе начисления ЗП
        /// </summary>
        PaymentType PaymentType { get; }
        /// <summary>
        /// Размер зарплаты
        /// </summary>
        double Wages { get; }
        /// <summary>
        /// Расчет заработной платы работника
        /// </summary>
        /// <returns>Размер заработной платы работника в рублях </returns>
        double SalariesEnrollment();
    }
}
