using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BitOperations.BitInserter;

namespace BitOperations.NUnit.Tests
{
    [TestFixture]
    public class BitInserterTests
    {
        [TestCase(15, 15, 0, 0, ExpectedResult = 15)]
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(8, 15, 3, 8, ExpectedResult = 120)]
        [TestCase(13, 25, 7, 11, ExpectedResult = 3213)]
        [TestCase(8, -1, 3, 5, ExpectedResult = 56)]
        public int InsertNumber_TestWithDiffValues(int x, int y, int start, int end)
            => InsertNumber(x, y, start, end);

        [Test]
        public void InsertNumber_TestWithNegativeIndexex()
            => Assert.Throws<ArgumentOutOfRangeException>(() => InsertNumber(15, 19, -2, -4));

        [Test]
        public void InsertNumber_WhereStartBiggerThanEnd()
            => Assert.Throws<ArgumentOutOfRangeException>(() => InsertNumber(15, 19, 8, 2));

        [Test]
        public void InsertNumber_TestIndexOverFlow()
            => Assert.Throws<ArgumentOutOfRangeException>(() => InsertNumber(15, 19, 33, 0));
    }
}
