using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class BubbleSortDescElemSum : IComparer
    {
        /// <summary>
        /// In the order of decreasing sums of elements of rows in matrix.
        /// </summary>
        /// <param name="lhs">One row of matrix.</param>
        /// <param name="rhs">Another row of matrix.</param>
        /// <returns>Negative number, if sum of the next row is less, positive number if greater, and 0 if sums are equal.</returns>
        public int Compare(int[] lhs, int[] rhs) => rhs.Sum() - lhs.Sum();
    }
}
