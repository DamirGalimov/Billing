using System;
using NUnit.Framework;
using Billing;


namespace UnitTests.Billing
{
    [TestFixture]
    public class EmployeeBaseTest
    {
        [Test]
        [TestCase("Ololosh", TestName = "Тестирование HourlyPayEmployee.Name при присваивании позитивного значения 'Ololosh'")]
        [TestCase("97", ExpectedException = typeof(ArgumentException), TestName =
            "Тестирование HourlyPayEmployee.Name при присваивании негативного значения - '97'.")]
        public void NameTest(string name)
        {
            var hpe = new HourlyPayEmployee();
            hpe.Name = name;
        }

        [Test]
        [TestCase("Ololoshev", TestName = "Тестирование HourlyPayEmployee.Surname при присваивании позитивного значения Ololosh")]
        [TestCase("97", ExpectedException = typeof(ArgumentException), TestName =
            "Тестирование HourlyPayEmployee.Surname при присваивании негативного значения - '97'.")]
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
        [TestCase(int.MaxValue - 1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourlyPayEmployee.Age при присваивании негативного значения MaxValue-1")]
        [TestCase(int.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourlyPayEmployee.Age при присваивании негативного значения MaxValue")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourlyPayEmployee.Age при присваивании негативного значения -1.")]
        [TestCase(int.MinValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование HourlyPayEmployee.Age при присваивании негативного минимально допустимого значения.")]
        public void AgeTest(int age)
        {
            var hpe = new HourlyPayEmployee();
            hpe.Age = age;
        }

    }
}
