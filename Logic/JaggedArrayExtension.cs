using System;
using System.Linq;

namespace Logic
{
    public static class JaggedArrayExtension
    {

        #region solution with interface and with delegate 
        /// <summary>
        /// Sort jagged array using bubble sorting by different criteria.
        /// </summary>
        /// <param name="array">Jagged array.</param>
        /// <param name="icomparer">Selected class of sorting among suitable.</param>
        public static void BubbleSorting(int[][] array, IComparer icomparer)
        {
            CheckJaggedArray(array);
            if (ReferenceEquals(icomparer, null)) throw new ArgumentNullException($"{nameof(icomparer)} is null.");

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (icomparer.Compare(array[j], array[j + 1]) > 0)
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
        }

        ///// <summary>
        ///// Sort jagged array using bubble sorting by different criteria.
        ///// </summary>
        ///// <param name="array">Jagged array.</param>
        ///// <param name="variantOfSort">Selected method among suitable.</param>
        //public static void BubbleSorting(int[][] array, VariantOfSort variantOfSort)
        //{
        //    CheckJaggedArray(array);
        //    if (ReferenceEquals(variantOfSort, null)) throw new ArgumentNullException($"{nameof(variantOfSort)} is null.");

        //    for (int i = 0; i < array.Length - 1; i++)
        //    {
        //        for (int j = 0; j < array.Length - i - 1; j++)
        //        {
        //            if (variantOfSort(array[j], array[j + 1]) > 0)
        //            {
        //                Swap(array, j, j + 1);
        //            }
        //        }
        //    }
        //}

        ///// <summary>
        ///// Delegate for possible methods to deal with jagged array.
        ///// </summary>
        ///// <param name="lhs">One row in jagged array.</param>
        ///// <param name="rhs">Another row in jagged array.</param>
        ///// <returns>True, if conditions are met, and false otherwise.</returns>
        //public delegate int VariantOfSort(int[] lhs, int[] rhs);

        //public static int BubbleSortAscElemSum(int[] lhs, int[] rhs)
        //{
        //    CheckJaggedArrayRows(lhs, rhs);
        //    return lhs.Sum().CompareTo(rhs.Sum());
        //}
        //public static int BubbleSortDescElemSum(int[] lhs, int[] rhs)
        //{
        //    CheckJaggedArrayRows(lhs, rhs);
        //    return rhs.Sum().CompareTo(lhs.Sum());
        //}
        //public static int BubbleSortAscMaxElem(int[] lhs, int[] rhs)
        //{
        //    CheckJaggedArrayRows(lhs, rhs);
        //    return lhs.Max().CompareTo(rhs.Max());
        //}
        //public static int BubbleSortDescMaxElem(int[] lhs, int[] rhs)
        //{
        //    CheckJaggedArrayRows(lhs, rhs);
        //    return rhs.Max().CompareTo(lhs.Max());
        //}
        //public static int BubbleSortAscMinElem(int[] lhs, int[] rhs)
        //{
        //    CheckJaggedArrayRows(lhs, rhs);
        //    return lhs.Min().CompareTo(rhs.Min());
        //}
        //public static int BubbleSortDescMinElem(int[] lhs, int[] rhs)
        //{
        //    CheckJaggedArrayRows(lhs, rhs);
        //    return rhs.Min().CompareTo(lhs.Min());
        //}
        #endregion


        #region private methods
        private static void Swap(int[][] array, int i, int j)
        {
            int[] temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        private static void CheckJaggedArray(int[][] array)
        {
            if (ReferenceEquals(array, null)) throw new ArgumentNullException($"{nameof(array)} is null.");
            if (array.Length == 0) throw new ArgumentException($"{nameof(array)} is empty.");
        }
        private static void CheckJaggedArrayRows(int[] lhs, int[] rhs)
        {
            if (ReferenceEquals(lhs, null)) throw new ArgumentNullException($"{nameof(lhs)} is null.");
            if (ReferenceEquals(rhs, null)) throw new ArgumentNullException($"{nameof(rhs)} is null.");
        }
        #endregion

    }
}
