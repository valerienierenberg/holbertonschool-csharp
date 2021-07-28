using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    ///<summary>Tests class</summary>
    public class Tests
    {
        [Test]
        public void Test1()
        {
            List<int> myList = new List<int>(); 

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            
            int output = Operations.Max(myList);

            Assert.AreEqual(3, output);
        }
    }
}
