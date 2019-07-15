using System;
using FactoryComparor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldGiveGreaterOfTwoIntegers()
        {
            var ComparatorImpl = new ComparatorImpl<int>();
            Assert.AreEqual(10, ComparatorImpl.FindGreater(5, 10));
        }

        [TestMethod]
        public void ShouldGiveGreaterOfTwoCharacters()
        {
            var ComparatorImpl = new ComparatorImpl<char>();
            Assert.AreEqual('j', ComparatorImpl.FindGreater('j', 'a'));
        }

        [TestMethod]
        public void ShouldGiveGreaterOfTwoDoubleingPointNumbers()
        {
            var ComparatorImpl = new ComparatorImpl<double>();
            Assert.AreEqual(9.885, ComparatorImpl.FindGreater(9.88, 9.885));
        }

        [TestMethod]
        //Do a alphabetical string comparison.
        // for example a is lesser than b
        public void ShouldGiveGreaterOfTwoStrings()
        {
            var ComparatorImpl = new ComparatorImpl<string>();
            Assert.AreEqual("ThoughtWorks", ComparatorImpl.FindGreater("ThoughtWorks", "ThoughtWorked"));
        }

        [TestMethod]
        public void ShouldGiveAnyOfTwoEqualNumbers()
        {
            var ComparatorImpl = new ComparatorImpl<int>();
            Assert.AreEqual(10, ComparatorImpl.FindGreater(10, 10));
        }
    }
}
