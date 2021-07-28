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
            string word = "eeeeekeee";
            int output = Str.UniqueChar(word);

            Assert.AreEqual(5, output);
        }

        [Test]
        public void TestBeginning()
        {
            string word = "keeeee";
            int output = Str.UniqueChar(word);

            Assert.AreEqual(1, output);
        }

        [Test]
        public void TestEmpty()
        {
            string word = "";
            int output = Str.UniqueChar(word);

            Assert.AreEqual(-1, output);
        }

        [Test]
        public void TestEnd()
        {
            string word = "aaaaaaah";
            int output = Str.UniqueChar(word);

            Assert.AreEqual(7, output);
        }

        [Test]
        public void TestNoNew()
        {
            string word = "aaaaaaa";
            int output = Str.UniqueChar(word);

            Assert.AreEqual(-1, output);
        }
    }
}
