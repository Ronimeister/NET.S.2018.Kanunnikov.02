using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BitOperations.Tests
{
    [TestClass]
    public class BitInserterTests
    {
        [TestMethod]
        public void InsertNumber_8And15BetweenIndex3and8_120expected()
        {
            int firstInt = 8;
            int secondInt = 15;
            int startPosition = 3;
            int endPosition = 8;
            int expectedInt = 120;

            int actual = BitInserter.InsertNumber(firstInt, secondInt, startPosition, endPosition);

            Assert.AreEqual(actual, expectedInt);
        }

        [TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertNumber_WhereStartPositionBiggerThanEndPosition_ArgumentOutOfRangeException()
        {
            int firstInt = 8;
            int secondInt = 15;
            int startPosition = 3;
            int endPosition = 2;

            int actual = BitInserter.InsertNumber(firstInt, secondInt, startPosition, endPosition);
        }

        [TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertNumber_WhereStartPositionIsInvalid_ArgumentOutOfRangeException()
        {
            int firstInt = 8;
            int secondInt = 15;
            int startPosition = 33;
            int endPosition = 2;

            int actual = BitInserter.InsertNumber(firstInt, secondInt, startPosition, endPosition);
        }

        [TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertNumber_WhereEndPositionIsInvalid_ArgumentOutOfRangeException()
        {
            int firstInt = 8;
            int secondInt = 15;
            int startPosition = 2;
            int endPosition = 34;

            int actual = BitInserter.InsertNumber(firstInt, secondInt, startPosition, endPosition);
        }
    }
}
