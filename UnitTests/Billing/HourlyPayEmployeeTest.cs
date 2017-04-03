using NUnit.Framework;
using Billing;
using System;

namespace UnitTests.Billing

{
    /// <summary>
    /// Набор тестов для класса HourlyPayEmployee
    /// </summary>
    [TestFixture]
    public class HourlyPayEmployeeTest
    {
        [Test]
        [TestCase ("Ololosh", TestName = "Тестирование HourlyPayEmployee.Name при присваивании позитивного значения 'Ololosh'")]
        [TestCase(97, ExpectedException = typeof(ArgumentException), TestName = 
            "Тестирование HourlyPayEmployee.Name при присваивании негативного значения - 97.")]
        public void NameTest(string name)
        {
            var hpe = new HourlyPayEmployee();
            hpe.Name = name;
        }

        [Test]
        [TestCase("Ololoshev", TestName = "Тестирование HourlyPayEmployee.Surname при присваивании позитивного значения Ololosh")]
        [TestCase(97, ExpectedException = typeof(ArgumentException), TestName =
            "Тестирование HourlyPayEmployee.Surname при присваивании негативного значения - 97.")]
        public void SurnameTest(string surname)
        {
            var hpe = new HourlyPayEmployee();
            hpe.Surname = surname;
        }

        [Test]
        [TestCase(14, TestName = "Тестирование HourlyPayEmployee.Age при присваивании позитивного значения 14")]
        [TestCase(15, TestName = "Тестирование HourlyPayEmployee.Age при присваивании позитивного значения 15")]
        [TestCase(150, TestName = "Тестирование HourlyPayEmployee.Age при присваивании позитивного значения 150")]
        [TestCase(149, TestName = "Тестирование HourlyPayEmployee.Age при присваивании позитивного значения 149")]
        [TestCase(int.MaxValue -1, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование HourlyPayEmployee.Age при присваивании негативного значения MaxValue-1")]
        [TestCase(int.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourlyPayEmployee.Age при присваивании негативного значения MaxValue")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование HourlyPayEmployee.Age при присваивании негативного значения -1.")]
        [TestCase(int.MinValue, ExpectedException =typeof(ArgumentException), 
            TestName = "Тестирование HourlyPayEmployee.Age при присваивании негативного минимально допустимого значения.")]
        public void AgeTest(int age)
        {
            var hpe = new HourlyPayEmployee();
            hpe.Age = age;
        }

        [Test]
        [TestCase(100, TestName = "Тестирование HourlyPayEmployee.HourCost при присваивании позитивного значения 100")]
        [TestCase(101, TestName = "Тестирование HourlyPayEmployee.HourCost при присваивании позитивного значения 101")]
        [TestCase(150, TestName = "Тестирование HourlyPayEmployee.HourCost при присваивании позитивного значения 150")]
        [TestCase(149, TestName = "Тестирование HourlyPayEmployee.HourCost при присваивании позитивного значения 149")]
        [TestCase(double.MaxValue - 1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourlyPayEmployee.HourCost при присваивании негативного значения MaxValue -1")]
        [TestCase(double.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourlyPayEmployee.HourCost при присваивании негативного значения MaxValue")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourlyPayEmployee.HourCost при присваивании негативного значения - 1.")]
        [TestCase(int.MinValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourlyPayEmployee.HourCost при присваивании негативного минимально допустимого значения.")]
        public void HourCostTest(double hourcost)
        {
            var hpe = new HourlyPayEmployee();
            hpe.HourCost = hourcost;
        }

        [Test]
        [TestCase(0, TestName = "Тестирование HourlyPayEmployee.HoursWorked при присваивании позитивного значения 0")]
        [TestCase(1, TestName = "Тестирование HourlyPayEmployee.HoursWorked при присваивании позитивного значения 101")]
        [TestCase(300, TestName = "Тестирование HourlyPayEmployee.HoursWorked при присваивании позитивного значения 300")]
        [TestCase(299, TestName = "Тестирование HourlyPayEmployee.HoursWorked при присваивании позитивного значения 299")]
        [TestCase(double.MaxValue - 1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourlyPayEmployee.HoursWorked при присваивании негативного значения MaxValue -1")]
        [TestCase(double.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourlyPayEmployee.HoursWorked при присваивании негативного значения MaxValue")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourlyPayEmployee.HoursWorked при присваивании негативного значения -1.")]
        [TestCase(int.MinValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourlyPayEmployee.HoursWorked при присваивании негативного минимально допустимого значения.")]
        public void HoursWorkedTest(int hoursWorked)
        {
            var hpe = new HourlyPayEmployee();
            hpe.HoursWorked = hoursWorked;
        }


    }
}