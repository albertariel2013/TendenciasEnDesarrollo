using System;
using NUnit.Framework;
using Range_p2;
using System.Collections.Generic;
namespace Test
{
    
    public class Class1
    {


        Container container = new Container();


       [Test]

       public void TwoSixContainsTwoFour()
       {
            bool result = container.Contains("[2,6)", "[2,4]");
            Assert.AreEqual(true, result);
       }
    }
}
