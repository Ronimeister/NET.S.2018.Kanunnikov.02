using NUnit.Framework;
using System;
using static IntOperations.IntFilter;

namespace IntOperations.NUnit.Tests
{
    [TestFixture]
    public class IntFilterTests
    {
        [TestCase(7, new int[] { 9, 25, 7, 2817, 19, 0, 777 }, ExpectedResult = new int[] { 7, 2817, 777 })]
        public int[] FilterDigit_ArrayAndFilter(int filter, int[] array)
            => FilterDigit(filter, array);

        [Test]
        public void FilterDigit_WithNullArray_ThrowArgumentNullException()
            => Assert.Throws<ArgumentNullException>(() => FilterDigit(7, null));

        [Test]
        public void FilterDigit_WithInvalidFilter_ThrowArgumentException()
            => Assert.Throws<ArgumentException>(() => FilterDigit(287, new int[] { 9, 25, 7, 2817, 19, 0, 777 }));
    }
}
