using System;
using NUnit.Framework;
using Kata_S7_p1;
using System.Collections.Generic;
namespace Test_Unit
{
    [TestFixture]
    public class Class3
    {
        Rack rack1 = new Rack();
        [Test]
        
        public void OneNumber()
        {
            int[] result = rack1.Add(20);
            int[] expected = { 20 };

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TwoNumbers()
        {
            Rack testrack = new Rack();
            testrack.Add(20);
            int[] result = testrack.Add(10);
            int[] expected = { 10,20 };

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ThreeNumbers()
        {
            Rack testrack = new Rack();
            testrack.Add(20);
            testrack.Add(10);
            int[] result = testrack.Add(30);
            int[] expected = { 10, 20,30 };

            Assert.AreEqual(expected, result);
        }
    }
}
