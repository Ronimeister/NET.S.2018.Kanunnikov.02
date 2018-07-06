using System;
using System.Collections.Generic;

namespace IntOperations
{
    /// <summary>
    /// Class that provides methods for filtering int arrays
    /// </summary>
    public static class IntFilter
    {
        /// <summary>
        /// Filter array values by certain filter digit
        /// </summary>
        /// <param name="unfilteredArr">Filtered array</param>
        /// <param name="filter">Digit that contains in all needed array values</param>
        /// <exception cref="ArgumentNullException">Throws when the array is equal to null.</exception>
        /// <exception cref="ArgumentException">Throws when the filter isn't less than 10 and bigger than 0.</exception>
        /// <returns>Array that contains needed values</returns>
        public static int[] FilterDigit(int filter, params int[] unfilteredArr)
        {
            if (!(filter < 10 && filter >= 0))
            {
                throw new ArgumentException(nameof(filter));
            }

            if (unfilteredArr == null)
            {
                throw new ArgumentNullException(nameof(unfilteredArr));
            }

            return FilterArrayValuesUsingDivision(unfilteredArr, filter);
        }

        /// <summary>
        /// Find all needed values of filtered array that contains "filter" digit using division by 10
        /// </summary>
        /// <param name="unfilteredArr">Filtered array</param>
        /// <param name="filter">Digit that contains in all needed array values</param>
        /// <returns>Array that contains needed values</returns>
        private static int[] FilterArrayValuesUsingDivision(int[] unfilteredArr, int filter)
        {
            int buffElement;
            List<int> filteredList = new List<int>();
            for (int i = 0; i < unfilteredArr.Length; i++)
            {
                buffElement = unfilteredArr[i];
                if (buffElement < 0 && buffElement != Int32.MinValue)
                {
                    buffElement *= -1;
                }
                else if (buffElement == Int32.MinValue)
                {
                    filteredList.Add(unfilteredArr[i]);
                }

                while (buffElement != 0)
                {
                    if (buffElement % 10 == filter)
                    {
                        filteredList.Add(unfilteredArr[i]);
                        break;
                    }

                    buffElement /= 10;
                }
            }

            return filteredList.ToArray();
        }

        /// <summary>
        /// Find all needed values of filtered array that contains "filter" digit using ToString() method
        /// </summary>
        /// <param name="unfilteredArr">Filtered array</param>
        /// <param name="filter">Digit that contains in all needed array values</param>
        /// <returns>Array that contains needed values</returns>
        private static int[] FilterArrayValuesUsingStrings(int[] unfilteredArr, int filter)
        {
            List<int> filteredList = new List<int>();
            foreach (int i in unfilteredArr)
            {
                if (i.ToString().Contains(filter.ToString()))
                {
                    filteredList.Add(i);
                }
            }

            return filteredList.ToArray();
        }
    }
}
