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
        public void TestNotPal()
        {
            string word = "eyes";

            bool output = Str.IsPalindrome(word);

            Assert.AreEqual(false, output);
        }

        [Test]
        public void TestEmpty()
        {
            string word = "";

            bool output = Str.IsPalindrome(word);

            Assert.AreEqual(true, output);
        }

        [Test]
        public void TestOneLetter()
        {
            string word = "e";

            bool output = Str.IsPalindrome(word);

            Assert.AreEqual(true, output);
        }

        [Test]
        public void TestUpperLowerCasePuncSpaces()
        {
            string word = "A man, a plan, a canal: Panama.";

            bool output = Str.IsPalindrome(word);

            Assert.AreEqual(true, output);
        }
    }
}

// Notes - is an empty string supposed to be a palindrome (return true?)
//       - what about a one-letter word?
