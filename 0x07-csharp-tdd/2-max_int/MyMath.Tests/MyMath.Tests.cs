using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    ///<summary>Tests class</summary>
    public class Tests
    {
        [Test]
        public void TestLast()
        {
            List<int> myList = new List<int>(); 

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            
            int output = Operations.Max(myList);

            Assert.AreEqual(3, output);
        }

        [Test]
        public void TestFirst()
        {
            List<int> myList = new List<int>(); 

            myList.Add(3);
            myList.Add(2);
            myList.Add(1);
            
            int output = Operations.Max(myList);

            Assert.AreEqual(3, output);
        }

        [Test]
        public void TestMiddle()
        {
            List<int> myList = new List<int>(); 

            myList.Add(3);
            myList.Add(4);
            myList.Add(1);
            
            int output = Operations.Max(myList);

            Assert.AreEqual(4, output);
        }

        [Test]
        public void TestNegInList()
        {
            List<int> myList = new List<int>(); 

            myList.Add(3);
            myList.Add(-3);
            myList.Add(1);
            
            int output = Operations.Max(myList);

            Assert.AreEqual(3, output);
        }

        [Test]
        public void TestEmptyList()
        {
            List<int> myList = new List<int>(); 
            
            int output = Operations.Max(myList);

            Assert.AreEqual(0, output);
        }
    }
}
