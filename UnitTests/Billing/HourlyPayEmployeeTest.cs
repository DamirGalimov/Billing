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
        [TestCase ("Ololosh", TestName = "Тестирование Name при присваивании Ololosh")]
        [TestCase(97, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Name при присваивании - 97.")]
        public void NameTest(string name)
        {
            var hpe = new HourlyPayEmployee();
            hpe.Name = name;
        }

        [Test]
        [TestCase("Ololoshev", TestName = "Тестирование Name при присваивании Ololosh")]
        [TestCase(97, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Name при присваивании - 97.")]
        public void SurnameTest(string surname)
        {
            var hpe = new HourlyPayEmployee();
            hpe.Surname = surname;
        }

        [Test]
        [TestCase(14, TestName = "Тестирование Age при присваивании 14")]
        [TestCase(15, TestName = "Тестирование Age при присваивании 15")]
        [TestCase(150, TestName = "Тестирование Age при присваивании 150")]
        [TestCase(149, TestName = "Тестирование Age при присваивании 149")]
        [TestCase(int.MaxValue -1, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование Age при присваивании MaxValue -1")]
        [TestCase(int.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Age при присваивании MaxValue")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование Count при присваивании - 1.")]
        [TestCase(int.MinValue, ExpectedException =typeof(ArgumentException), 
            TestName = "Тестирование Count при присваивании минимально допустимого целого числа.")]
        public void AgeTest(int age)
        {
            var hpe = new HourlyPayEmployee();
            hpe.Age = age;
        }

        [Test]
        [TestCase(100, TestName = "Тестирование HourCost при присваивании 100")]
        [TestCase(101, TestName = "Тестирование HourCost при присваивании 101")]
        [TestCase(150, TestName = "Тестирование HourCost при присваивании 150")]
        [TestCase(149, TestName = "Тестирование HourCost при присваивании 149")]
        [TestCase(double.MaxValue - 1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourCost при присваивании MaxValue -1")]
        [TestCase(double.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourCost при присваивании MaxValue")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourCost при присваивании - 1.")]
        [TestCase(int.MinValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourCost при присваивании минимально допустимого целого числа.")]
        public void HourCostTest(double hourcost)
        {
            var hpe = new HourlyPayEmployee();
            hpe.HourCost = hourcost;
        }

        [Test]
        [TestCase(0, TestName = "Тестирование HoursWorked при присваивании 0")]
        [TestCase(1, TestName = "Тестирование HoursWorked при присваивании 101")]
        [TestCase(300, TestName = "Тестирование HoursWorked при присваивании 300")]
        [TestCase(299, TestName = "Тестирование HoursWorked при присваивании 299")]
        [TestCase(double.MaxValue - 1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HoursWorked при присваивании MaxValue -1")]
        [TestCase(double.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HoursWorked при присваивании MaxValue")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HoursWorked при присваивании - 1.")]
        [TestCase(int.MinValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HoursWorked при присваивании минимально допустимого целого числа.")]
        public void HoursWorkedTest(int hoursWorked)
        {
            var hpe = new HourlyPayEmployee();
            hpe.HoursWorked = hoursWorked;
        }


    }
}