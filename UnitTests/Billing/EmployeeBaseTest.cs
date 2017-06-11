using NUnit.Framework;
using Billing;
using System;

//TODO: в проекте отвалилась ссылка на nunit. Скорее всего, библиотека не добавлена под версионный контроль (по-умолчанию dll файлы игнорируются гитом)
//TODO: добавить библиотеку под версионный контроль. Иначе проект тестов просто не компилируется на любых машинах, кроме твоей.

//TODO: не протестированы DataCheking и PaymentTypeConverter, ConvertCheck. 
//TODO: Еще стоит тестировать Serializer, так как ручное тестирование загрузки и сохранения файлов занимает много времени
namespace UnitTests.Billing
{
    public class EmployeeBaseTest
    {
        [Test]
        [TestCase("Ololosh", TestName = "Тестирование HourlyPayEmployee.Name при присваивании позитивного значения 'Ololosh'")]
        [TestCase("97", ExpectedException = typeof(ArgumentException), TestName =
            "Тестирование HourlyPayEmployee.Name при присваивании негативного значения - '97'.")]
        [TestCase("abcd1234", ExpectedException = typeof(ArgumentException), TestName =
            "Тестирование HourlyPayEmployee.Name при присваивании негативного значения - abcd1234.")]
        public void NameTest(string name)
        {
            var hpe = new HourlyPayEmployee();
            hpe.Name = name;
        }

        [Test]
        [TestCase("Ololoshev", TestName = "Тестирование HourlyPayEmployee.Surname при присваивании позитивного значения Ololosh")]
        [TestCase("97", ExpectedException = typeof(ArgumentException), TestName =
            "Тестирование HourlyPayEmployee.Surname при присваивании негативного значения - '97'.")]
        [TestCase("abcd1234", ExpectedException = typeof(ArgumentException), TestName =
            "Тестирование HourlyPayEmployee.Name при присваивании негативного значения - abcd1234.")]
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