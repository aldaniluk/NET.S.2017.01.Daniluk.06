using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class BubbleSortAscMinElem : IComparer
    {
        /// <summary>
        /// In the order of increasing min elements of rows in matrix.
        /// </summary>
        /// <param name="lhs">One row of matrix.</param>
        /// <param name="rhs">Another row of matrix.</param>
        /// <returns>Negative number, if min element of the next row is greater, positive number if less, and 0 if max elements are equal.</returns>
        public int Compare(int[] lhs, int[] rhs) => lhs.Min() - rhs.Min();
    }
}
