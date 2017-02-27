using System;

namespace Billing
{
    /// <summary>
    /// Перечсиление типов начисления ЗП
    /// </summary>
    public enum PaymentType
    {
        HourlyPay,
        PaymentOfSalary
    }

    /// <summary>
    /// Класс для конвертации типа оплаты из строки в перечисление и наоборот
    /// </summary>
    public class ConvertPaymentType
    {
        /// <summary>
        /// Метод для конвертации перечисления в строку
        /// </summary>
        public static PaymentType ToPaymentType(string str)
        {
            switch (str)
            {
                case "Почасовая":
                    return PaymentType.HourlyPay;
                case "По окладу":
                    return PaymentType.PaymentOfSalary;
                default:
                    throw new ArgumentException("Неверно указан тип начислния ЗП");
            }
        }

        /// <summary>
        /// Метод для конвертации строку в перечисление
        /// </summary>
        public static string ToStringPayment(PaymentType p)
        {
            switch (p)
            {
                case PaymentType.HourlyPay:
                    return "Почасовая";
                case PaymentType.PaymentOfSalary:
                    return "По окладу";
                default:
                    throw new ArgumentException("Неверно указан тип начислния ЗП");
            }
        }
    }
}