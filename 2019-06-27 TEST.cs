using System;
using NUnit.Framework;
using word_wrap_p2;
namespace Test
{


    [TestFixture]
    public class Class1
    {
        Wrapper wrapper = new Wrapper();

        [Test]

        public void Split2DigitsWordIn1()
        {
            string testinput = "bf";
            string result = wrapper.Wrap(testinput, 1);
            Assert.AreEqual("b f", result);
        }

        [Test]

        public void Split2WordsifLengthMoreThanThree()
        {

            string testinput = "Hello World";
            string result = wrapper.Wrap(testinput, 3);
            Assert.AreEqual("Hel lo Wor ld", result);


        }

        [Test]
        public void Split3WordsifLengthMoreThan10()
        {
            string testinput = "Hello World asadersa";
            string result = wrapper.Wrap(testinput, 10);
            Assert.AreEqual("Hello World asadersa", result);
        }


        /*
         * 
         * ESTO HA SIDO TODO POR LA KATA DE HOY, NOS VIMOS LA SEMANA SIGUIENTE!
         * */
    }
}
