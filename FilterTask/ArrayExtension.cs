﻿using System;
using System.Collections.Generic;

namespace FilterTask
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Returns new array of elements that contain expected digit from source array.
        /// </summary>
        /// <param name="source">Source array.</param>
        /// <param name="digit">Expected digit.</param>
        /// <returns>Array of elements that contain expected digit.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when digit value is out of range (0..9).</exception>
        /// <example>
        /// {1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17}  => { 7, 70, 17 } for digit = 7
        /// </example>
        public static int[] FilterByDigit(int[] source, int digit)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source), "array is null");
            }

            if (source.Length == 0)
            {
                throw new ArgumentException(nameof(source), "array is empty");
            }

            if (digit < 0 || digit > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(digit), "digit lees zero or more than nine");
            }

            List<int> numbers = new List<int>();
            var str = digit.ToString();

            for (int i = 0; i < source.Length; i++)
            {
                var temp = source[i].ToString();
                int j = 0;
                do
                {
                    if (temp[j].ToString() == str)
                    {
                        numbers.Add(source[i]);
                        break;
                    }
                    j++;
                } while (j < temp.Length);
            }

            return numbers.ToArray();
        }
    }
}
