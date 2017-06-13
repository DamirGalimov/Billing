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
        [TestCase(10000, TestName = "Тестирование SalaryPayEmployee.Salary при присваивании позитивного значения 10000")]
        [TestCase(10001, TestName = "Тестирование SalaryPayEmployee.Salary при присваивании позитивного значения 10001")]
        [TestCase(int.MaxValue, TestName = "Тестирование SalaryPayEmployee.Salary при присваивании позитивного значения MaxValue")]
        [TestCase(int.MaxValue - 1, TestName = "Тестирование SalaryPayEmployee.Salary при присваивании MaxValue-1")]
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
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName =
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

        [Test]
        public void SalariesEnrollmentTest()
        {
            var spe = new SalaryPayEmployee();
            spe.Rate = 1;
            spe.DaysWorked = 20;
            spe.Salary = 20000;
            double actual = spe.SalariesEnrollment();
            double result = 16620;

            Assert.AreEqual(result, actual);
        }
    }
}
