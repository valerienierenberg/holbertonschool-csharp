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

        [Test]
        public void TestTwoWords()
        {
            string myString = "One Two";
            int output = Str.CamelCase(myString);

            Assert.AreEqual(2, output);
        }

        [Test]
        public void TestOneWord()
        {
            string myString = "one";
            int output = Str.CamelCase(myString);

            Assert.AreEqual(1, output);
        }

        [Test]
        public void TestMultWords()
        {
            string myString = "oneTwo ThreeFour";
            int output = Str.CamelCase(myString);

            Assert.AreEqual(4, output);
        }
    }
}