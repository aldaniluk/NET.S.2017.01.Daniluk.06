using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class BubbleSortDescMaxElem : IComparer
    {
        /// <summary>
        /// In the order of decreasing max elements of rows in matrix.
        /// </summary>
        /// <param name="lhs">One row of matrix.</param>
        /// <param name="rhs">Another row of matrix.</param>
        /// <returns>Negative number, if max element of the next row is less, positive number if greater, and 0 if max elements are equal.</returns>
        public int Compare(int[] lhs, int[] rhs) => rhs.Max() - lhs.Max();
    }
}
