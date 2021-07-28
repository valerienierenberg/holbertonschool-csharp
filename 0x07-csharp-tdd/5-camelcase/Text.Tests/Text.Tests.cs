using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    ///<summary>Tests class</summary>
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string myString = "oneTwoThree";
            int output = Str.CamelCase(myString);

            Assert.AreEqual(3, output);
        }

        [Test]
        public void TestMultCaps()
        {
            string myString = "aBCDefgh";
            int output = Str.CamelCase(myString);

            Assert.AreEqual(4, output);
        }

        [Test]
        public void TestEmpty()
        {
            string myString = "";
            int output = Str.CamelCase(myString);

            Assert.AreEqual(0, output);
        }
    }
}