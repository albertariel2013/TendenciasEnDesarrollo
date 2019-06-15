using System;
using NUnit.Framework;
using Kata_S7_p1;
using System.Collections.Generic;
namespace Test_Unit
{
    [TestFixture]
    public class Class1
    {
        Rack rack = new Rack();
        [Test]

        public void One_Number_test()
        {
           
            int[] result = rack.Add(10);
            int[] expected = { 10 };
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Second_Number_test()
        {
            int[] result = rack.Add(20);
            int[] expected = { 10, 20 };
            Assert.AreEqual(expected, result);
        }
        
        [Test]
        public void Third_Number_test()
        {
            int[] result = rack.Add(50);
            int[] expected = { 5,10,20 };
            Assert.AreEqual(expected, result);
        }
    }
}
