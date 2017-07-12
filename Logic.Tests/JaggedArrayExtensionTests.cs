using NUnit.Framework;
using System;
using Logic;

namespace Logic.Tests
{
    [TestFixture]
    public class JaggedArrayExtensionTests
    {
        [Test]
        public void BubbleSortAscElemSum_CorrectValues_PositiveTest()
        {
            IComparer icomparer = new BubbleSortAscElemSum();
            int[][] arr = { new int[] {1,2,3}, new int[] {10}, new int[] {8} };
            int[][] expected = { new int[] {1,2,3}, new int[] {8}, new int[] {10} };
            JaggedArrayExtension.BubbleSorting(arr, icomparer);
            Assert.AreEqual(arr, expected);
        }

        [Test]
        public void BubbleSortDescElemSum_CorrectValues_PositiveTest()
        {
            IComparer icomparer = new BubbleSortDescElemSum();
            int[][] arr = { new int[] { 1, 2, 3 }, new int[] { 10 }, new int[] { 8 } };
            int[][] expected = { new int[] { 10 }, new int[] { 8 }, new int[] { 1, 2, 3 } };
            JaggedArrayExtension.BubbleSorting(arr, icomparer);
            Assert.AreEqual(arr, expected);
        }

        [Test]
        public void BubbleSortAscMaxElem_CorrectValues_PositiveTest()
        {
            IComparer icomparer = new BubbleSortAscMaxElem();
            int[][] arr = { new int[] { 1, 15, 11 }, new int[] { 6, 2 }, new int[] { 8 } };
            int[][] expected = { new int[] { 6, 2 }, new int[] { 8 }, new int[] { 1, 15, 11 } };
            JaggedArrayExtension.BubbleSorting(arr, icomparer);
            Assert.AreEqual(arr, expected);
        }

        [Test]
        public void BubbleSortDescMaxElem_CorrectValues_PositiveTest()
        {
            IComparer icomparer = new BubbleSortDescMaxElem();
            int[][] arr = { new int[] { 1, 5 }, new int[] { 13, 2 }, new int[] { 14 } };
            int[][] expected = { new int[] { 14 }, new int[] { 13, 2 }, new int[] { 1, 5 } };
            JaggedArrayExtension.BubbleSorting(arr, icomparer);
            Assert.AreEqual(arr, expected);
        }

        [Test]
        public void BubbleSortAscMinElem_CorrectValues_PositiveTest()
        {
            IComparer icomparer = new BubbleSortAscMinElem();
            int[][] arr = { new int[] { 1, 15, 11 }, new int[] { 6, 4 }, new int[] { 2, 8 } };
            int[][] expected = { new int[] { 1, 15, 11 }, new int[] { 2, 8 }, new int[] { 6, 4 } };
            JaggedArrayExtension.BubbleSorting(arr, icomparer);
            Assert.AreEqual(arr, expected);
        }

        [Test]
        public void BubbleSortDescMinElem_CorrectValues_PositiveTest()
        {
            IComparer icomparer = new BubbleSortDescMinElem();
            int[][] arr = { new int[] { 1, 5 }, new int[] { 13, 4 }, new int[] { 2, 14 } };
            int[][] expected = { new int[] { 13, 4 }, new int[] { 2, 14 }, new int[] { 1, 5 } };
            JaggedArrayExtension.BubbleSorting(arr, icomparer);
            Assert.AreEqual(arr, expected);
        }
    }
}
