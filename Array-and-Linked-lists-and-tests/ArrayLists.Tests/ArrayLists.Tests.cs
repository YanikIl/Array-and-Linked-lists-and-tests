using NUnit.Framework;
using System;
using System.Collections;
using ArrayLists.Tests.ArrayListsTestsSources;
using ArrayLists.Tests.ArrayListNegativeTestsSources;

namespace ArrayLists.Tests
{
    public class ArrayListsTests
    {
        #region AddToEndTest
        [TestCaseSource(typeof(AddToEndTestSource))]
        public void AddToEndTest(int value, ArrayList list, ArrayList expectedList)
        {
            list.AddToEnd(value);
            ArrayList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }
        #endregion

        #region AddToStartTest
        [TestCaseSource(typeof(AddToStartTestSource))]
        public void AddToStartTest(int value, ArrayList list, ArrayList expectedList)
        {
            list.AddToStart(value);
            ArrayList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }
        #endregion

        #region AddByIndexTest
        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(int index, int value, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            list.AddByIndex(index, value);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddByIndexNegativeTestSource))]
        public void AddByIndexTest_WhenIndexLessZeroOrMoreLength_ShouldThrowIndexOutOfRangeException(int index, int value, ArrayList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.AddByIndex(index, value));
        }
        #endregion

        #region DeleteLastTest
        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(ArrayList list, ArrayList expectedList)
        {
            list.DeleteLast();
            ArrayList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteLastNegativeTestSource))]
        public void DeleteLastNegativeTest_WhenLengthEqualsZero_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteLast());
        }

        #endregion

        #region DeleteFirstTest
        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(ArrayList list, ArrayList expectedList)
        {
            list.DeleteFirst();
            ArrayList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFirstNegativeTestSource))]
        public void DeleteFirstNegativeTest_WhenLengthEqualsZero_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFirst());
        }
        #endregion


        #region DeleteByIndexTest
        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(int index, ArrayList list, ArrayList expectedList)
        {
            list.DeleteByIndex(index);
            ArrayList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteByIndexNegativeTestSource))]
        public void DeleteByIndexNegativeTest_WhenIndexLessZeroOrMoreLength_ShouldThrowIndexOutOfRangeException(int index, ArrayList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteByIndex(index));
        }
        #endregion

        #region DeleteLastNNumbersTest
        [TestCaseSource(typeof(DeleteLastNNumbersTestSource))]
        public void DeleteLastNNumbersTest(int n, ArrayList list, ArrayList expectedList)
        {
            list.DeleteLastNNumbers(n);
            ArrayList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteLastNNumbersNegativeTestSource))]
        public void DeleteLastNNumbersNegativeTest_WhenNLessZeroOrMoreLength_ShouldThrowArgumentOutOfRangeException(int n, ArrayList list)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => list.DeleteLastNNumbers(n));
        }
        #endregion

        #region DeleteFirstNNumbersTest
        [TestCaseSource(typeof(DeleteFirstNNumbersTestSource))]
        public void DeleteFirstNNumbersTest(int n, ArrayList list, ArrayList expectedList)
        {
            list.DeleteFirstNNumbers(n);
            ArrayList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFirstNNumbersNegativeTestSource))]
        public void DeleteFirstNNumbersNegativeTestSource_WhenNLessZeroOrMoreLength_ShouldThrowArgumentOutOfRangeException(int n, ArrayList list)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => list.DeleteFirstNNumbers(n));
        }
        #endregion

        #region DeleteByIndexNNumbersTest
        [TestCaseSource(typeof(DeleteByIndexNNumbersTestSource))]
        public void DeleteByIndexNNumbersTest(int index, int n, ArrayList list, ArrayList expectedList)
        {
            list.DeleteByIndexNNumbers(index, n);
            ArrayList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteByIndexNNumbersNegativeTestSourceForArgumentException))]
        public void DeleteByIndexNNumbersNegativeTest_WhenNPlusIndexMoreLength_ShouldThrowArgumentException(int index, int n, ArrayList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteByIndexNNumbers(index, n));
        }

        [TestCaseSource(typeof(DeleteByIndexNNumbersNegativeTestSourceForArgumentOutOfRangeException))]
        public void DeleteByIndexNNumbersNegativeTest_WhenNLessLength_ShouldThrowArgumentOutOfRangeException(int index, int n, ArrayList list)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => list.DeleteByIndexNNumbers(index, n));
        }

        [TestCaseSource(typeof(DeleteByIndexNNumbersNegativeTestSourceForIndexOutOfRangeException))]
        public void DeleteByIndexNNumbersNegativeTest_WhenIndexLessZeroOrMoreOrEqualsLength_ShouldThrowIndexOutOfRangeException(int index, int n, ArrayList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteByIndexNNumbers(index, n));
        }
        #endregion

        #region GetLengthTest
        [TestCaseSource(typeof(GetLengthTestSource))]
        public void GetLengthTest( ArrayList list, int expectedNumber)
        {
            int actualNumber = list.GetLength();

            Assert.AreEqual(expectedNumber, actualNumber);
        }
        #endregion



        #region IndexValueTest
        [TestCaseSource(typeof(IndexValueTestSource))]
        public void IndexValueTest(int index, ArrayList list, int expectedValue)
        {
            int value = list.IndexValue(index);

            Assert.AreEqual(value, expectedValue);
        }

        [TestCaseSource(typeof(IndexValueNegativeTestSource))]
        public void IndexValueNegativeTestSource_WhenNIndexLessZeroOrMoreOrEqualsLength_ShouldThrowIndexOutOfRangeException(int index, ArrayList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.IndexValue(index));
        }

        [TestCaseSource(typeof(IndexValueNegativeTestSourceForException))]
        public void IndexValueNegativeTestSource_WhenLengthEqualsZero_ShouldThrowException(int index, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.IndexValue(index));
        }
        #endregion

        #region GetFirstIndexByValueTest
        [TestCaseSource(typeof(GetFirstIndexByValueTestSource))]
        public void GetFirstIndexByValueTest(int value, ArrayList list, int expectedIndex)
        {
            int index = list.GetFirstIndexByValue(value);

            Assert.AreEqual(index, expectedIndex);
        }
        #endregion

        #region ChangeValueByIndexTest
        [TestCaseSource(typeof(ChangeValueByIndexTestSource))]
        public void ChangeValueByIndexTest(int index, int value, ArrayList list, ArrayList expectedList)
        {
            list.ChangeValueByIndex(index, value);
            ArrayList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }
        #endregion

        #region ReverseTest
        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(ArrayList list, ArrayList expectedList)
        {
            list.Reverse();
            ArrayList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }
        #endregion

        #region GetMaxTest
        [TestCaseSource(typeof(GetMaxTestSource))]
        public void GetMaxTest(ArrayList list, int expectedMax)
        {
            int max = list.GetMax();

            Assert.AreEqual(expectedMax, max);
        }

        [TestCaseSource(typeof(GetMaxNegativeTestSource))]
        public void GetMaxNegativeTestSource_WhenLengthEqualsZero_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.GetMax());
        }
        #endregion

        #region GetMinTest
        [TestCaseSource(typeof(GetMinTestSource))]
        public void GetMinTest(ArrayList list, int expectedMin)
        {
            int min = list.GetMin();

            Assert.AreEqual(expectedMin, min);
        }
        [TestCaseSource(typeof(GetMinNegativeTestSource))]
        public void GetMinNegativeTestSource_WhenLengthEqualsZero_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.GetMin());
        }
        #endregion

        #region GetIndexByMaxTest
        [TestCaseSource(typeof(GetIndexByMaxTestSource))]
        public void GetIndexByMaxTest(ArrayList list, int expectedIndexMax)
        {
            int indexmax = list.GetIndexByMax();

            Assert.AreEqual(expectedIndexMax, indexmax);
        }

        [TestCaseSource(typeof(GetIndexByMaxNegativeTestSource))]
        public void GetIndexByMaxNegativeTestSource_WhenLengthEqualsZero_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.GetIndexByMax());
        }
        #endregion

        #region GetIndexByMinTest
        [TestCaseSource(typeof(GetIndexByMinTestSource))]
        public void GetIndexByMinTest(ArrayList list, int expectedIndexMin)
        {
            int indexmin = list.GetIndexByMin();

            Assert.AreEqual(expectedIndexMin, indexmin);
        }

        [TestCaseSource(typeof(GetIndexByMinNegativeTestSource))]
        public void GetIndexByMinNegativeTestSource_WhenLengthEqualsZero_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.GetIndexByMin());
        }
        #endregion

        #region BubbleSortAscendingTest
        [TestCaseSource(typeof(BubbleSortAscendingTestSource))]
        public void BubbleSortAscendingTest(ArrayList list, ArrayList expectedList)
        {
            list.BubbleSortAscending();

            Assert.AreEqual(expectedList, list);
        }
        #endregion

        #region BubbleSortDescendingTest
        [TestCaseSource(typeof(BubbleSortDescendingTestSource))]
        public void BubbleSortDescendingTest(ArrayList list, ArrayList expectedList)
        {
            list.BubbleSortDescending();

            Assert.AreEqual(expectedList, list);
        }
        #endregion



        #region DeleteByFirstValue
        [TestCaseSource(typeof(DeleteByFirstValueTestSource))]
        public void DeleteByFirstValueTest(int value, ArrayList list, ArrayList expectedList, int expectedNumber)
        {
            int actualNumber = list.DeleteByFirstValue(value);

            ArrayList actualList = list;

            Assert.AreEqual(expectedNumber, actualNumber);
            Assert.AreEqual(expectedList, actualList);
        }
        [TestCaseSource(typeof(DeleteByFirstValueNegativeTestSource))]
        public void DeleteByFirstValueNegativeTestSource_WhenLengthEqualsZero_ShouldThrowException(int value, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteByFirstValue(value));
        }
        #endregion

        #region DeleteAllByValueTest
        [TestCaseSource(typeof(DeleteAllByValueTestSource))]
        public void DeleteAllByValueTest(int value, ArrayList list, ArrayList expectedList, int expectedNumber)
        {
            int actualNumber = list.DeleteAllByValue(value);

            ArrayList actualList = list;

            Assert.AreEqual(expectedNumber, actualNumber);
            Assert.AreEqual(expectedList, actualList);
        }
        [TestCaseSource(typeof(DeleteAllByValueNegativeTestSource))]
        public void DeleteAllByValueNegativeTestSource_WhenLengthEqualsZero_ShouldThrowException(int value, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteAllByValue(value));
        }
        #endregion

        #region конструкторы
        #endregion

        #region AddListToEnd
        #endregion

        #region AddListToStart
        [TestCaseSource(typeof(AddListToStartTestSource))]
        public void AddListToBeginningTest(ArrayList list, ArrayList actualList, ArrayList expectedList)
        {
            actualList.AddListToStart(list);
            Assert.AreEqual(expectedList, actualList);
        }
        #endregion

        #region AddListByIndex
        #endregion
    }
}