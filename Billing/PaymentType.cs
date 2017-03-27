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
    public  static class ConvertPaymentType
    {
        /// <summary>
        /// Метод для конвертации перечисления в строку
        /// </summary>
        public static PaymentType ToPaymentType(string str)
        {
            switch (str)
            {
                case "By hour":
                    return PaymentType.HourlyPay;
                case "By salary":
                    return PaymentType.PaymentOfSalary;
                default:
                    throw new ArgumentException("Неверно указан тип начислния ЗП");
            }
        }

        /// <summary>
        /// Метод для конвертации перечисления в строку
        /// </summary>
        public static string ToStringPayment(PaymentType p)
        {
            switch (p)
            {
                case PaymentType.HourlyPay:
                    return "By hour";
                case PaymentType.PaymentOfSalary:
                    return "By salary";
                default:
                    throw new ArgumentException("Неверно указан тип начислния ЗП");
            }
        }
    }
}