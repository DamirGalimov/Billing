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
        [TestCase("Ololosh", TestName = "Тестирование SalaryPayEmployee.Name при присваивании позитивного значения 'Ololosh'")]
        [TestCase(97, ExpectedException = typeof(ArgumentException), TestName = 
            "Тестирование SalaryEmployee.Name при присваивании негативного значения - 97.")]
        public void NameTest(string name)
        {
            var spe = new SalaryPayEmployee();
            spe.Name = name;
        }

        [Test]
        [TestCase("Ololoshev", TestName = "Тестирование  SalaryPayEmployee.Surname при присваивании позитивного значения 'Ololoshev'")]
        [TestCase(97, ExpectedException = typeof(ArgumentException), TestName =
            "Тестирование  SalaryPayEmployee.Surname при присваивании негативного значения - 97.")]
        public void SurnameTest(string surname)
        {
            var spe = new SalaryPayEmployee();
            spe.Surname = surname;
        }

        [Test]
        [TestCase(14, TestName = "Тестирование SalaryPayEmployee.Age при присваивании позитивного значения 14")]
        [TestCase(15, TestName = "Тестирование SalaryPayEmployee.Age при присваивании позитивного значения 15")]
        [TestCase(150, TestName = "Тестирование SalaryPayEmployee.Age при присваивании позитивного значения 150")]
        [TestCase(149, TestName = "Тестирование SalaryPayEmployee.Age при присваивании позитивного значения 149")]
        [TestCase(int.MaxValue - 1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование SalaryPayEmployee.Age при присваивании негативного значения MaxValue -1")]
        [TestCase(int.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование SalaryPayEmployee.Age при присваивании негативного значения MaxValue")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование SalaryPayEmployee.Age при присваивании негативного значения - 1.")]
        [TestCase(int.MinValue, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование SalaryPayEmployee.Age при присваивании негативного минимально допустимого значения.")]
        public void AgeTest(int age)
        {
            var spe = new SalaryPayEmployee();
            spe.Age = age;
        }


        [Test]
        [TestCase(10000, TestName = "Тестирование SalaryPayEmployee.Salary при присваивании позитивного значения 10000")]
        [TestCase(10001, TestName = "Тестирование SalaryPayEmployee.Salary при присваивании позитивного значения 10001")]
        [TestCase(int.MaxValue, TestName = "Тестирование SalaryPayEmployee.Salary при присваивании позитивного значения MaxValue")]
        [TestCase(int.MaxValue-1, TestName = "Тестирование SalaryPayEmployee.Salary при присваивании MaxValue-1")]
        [TestCase(0, ExpectedException = typeof(ArgumentException), TestName = 
            "Тестирование SalaryPayEmployee.Salary при присваивании негативного значения 0")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = 
            "Тестирование SalaryPayEmployee.Salary при присваивании негативного значения -1")]
        [TestCase("avva", ExpectedException = typeof(ArgumentException), TestName =
            "Тестирование SalaryPayEmployee.Salary при присваивании негативного значения avva")]
        public void SalaryTest(int salary)
        {
            var spe = new SalaryPayEmployee();
            spe.Salary = salary;
        }


        [Test]
        [TestCase(0, TestName = "Тестирование SalaryPayEmployee.DaysWorked при присваивании позитивного значения 0")]
        [TestCase(1, TestName = "Тестирование SalaryPayEmployee.DaysWorked при присваивании позитивного значения 1")]
        [TestCase(31, TestName = "Тестирование SalaryPayEmployee.DaysWorked при присваивании позитивного значения 31")]
        [TestCase(30, TestName = "Тестирование SalaryPayEmployee.DaysWorked при присваивании позитивного значения 30")]
        [TestCase(-1, ExpectedException =  typeof(ArgumentException), TestName =
            "Тестирование SalaryPayEmployee.DaysWorked при присваивании негативного значения -1")]
        [TestCase(32, ExpectedException = typeof(ArgumentException), TestName =
            "Тестирование SalaryPayEmployee.DaysWorked при присваивании негативного значения 32")]
        public void DaysWorkedTest(int daysWorked)
        {
            var spe = new SalaryPayEmployee();
            spe.DaysWorked = daysWorked;
        }


        [Test]
        [TestCase(0.5, TestName = "Тестирование SalaryPayEmployee.Rate при присваивании позитивного значения 0.5")]
        [TestCase(1, TestName = "Тестирование SalaryPayEmployee.Rate при присваивании позитивного значения 1")]
        [TestCase(0, TestName = "Тестирование SalaryPayEmployee.Rate при присваивании позитивного значения 0")]
        [TestCase(3, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование SalaryPayEmployee.Rate при присваивании негативного значения 3")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование SalaryPayEmployee.Rate при присваивании негативного значения -1")]
        public void RateTest(double rate)
        {
            var spe = new SalaryPayEmployee();
            spe.Rate = rate;
        }
    }
}