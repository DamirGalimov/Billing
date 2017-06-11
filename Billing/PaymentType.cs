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

    //TODO: Класс в отдельный файл.
    //TODO: имя класса поменять на PaymentTypeConverter
    /// <summary>
    /// Класс для конвертации типа оплаты из строки в перечисление и наоборот
    /// </summary>
    public static class ConvertPaymentType
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
                    //TODO: сообщение в исключении на русском, в других классах на английском. Сделать единообразно, лучше на английском.
                    throw new ArgumentException("Неверно указан тип начислния ЗП");
            }
        }

        //TODO: неправильное имя входной переменной
        //TODO: имя метода поменять на ToString
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
                    //TODO: сообщение в исключении на русском, в других классах на английском. Сделать единообразно, лучше на английском.
                    throw new ArgumentException("Неверно указан тип начислния ЗП");
            }
        }
    }
}