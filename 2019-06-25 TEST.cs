using System;
using NUnit.Framework;
using System.Collections.Generic;
using Word_Wrap_p1;

namespace Test
{

    [TestFixture]

    public class Class1
    {
        Wrapper wrapper = new Wrapper();
        
        [Test]

        public void Test1_SimpleWordWithLength2()
        {

            string expected = "a s";
            string result = wrapper.Wrap("as", 1);

            Assert.AreEqual(expected, result);

        }

        [Test]


        /*
         * I need to make sure that no word in the input is longer than a column limit
         * if so, need to place a \n inside of it.
         * 
         * how:
         * Count how many digits between a \n and another \n. If the word surpasses the limits
         * place a \n on it. if not, let it be.
         * 
         * */
        public void Test2_2WordsLength5()
        {
            string expected = "hello world";
            string result = wrapper.Wrap("hello world", 7);

            Assert.AreEqual(expected, result);

        }


    }
}
