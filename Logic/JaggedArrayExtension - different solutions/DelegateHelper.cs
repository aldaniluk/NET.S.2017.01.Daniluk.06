using System;

namespace Logic
{
    public class DelegateHelper : IComparer
    {
        private delegate int delegateHelper(int[] lhs, int[] rhs);
        private delegateHelper d;

        /// <summary>
        /// Ctor with parameter.
        /// </summary>
        /// <param name="comparer">Comparer, which Compare(int[],int[]) method will be contained into delegate.</param>
        public DelegateHelper(IComparer comparer)
        {
            if (ReferenceEquals(comparer, null)) throw new ArgumentNullException($"{nameof(comparer)} is null.");
            d = comparer.Compare;
        }

        /// <summary>
        /// Calls appropriate method Compare(int[],int[]), which compares two rows of matrix.
        /// </summary>
        /// <param name="lhs">One matrix row.</param>
        /// <param name="rhs">Another matrix row.</param>
        /// <returns>Negative number, if left row is less; positive number, if greater; 0, if they are equal.</returns>
        public int Compare(int[] lhs, int[] rhs) => d(lhs, rhs);

    }
}
