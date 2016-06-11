using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace kata0611_FizzBuzz
{
    [TestFixture]
    class FizzBuzzTest
    {
        private readonly FizzBuzz _fizzBuzz = new FizzBuzz();

        [Test]
        public void NormalNumber_return_Default([Values(1, 2, 4, 7, 8, 11, 13, 14)]int input)
        {
            Assert.AreEqual(input.ToString(), _fizzBuzz.GetValue(input));
        }

        [Test]
        public void Divided_3_number_return_Fizz([Values(3, 6, 9, 12)]int input)
        {
            Assert.AreEqual("Fizz", _fizzBuzz.GetValue(input));
        }

        [Test]
        public void Divided_5_number_return_Buzz([Values(5, 10)]int input)
        {
            Assert.AreEqual("Buzz", _fizzBuzz.GetValue(input));
        }

        [Test]
        public void Divided_3_and_5_number_return_FizzBuzz([Values(15, 30, 45, 60, 75, 90)]int input)
        {
            Assert.AreEqual("FizzBuzz", _fizzBuzz.GetValue(input));
        }
    }
}
