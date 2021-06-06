using System;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
   public class CalculatorTests:Exception
    {
        [Test]
        [TestCase(10,20,30)]
        [TestCase(5,10,15)]
        [TestCase(10,10,20)]
        public void AddTests(int x,int y,int expected_output)
        {
            ClassLibrary1.Calculator obj = new ClassLibrary1.Calculator();
            int result = obj.add(x,y);
            Assert.AreEqual(result, expected_output);
        }
        [TestCase(10, 2, 8)]
        [TestCase(5, 2, 3)]
        [TestCase(30, 10, 20)]
        public void SubTests(int x, int y, int expected_output)
        {
            ClassLibrary1.Calculator obj = new ClassLibrary1.Calculator();
            int result = obj.sub(x, y);
            Assert.AreEqual(result, expected_output);
        }
        [TestCase(10, 3, 30)]
        [TestCase(5, 10, 50)]
        [TestCase(10, 10, 100)]
        public void MulTests(int x, int y, int expected_output)
        {
            ClassLibrary1.Calculator obj = new ClassLibrary1.Calculator();
            int result = obj.mul(x, y);
            Assert.AreEqual(result, expected_output);
        }
        [SetUp]
        public void setup()
        {
            Console.WriteLine("");
        }
        [TestCase(5, 1, 5)]
        [TestCase(10, 2, 5)]
        [TestCase(100, 10, 10)]
        public void DivTests(int x, int y, int expected_output)
        {
            ClassLibrary1.Calculator obj = new ClassLibrary1.Calculator();
            try
            {
                int result = obj.div(x, y);
                Assert.AreEqual(result, expected_output);
            }
            catch(DivideByZeroException)
            {
                if(x==0 || y==0)
                Assert.Fail("Division by zero");
            }
        }
        [TearDown]
        public void teardown()
        {
            Console.WriteLine("");
        }
    }
}