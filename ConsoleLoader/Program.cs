using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billing;
using static Billing.ConvertPaymentType;


namespace ConsoleLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Создание объектов
            var empl1 = new HourlyPay("Anton", "Blinov", 19, 110.5, 140);
            var empl2 = new PaymentOfSalary("Vladimir", "Pupin", 32, 23000.4, 1, 1);
            var empl3 = new PaymentOfSalary("Artur", "Vidershpan", 19, 12000, 10, 0.5);
            var empl4 = new HourlyPay();

            ///создание списка
            var Employee = new List<IEmployee> {empl1, empl2, empl3, empl4};

           ///запрос у пользователя заполнить данные работника
            Console.WriteLine("Введите имя работника, фамилию, возраст, стоимость часа, сколько проработано часов");
            ///Проверка на ошибки
            try
            {
                empl4.Name = Console.ReadLine();
                empl4.Surname = Console.ReadLine();
                empl4.Age = Convert.ToInt32(Console.ReadLine());
                empl4.HourCost = Convert.ToDouble(Console.ReadLine());
                empl4.HoursWorked = Convert.ToInt32(Console.ReadLine());
            }
            ///если появилась ошибка
            catch (FormatException)
            {
                Console.WriteLine("Ошибка, несоответствие форматов");
            }

            ///Перебор объектов
            foreach (var empl in Employee)
            {
                Console.WriteLine("{0} {1} возраст {2} лет, способ начисления {3}. ЗП - {4}",
                empl.Name, empl.Surname, empl.Age, ToStringPayment(empl.PaymentType), empl.SalariesEnrollment());
            }
            
            Console.WriteLine(WorkingCalendare.WorkingDaysInMonth[(DateTime.Now.Month - 1)]);
            Console.ReadKey();
        }
    }
}
