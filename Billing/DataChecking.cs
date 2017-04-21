using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
    /// <summary>
    /// Класс для проверки правильности ввода имени и фамилии
    /// </summary>
    public class DataChecking
    {
        /// <summary>
        /// Статичский метод проверяющий на содержание в строке
        /// небуквенных символов
        /// </summary>
        /// <param name="val"></param>
        /// <returns>Возвращяет строку с заглавной буквой</returns>
        public static string SetChecking(string val)
        {
            val = val.Trim();
            for (int i = 0; i < val.Length; i++)
            {
                if (!Char.IsLetter(val[i]))
                {
                    if (val[i] != '-')
                    {
                        throw new ArgumentException("Name or surname contains non-alphabetic characters.");
                    }
                }
            }

            return (val.Substring(0, 1).ToUpper() + val.Remove(0, 1));
        }
    }
}