using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
        [XmlElement("Name")]
        string Name { get; set; }
        /// <summary>
        /// Фамилия работника
        /// </summary>
        [XmlElement("Surname")]
        string Surname { get; set; }
        /// <summary>
        /// Возраст работника
        /// </summary>
        [XmlElement("Age")]
        int Age { get; set; }
        /// <summary>
        /// Информация о способе начисления ЗП
        /// </summary>
        [XmlElement("PaymenType")]
        PaymentType PaymentType { get; }
        /// <summary>
        /// Размер зарплаты
        /// </summary>
        [XmlElement("Wages")]
        double Wages { get; }
        /// <summary>
        /// Расчет заработной платы работника
        /// </summary>
        /// <returns>Размер заработной платы работника в рублях </returns>
        double SalariesEnrollment();
    }
}
