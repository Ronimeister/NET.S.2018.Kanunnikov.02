using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntOperations.Tests
{
    [TestClass]
    public class IntFilterTests
    {
        [TestMethod]
        public void FilterDigit_TestArrayAndFilter_ExpectedArray()
        {
            int[] testArray = { 9, 25, 7, 2817, 19, 0, 777, -7 };
            int filter = 7;
            int[] expectedArray = { 7, 2817, 777, -7 };

            int[] actualArray = IntFilter.FilterDigit(filter, testArray);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void FilterDigit_NullAndFilter_ArgumentNullException()
        {
            int filter = 7;
            int[] actualArray = IntFilter.FilterDigit(filter, null);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void FilterDigits_TestArrayAndFilter_ArgumentException()
        {
            int[] testArray = { 9, 25, 7, 2817, 19, 0, 777 };
            int filter = 782;

            int[] actualArray = IntFilter.FilterDigit(filter, testArray);
        }
    }
}
