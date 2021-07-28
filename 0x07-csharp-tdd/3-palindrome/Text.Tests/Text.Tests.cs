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
            string word = "eye";

            bool output = Str.IsPalindrome(word);

            Assert.AreEqual(true, output);
        }

        [Test]
        public void Test2()
        {
            string word = "eyes";

            bool output = Str.IsPalindrome(word);

            Assert.AreEqual(false, output);
        }
    }
}
