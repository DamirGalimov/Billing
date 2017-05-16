using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
    //TODO: Исправить название класса. "Checking" это процесс (с точки зрения английского), а должен быть объект
    //TODO: "Data" тоже неправильно. Класс проверяет не дату, а имена.
    //TODO: Если в классе только статический метод, почему сам класс не статический?
    //TODO: Для таких классов лучше создавать в проекте подпапку (например, Tools), чтобы они не лежали в корне проекта - упрощает навигацию по дереву проекта.
    /// <summary>
    /// Класс для проверки правильности ввода имени и фамилии
    /// </summary>
    public class DataChecking
    {
        //TODO: неправильное имя переменной.
        //TODO: В комментарии надо пояснить, что пропускаются не только буквы, но и дефисы. Плюс исправляются регистры
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
                    //TODO: зачем делать вложенное условие, если можно сделать в одном.
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