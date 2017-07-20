using NUnit.Framework;
using System;
using Logic;

namespace Logic.Tests
{
    [TestFixture]
    public class JaggedArrayExtensionTests
    {
        #region JaggedArrayExtension
        [Test]
        public void ComparerBubbleSortAscElemSum_CorrectValues_PositiveTest()
        {
            IComparer icomparer = new BubbleSortAscElemSum();
            int[][] arr = { new int[] { 1, 2, 3 }, new int[] { 10 }, new int[] { 8 } };
            int[][] expected = { new int[] { 1, 2, 3 }, new int[] { 8 }, new int[] { 10 } };
            JaggedArrayExtension.BubbleSorting(arr, icomparer);
            Assert.AreEqual(arr, expected);
        }

        [Test]
        public void ComparerBubbleSortDescElemSum_CorrectValues_PositiveTest()
        {
            IComparer icomparer = new BubbleSortDescElemSum();
            int[][] arr = { new int[] { 1, 2, 3 }, new int[] { 10 }, new int[] { 8 } };
            int[][] expected = { new int[] { 10 }, new int[] { 8 }, new int[] { 1, 2, 3 } };
            JaggedArrayExtension.BubbleSorting(arr, icomparer);
            Assert.AreEqual(arr, expected);
        }

        [Test]
        public void ComparerBubbleSortAscMaxElem_CorrectValues_PositiveTest()
        {
            IComparer icomparer = new BubbleSortAscMaxElem();
            int[][] arr = { new int[] { 1, 15, 11 }, new int[] { 6, 2 }, new int[] { 8 } };
            int[][] expected = { new int[] { 6, 2 }, new int[] { 8 }, new int[] { 1, 15, 11 } };
            JaggedArrayExtension.BubbleSorting(arr, icomparer);
            Assert.AreEqual(arr, expected);
        }

        [Test]
        public void ComparerBubbleSortDescMaxElem_CorrectValues_PositiveTest()
        {
            IComparer icomparer = new BubbleSortDescMaxElem();
            int[][] arr = { new int[] { 1, 5 }, new int[] { 13, 2 }, new int[] { 14 } };
            int[][] expected = { new int[] { 14 }, new int[] { 13, 2 }, new int[] { 1, 5 } };
            JaggedArrayExtension.BubbleSorting(arr, icomparer);
            Assert.AreEqual(arr, expected);
        }

        [Test]
        public void ComparerBubbleSortAscMinElem_CorrectValues_PositiveTest()
        {
            IComparer icomparer = new BubbleSortAscMinElem();
            int[][] arr = { new int[] { 1, 15, 11 }, new int[] { 6, 4 }, new int[] { 2, 8 } };
            int[][] expected = { new int[] { 1, 15, 11 }, new int[] { 2, 8 }, new int[] { 6, 4 } };
            JaggedArrayExtension.BubbleSorting(arr, icomparer);
            Assert.AreEqual(arr, expected);
        }

        [Test]
        public void ComparerBubbleSortDescMinElem_CorrectValues_PositiveTest()
        {
            IComparer icomparer = new BubbleSortDescMinElem();
            int[][] arr = { new int[] { 1, 5 }, new int[] { 13, 4 }, new int[] { 2, 14 } };
            int[][] expected = { new int[] { 13, 4 }, new int[] { 2, 14 }, new int[] { 1, 5 } };
            JaggedArrayExtension.BubbleSorting(arr, icomparer);
            Assert.AreEqual(arr, expected);
        }

        [Test]
        public void ComparerBubbleSortDescMinElem_NullJaggedArray_ThrowArgumentNullException()
        {
            IComparer icomparer = new BubbleSortDescMinElem();
            int[][] arr = null;
            Assert.Throws<ArgumentNullException>(() => JaggedArrayExtension.BubbleSorting(arr, icomparer));
        }

        [Test]
        public void ComparerBubbleSortDescMinElem_EmptyJaggedArray_ThrowArgumentNullException()
        {
            IComparer icomparer = new BubbleSortDescMinElem();
            int[][] arr = new int[][] { };
            Assert.Throws<ArgumentException>(() => JaggedArrayExtension.BubbleSorting(arr, icomparer));
        }

        [Test]
        public void ComparerBubbleSortDescMinElem_NullElementsInJaggedArray_ThrowArgumentNullException()
        {
            IComparer icomparer = new BubbleSortDescMinElem();
            int[][] arr = { new int[] { 13, 4 }, new int[] { 2, 14 }, null };
            Assert.Throws<ArgumentNullException>(() => JaggedArrayExtension.BubbleSorting(arr, icomparer));
        }

        //[Test]
        //public void DelegateBubbleSortAscElemSum_CorrectValues_PositiveTest()
        //{
        //    int[][] arr = { new int[] { 1, 2, 3 }, new int[] { 10 }, new int[] { 8 } };
        //    int[][] expected = { new int[] { 1, 2, 3 }, new int[] { 8 }, new int[] { 10 } };
        //    JaggedArrayExtension.BubbleSorting(arr, JaggedArrayExtension.BubbleSortAscElemSum);
        //    Assert.AreEqual(arr, expected);
        //}

        //[Test]
        //public void DelegateBubbleSortDescElemSum_CorrectValues_PositiveTest()
        //{
        //    int[][] arr = { new int[] { 1, 2, 3 }, new int[] { 10 }, new int[] { 8 } };
        //    int[][] expected = { new int[] { 10 }, new int[] { 8 }, new int[] { 1, 2, 3 } };
        //    JaggedArrayExtension.BubbleSorting(arr, JaggedArrayExtension.BubbleSortDescElemSum);
        //    Assert.AreEqual(arr, expected);
        //}

        //[Test]
        //public void DelegateBubbleSortAscMaxElem_CorrectValues_PositiveTest()
        //{
        //    int[][] arr = { new int[] { 1, 15, 11 }, new int[] { 6, 2 }, new int[] { 8 } };
        //    int[][] expected = { new int[] { 6, 2 }, new int[] { 8 }, new int[] { 1, 15, 11 } };
        //    JaggedArrayExtension.BubbleSorting(arr, JaggedArrayExtension.BubbleSortAscMaxElem);
        //    Assert.AreEqual(arr, expected);
        //}

        //[Test]
        //public void DelegateBubbleSortDescMaxElem_CorrectValues_PositiveTest()
        //{
        //    int[][] arr = { new int[] { 1, 5 }, new int[] { 13, 2 }, new int[] { 14 } };
        //    int[][] expected = { new int[] { 14 }, new int[] { 13, 2 }, new int[] { 1, 5 } };
        //    JaggedArrayExtension.BubbleSorting(arr, JaggedArrayExtension.BubbleSortDescMaxElem);
        //    Assert.AreEqual(arr, expected);
        //}

        //[Test]
        //public void DelegateBubbleSortAscMinElem_CorrectValues_PositiveTest()
        //{
        //    int[][] arr = { new int[] { 1, 15, 11 }, new int[] { 6, 4 }, new int[] { 2, 8 } };
        //    int[][] expected = { new int[] { 1, 15, 11 }, new int[] { 2, 8 }, new int[] { 6, 4 } };
        //    JaggedArrayExtension.BubbleSorting(arr, JaggedArrayExtension.BubbleSortAscMinElem);
        //    Assert.AreEqual(arr, expected);
        //}

        //[Test]
        //public void DelegateBubbleSortDescMinElem_CorrectValues_PositiveTest()
        //{
        //    int[][] arr = { new int[] { 1, 5 }, new int[] { 13, 4 }, new int[] { 2, 14 } };
        //    int[][] expected = { new int[] { 13, 4 }, new int[] { 2, 14 }, new int[] { 1, 5 } };
        //    JaggedArrayExtension.BubbleSorting(arr, JaggedArrayExtension.BubbleSortDescMinElem);
        //    Assert.AreEqual(arr, expected);
        //}

        //[Test]
        //public void DelegateBubbleSortDescMinElem_NullJaggedArray_ThrowArgumentNullException()
        //{
        //    IComparer icomparer = new BubbleSortDescMinElem();
        //    int[][] arr = null;
        //    Assert.Throws<ArgumentNullException>(() => JaggedArrayExtension.BubbleSorting(arr, JaggedArrayExtension.BubbleSortAscElemSum));
        //}

        //[Test]
        //public void DelegateBubbleSortDescMinElem_EmptyJaggedArray_ThrowArgumentNullException()
        //{
        //    IComparer icomparer = new BubbleSortDescMinElem();
        //    int[][] arr = new int[][] { };
        //    Assert.Throws<ArgumentException>(() => JaggedArrayExtension.BubbleSorting(arr, JaggedArrayExtension.BubbleSortAscElemSum));
        //}

        //[Test]
        //public void DelegateBubbleSortDescMinElem_NullElementsInJaggedArray_ThrowArgumentNullException()
        //{
        //    IComparer icomparer = new BubbleSortDescMinElem();
        //    int[][] arr = { new int[] { 13, 4 }, new int[] { 2, 14 }, null };
        //    Assert.Throws<ArgumentNullException>(() => JaggedArrayExtension.BubbleSorting(arr, JaggedArrayExtension.BubbleSortAscElemSum));
        //}
        #endregion

        #region SolutionWithDelegate
        [Test]
        public void SolutionWithDelegate_ComparerBubbleSortAscElemSum_CorrectValues_PositiveTest()
        {
            IComparer icomparer = new BubbleSortAscElemSum();
            int[][] arr = { new int[] { 1, 2, 3 }, new int[] { 10 }, new int[] { 8 } };
            int[][] expected = { new int[] { 1, 2, 3 }, new int[] { 8 }, new int[] { 10 } };
            SolutionWithDelegate.BubbleSorting(arr, icomparer);
            Assert.AreEqual(arr, expected);
        }

        [Test]
        public void SolutionWithDelegate_ComparerBubbleSortDescElemSum_CorrectValues_PositiveTest()
        {
            IComparer icomparer = new BubbleSortDescElemSum();
            int[][] arr = { new int[] { 1, 2, 3 }, new int[] { 10 }, new int[] { 8 } };
            int[][] expected = { new int[] { 10 }, new int[] { 8 }, new int[] { 1, 2, 3 } };
            SolutionWithDelegate.BubbleSorting(arr, icomparer);
            Assert.AreEqual(arr, expected);
        }

        [Test]
        public void SolutionWithDelegate_DelegateBubbleSortAscElemSum_CorrectValues_PositiveTest()
        {
            int[][] arr = { new int[] { 1, 2, 3 }, new int[] { 10 }, new int[] { 8 } };
            int[][] expected = { new int[] { 1, 2, 3 }, new int[] { 8 }, new int[] { 10 } };
            SolutionWithDelegate.BubbleSorting(arr, new DelegateHelper(new BubbleSortAscElemSum()));
            Assert.AreEqual(arr, expected);
        }

        [Test]
        public void SolutionWithDelegate_DelegateBubbleSortDescElemSum_CorrectValues_PositiveTest()
        {
            int[][] arr = { new int[] { 1, 2, 3 }, new int[] { 10 }, new int[] { 8 } };
            int[][] expected = { new int[] { 10 }, new int[] { 8 }, new int[] { 1, 2, 3 } };
            SolutionWithDelegate.BubbleSorting(arr, new DelegateHelper(new BubbleSortDescElemSum()));
            Assert.AreEqual(arr, expected);
        }
        #endregion

        #region SolutionWithInterface
        [Test]
        public void SolutionWithInterface_ComparerBubbleSortAscMaxElem_CorrectValues_PositiveTest()
        {
            IComparer icomparer = new BubbleSortAscMaxElem();
            int[][] arr = { new int[] { 1, 15, 11 }, new int[] { 6, 2 }, new int[] { 8 } };
            int[][] expected = { new int[] { 6, 2 }, new int[] { 8 }, new int[] { 1, 15, 11 } };
            SolutionWithInterface.BubbleSorting(arr, icomparer);
            Assert.AreEqual(arr, expected);
        }

        [Test]
        public void SolutionWithInterface_ComparerBubbleSortDescMaxElem_CorrectValues_PositiveTest()
        {
            IComparer icomparer = new BubbleSortDescMaxElem();
            int[][] arr = { new int[] { 1, 5 }, new int[] { 13, 2 }, new int[] { 14 } };
            int[][] expected = { new int[] { 14 }, new int[] { 13, 2 }, new int[] { 1, 5 } };
            SolutionWithInterface.BubbleSorting(arr, icomparer);
            Assert.AreEqual(arr, expected);
        }

        [Test]
        public void SolutionWithInterface_DelegateBubbleSortAscMaxElem_CorrectValues_PositiveTest()
        {
            int[][] arr = { new int[] { 1, 15, 11 }, new int[] { 6, 2 }, new int[] { 8 } };
            int[][] expected = { new int[] { 6, 2 }, new int[] { 8 }, new int[] { 1, 15, 11 } };
            SolutionWithInterface.BubbleSorting(arr, new DelegateHelper(new BubbleSortAscMaxElem()));
            Assert.AreEqual(arr, expected);
        }

        [Test]
        public void SolutionWithInterface_DelegateBubbleSortDescMaxElem_CorrectValues_PositiveTest()
        {
            int[][] arr = { new int[] { 1, 5 }, new int[] { 13, 2 }, new int[] { 14 } };
            int[][] expected = { new int[] { 14 }, new int[] { 13, 2 }, new int[] { 1, 5 } };
            SolutionWithInterface.BubbleSorting(arr, new DelegateHelper(new BubbleSortDescMaxElem()));
            Assert.AreEqual(arr, expected);
        }
        #endregion
    }

}
