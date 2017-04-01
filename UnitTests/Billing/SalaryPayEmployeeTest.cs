using System;
using NUnit.Framework;
using Billing;

namespace UnitTests.Billing
{
    /// <summary>
    /// Набор тестов для SalaryPayEmployee
    /// </summary>
    [TestFixture]
    public class SalaryPayEmployeeTest
    {
        [Test]
        [TestCase("Ololosh", TestName = "Тестирование Name при присваивании Ololosh")]
        [TestCase(97, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Name при присваивании - 97.")]
        public void NameTest(string name)
        {
            var spe = new SalaryPayEmployee();
            spe.Name = name;
        }

        [Test]
        [TestCase("Ololoshev", TestName = "Тестирование Name при присваивании Ololosh")]
        [TestCase(97, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Name при присваивании - 97.")]
        public void SurnameTest(string surname)
        {
            var spe = new SalaryPayEmployee();
            spe.Surname = surname;
        }

        [Test]
        [TestCase(14, TestName = "Тестирование Age при присваивании 14")]
        [TestCase(15, TestName = "Тестирование Age при присваивании 15")]
        [TestCase(150, TestName = "Тестирование Age при присваивании 150")]
        [TestCase(149, TestName = "Тестирование Age при присваивании 149")]
        [TestCase(int.MaxValue - 1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Age при присваивании MaxValue -1")]
        [TestCase(int.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Age при присваивании MaxValue")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Count при присваивании - 1.")]
        [TestCase(int.MinValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Count при присваивании минимально допустимого целого числа.")]
        public void AgeTest(int age)
        {
            var spe = new SalaryPayEmployee();
            spe.Age = age;
        }


        [Test]
        [TestCase(10000, TestName = "Тестирование Salary при присваивании 10000")]
        [TestCase(10001, TestName = "Тестирование Salary при присваивании 10001")]
        [TestCase(int.MaxValue, TestName = "Тестирование Salary при присваивании MaxValue")]
        [TestCase(int.MaxValue-1, TestName = "Тестирование Salary при присваивании MaxValue-1")]
        [TestCase(0, ExpectedException = typeof(ArgumentException), TestName = "Тест Salary при присваивании 0")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тест Salary при присваивании -1")]
        [TestCase("avva", ExpectedException = typeof(ArgumentException), TestName = "Тест Salary при присваивании avva")]
        public void SalaryTest(int salary)
        {
            var spe = new SalaryPayEmployee();
            spe.Salary = salary;
        }


        [Test]
        [TestCase(0, TestName = "Тестирование DaysWorked при присваивании 0")]
        [TestCase(1, TestName = "Тестирование DaysWorked при присваивании 1")]
        [TestCase(31, TestName = "Тестирование DaysWorked при присваивании 31")]
        [TestCase(30, TestName = "Тестирование DaysWorked при присваивании 30")]
        [TestCase(-1, ExpectedException =  typeof(ArgumentException), TestName = "Тест DaysWorked при присваивании -1")]
        [TestCase(32, ExpectedException = typeof(ArgumentException), TestName = "Тест DaysWorked при присваивании 32")]
        public void DaysWorkedTest(int daysWorked)
        {
            var spe = new SalaryPayEmployee();
            spe.DaysWorked = daysWorked;
        }


        [Test]
        [TestCase(0.5, TestName = "Тестирование Rate при присваивании 0.5")]
        [TestCase(1, TestName = "Тестирование Rate при присваивании 1")]
        [TestCase(0, TestName = "Тестирование Rate при присваивании 0")]
        [TestCase(3, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Rate при присваивании 3")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование Rate при присваивании -1")]
        public void RateTest(double rate)
        {
            var spe = new SalaryPayEmployee();
            spe.Rate = rate;
        }
    }
}