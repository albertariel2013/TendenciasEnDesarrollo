using System;
using NUnit.Framework;
using string_calc_p2;
using System.Collections.Generic;
namespace Test
{
    [TestFixture]
    public class Class2
    {

        Container container = new Container();

        [Test]

        public void Test1_2to6_Contains2to4()
        {
            bool Result = container.contains("[2,6)", "[2,4]");

            Assert.AreEqual(Result, true);
        }
    }
}
