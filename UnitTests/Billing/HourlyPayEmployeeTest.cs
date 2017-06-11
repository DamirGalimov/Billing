using NUnit.Framework;
using Billing;
using System;

namespace UnitTests.Billing

{
    //TODO: не протестировано самое главное в классе - правильность расчета зарплаты.
    /// <summary>
    /// Набор тестов для класса HourlyPayEmployee
    /// </summary>
    [TestFixture]
    public class HourlyPayEmployeeTest
    {
        [Test]
        [TestCase(100, TestName = "Тестирование HourlyPayEmployee.HourCost при присваивании позитивного значения 100")]
        [TestCase(101, TestName = "Тестирование HourlyPayEmployee.HourCost при присваивании позитивного значения 101")]
        [TestCase(99, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourlyPayEmployee.HourCost при присваивании негативного значения 99.")]
        [TestCase(double.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourlyPayEmployee.HourCost при присваивании негативного значения MaxValue.")]
        public void HourCostTest(double hourCost)
        {
            var hpe = new HourlyPayEmployee();
            hpe.HourCost = hourCost;
        }

        [Test]
        [TestCase(0, TestName = "Тестирование HourlyPayEmployee.HoursWorked при присваивании позитивного значения 0")]
        [TestCase(1, TestName = "Тестирование HourlyPayEmployee.HoursWorked при присваивании позитивного значения 101")]
        [TestCase(300, TestName = "Тестирование HourlyPayEmployee.HoursWorked при присваивании позитивного значения 300")]
        [TestCase(299, TestName = "Тестирование HourlyPayEmployee.HoursWorked при присваивании позитивного значения 299")]
        [TestCase(301, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourlyPayEmployee.HoursWorked при присваивании негативного значения 301")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourlyPayEmployee.HoursWorked при присваивании негативного значения -1.")]
        public void HoursWorkedTest(int hoursWorked)
        {
            var hpe = new HourlyPayEmployee();
            hpe.HoursWorked = hoursWorked;
        }


    }
}