using NUnit.Framework;
using recursion;
using System;

namespace Recusion_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Fibonacci_Test_Result_Correct()
        {
            Demo d = new Demo();
            int val = 7;
            int res = d.displayFibonacci(val);
            Assert.AreEqual(res, 13);

        }
        [Test]
        public void Factorial_Test_Result_Correct()
        {         
            int number = 5;
            long fact = Demo.GetFactorial(number);
            Assert.AreEqual(fact, 120);
        }
    }
}