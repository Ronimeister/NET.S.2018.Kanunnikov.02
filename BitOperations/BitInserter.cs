using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitOperations
{
    /// <summary>
    /// Class that provides methods to work with BitArrays
    /// </summary>
    public static class BitInserter
    {
        /// <summary>
        /// Allows to insert bits from "secondInt" to "firstInt" starting with "startPosition" to "endPosition".
        /// </summary>
        /// <param name="firstInt">Integer where needed bits should be insert.</param>
        /// <param name="secondInt">Integer from where needed bits should be insert.</param>
        /// <param name="startPosition">Start position to insert bits.</param>
        /// <param name="endPosition">End position to insert bits.</param>
        /// <returns>Modified "firstInt" with the bits from "secondInt".</returns>
        public static int InsertNumber(int firstInt, int secondInt, int startPosition, int endPosition)
        {
            const int INT_SIZE = 31;

            if (startPosition > endPosition)
            {
                throw new ArgumentOutOfRangeException(nameof(startPosition));
            }

            if (startPosition < 0 || startPosition > INT_SIZE)
            {
                throw new ArgumentOutOfRangeException(nameof(startPosition));
            }

            if (endPosition < 0 || endPosition > INT_SIZE)
            {
                throw new ArgumentOutOfRangeException(nameof(endPosition));
            }

            return InsertBitsInInt(firstInt, secondInt, startPosition, endPosition);
        }

        /// <summary>
        /// Private realization of InsertNumber() method.
        /// </summary>
        /// <param name="firstInt">Integer where needed bits should be insert.</param>
        /// <param name="secondInt">Integer from where needed bits should be insert.</param>
        /// <param name="startPos">Start position to insert bits.</param>
        /// <param name="endPos">End position to insert bits.</param>
        /// <returns>Modified "firstInt" with the bits from "secondInt".</returns>
        private static int InsertBitsInInt(int firstInt, int secondInt, int startPos, int endPos)
        {
            const int intSize = 31;
            int range = endPos - startPos + 1;
            int mask = Int32.MaxValue >> intSize - range;

            int firstContainer = mask << startPos;
            firstInt &= ~firstContainer;

            int secondContainer = (mask & secondInt) << startPos;
            secondContainer &= firstContainer;

            return firstInt | secondContainer;
        }
    }
}
