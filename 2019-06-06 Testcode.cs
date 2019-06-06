using System;
using NUnit.Framework;
using StringCalc__p1;

namespace Test
{
    [TestFixture]
    public class Class1
    {
        StringCalculator calculator = new StringCalculator();
        [Test]

        public void EmptyString()
        {
            
            string teststring = "";
            string output = calculator.Add(teststring);

            Assert.AreEqual("0", output);
        }

        [Test]

        public void One_Number_Test()
        {
            string teststring = "1";
            string output = calculator.Add(teststring);

            Assert.AreEqual("1", output);
        }

        [Test]

        public void Two_Number_Test_part1()
        {
            string teststring = "1,2";
            string output = calculator.Add(teststring);

            Assert.AreEqual("3", output);
        }

        [Test]
        
        public void Two_Number_Test_twodigits()
        {
            string teststring = "10,22";
            string output = calculator.Add(teststring);

            Assert.AreEqual("32", output);
        }
    }
}
