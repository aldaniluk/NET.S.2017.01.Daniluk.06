using System;
using System.Linq;

namespace Logic
{
    public static class JaggedArrayExtension
    {
        /// <summary>
        /// Delegate for possible methods to deal with jagged array.
        /// </summary>
        /// <param name="lhse">One row in jagged array.</param>
        /// <param name="rhs">Another row in jagged array.</param>
        /// <returns>True, if conditions are met, and false otherwise.</returns>
        public delegate bool VariantOfSort(int[] lhs, int[] rhs);

        /// <summary>
        /// Sort jagged array using bubble sorting by different criteria.
        /// </summary>
        /// <param name="array">Jagged array.</param>
        /// <param name="variantOfSort">Selected method among suitable.</param>
        public static void BubbleSorting(int[][] array, VariantOfSort variantOfSort)
        {
            CheckJaggedArray(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (!variantOfSort(array[j], array[j + 1]))
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
        }

        /// <summary>
        /// In the order of increasing sums of elements of rows in matrix.
        /// </summary>
        /// <param name="lhs">One row of matrix.</param>
        /// <param name="rhs">Another row of matrix.</param>
        /// <returns>True, if sum of the next row is greater, and false otherwise.</returns>
        public static bool BubbleSortAscElemSum(int[] lhs, int[] rhs) => lhs.Sum() < rhs.Sum();

        /// <summary>
        /// In the order of decreasing sums of elements of rows in matrix.
        /// </summary>
        /// <param name="lhs">One row of matrix.</param>
        /// <param name="rhs">Another row of matrix.</param>
        /// <returns>True, if sum of the next row is less, and false otherwise.</returns>
        public static bool BubbleSortDescElemSum(int[] lhs, int[] rhs) => lhs.Sum() > rhs.Sum();

        /// <summary>
        /// In the order of increasing max elements of rows in matrix.
        /// </summary>
        /// <param name="lhs">One row of matrix.</param>
        /// <param name="rhs">Another row of matrix.</param>
        /// <returns>True, if max element of the next row is greater, and false otherwise.</returns>
        public static bool BubbleSortAscMaxElem(int[] lhs, int[] rhs) => lhs.Max() < rhs.Max();

        /// <summary>
        /// In the order of decreasing max elements of rows in matrix.
        /// </summary>
        /// <param name="lhs">One row of matrix.</param>
        /// <param name="rhs">Another row of matrix.</param>
        /// <returns>True, if max element of the next row is less, and false otherwise.</returns>
        public static bool BubbleSortDescMaxElem(int[] lhs, int[] rhs) => lhs.Max() > rhs.Max();

        /// <summary>
        /// In the order of increasing min elements of rows in matrix.
        /// </summary>
        /// <param name="lhs">One row of matrix.</param>
        /// <param name="rhs">Another row of matrix.</param>
        /// <returns>True, if min element of the next row is greater, and false otherwise.</returns>
        public static bool BubbleSortAscMinElem(int[] lhs, int[] rhs) => lhs.Min() < rhs.Min();

        /// <summary>
        /// In the order of decreasing min elements of rows in matrix.
        /// </summary>
        /// <param name="lhs">One row of matrix.</param>
        /// <param name="rhs">Another row of matrix.</param>
        /// <returns>True, if min element of the next row is less, and false otherwise.</returns>
        public static bool BubbleSortDescMinElem(int[] lhs, int[] rhs) => lhs.Min() > rhs.Min();

        private static void Swap(int[][] array, int i, int j)
        {
            int[] temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private static void CheckJaggedArray(int[][] array)
        {
            if (ReferenceEquals(array, null)) throw new ArgumentNullException($"{nameof(array)} is null.");
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (ReferenceEquals(array[i], null)) throw new ArgumentNullException($"One of elements in {nameof(array)} is null.");
            }
        }
    }
}
