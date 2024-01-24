using MaxOfThree;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MaximumberNumber
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodForInt()
        {

            int num1 = 10;
            //Console.WriteLine("Enter the number1");
            int num2 = 20;
            //Console.WriteLine("Enter the number1");
            int num3 = 40;

            int expected = Math.Max(Math.Max(num1, num2), num3);
           int Actual = Three.MaximumOfThree(num1, num2, num3);

            Assert.AreEqual(expected, Actual);
        }

        [TestMethod]
        public void TestMethodForDouble()
        {

            double num1 = 11.12;
            //Console.WriteLine("Enter the number1");
            double num2 = 20.21 ;
            //Console.WriteLine("Enter the number1");
            double num3 = 40.20;

            double expected = Math.Max(Math.Max(num1, num2), num3);
            double Actual = Three.MaximumOfThree(num1, num2, num3);

            Assert.AreEqual(expected, Actual);
        }
        [TestMethod]
        public void TestMethodForChar()
        {

            char num1 = 'A';
            //Console.WriteLine("Enter the number1");
            char num2 = 'B';
            //Console.WriteLine("Enter the number1");
            char num3 = 'C';

            double expected = Math.Max(Math.Max(num1, num2), num3);
            double Actual = Three.MaximumOfThree(num1, num2, num3);

            Assert.AreEqual(expected, Actual);
        }


    }
}
