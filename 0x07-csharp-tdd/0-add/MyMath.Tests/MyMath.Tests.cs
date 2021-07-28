using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    ///<summary>Tests class</summary>
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int a = 1;
            int b = 2;

            int output = Operations.Add(a, b);

            Assert.AreEqual(3, output);
        }
    }
}
