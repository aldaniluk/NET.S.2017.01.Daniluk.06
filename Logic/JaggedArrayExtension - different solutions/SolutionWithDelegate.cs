using System;

namespace Logic
{
    public static class SolutionWithDelegate
    {
        /// <summary>
        /// Sort jagged array using bubble sorting by different criteria.
        /// </summary>
        /// <param name="array">Jagged array.</param>
        /// <param name="delegateHelper">Delegate.</param>
        public static void BubbleSorting(int[][] array, DelegateHelper delegateHelper)
        {
            CheckJaggedArray(array);
            if (ReferenceEquals(delegateHelper, null)) throw new ArgumentNullException($"{nameof(delegateHelper)} is null.");

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (delegateHelper.Compare(array[j], array[j + 1]) > 0)
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
        }

        /// <summary>
        /// Sort jagged array using bubble sorting by different criteria.
        /// </summary>
        /// <param name="array">Jagged array.</param>
        /// <param name="icomparer">Selected class of sorting among suitable.</param>
        public static void BubbleSorting(int[][] array, IComparer icomparer)
        {
            BubbleSorting(array, new DelegateHelper(icomparer));
        }

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
    }
}
