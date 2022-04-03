using NUnit.Framework;
using System;
using System.Collections;
using LinkedLists.Tests.LinkedListsTestsSources;
using LinkedLists.Tests.LinkedListsNegativeTestsSources;

namespace LinkedLists.Tests
{
    public class LinkedListsTests
    {
        #region AddToEndTest
        [TestCaseSource(typeof(AddToEndTestSource))]
        public void AddToEndTest(int value, LinkedList list, LinkedList expectedList)
        {
            list.AddToEnd(value);
            LinkedList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }
        #endregion

        #region AddToStartTest
        [TestCaseSource(typeof(AddToStartTestSource))]
        public void AddToStartTest(int value, LinkedList list, LinkedList expectedList)
        {
            list.AddToStart(value);
            LinkedList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }
        #endregion

        #region AddByIndexTest
        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(int index, int value, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            list.AddByIndex(index, value);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddByIndexNegativeTestSource))]
        public void AddByIndexTest_WhenIndexLessZeroOrMoreOrEqualsLength_ShouldThrowIndexOutOfRangeException(int index, int value, LinkedList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.AddByIndex(index, value));
        }
        #endregion

        #region DeleteLastTest
        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(LinkedList list, LinkedList expectedList)
        {
            list.DeleteLast();
            LinkedList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteLastNegativeTestSource))]
        public void DeleteLastNegativeTest_WhenLengthEqualsZero_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteLast());
        }

        #endregion

        #region DeleteFirstTest
        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(LinkedList list, LinkedList expectedList)
        {
            list.DeleteFirst();
            LinkedList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFirstNegativeTestSource))]
        public void DeleteFirstNegativeTest_WhenLengthEqualsZero_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFirst());
        }
        #endregion


        #region DeleteByIndexTest
        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(int index, LinkedList list, LinkedList expectedList)
        {
            list.DeleteByIndex(index);
            LinkedList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteByIndexNegativeTestSource))]
        public void DeleteByIndexNegativeTest_WhenIndexLessZeroOrMoreOrEqualsLength_ShouldThrowIndexOutOfRangeException(int index, LinkedList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteByIndex(index));
        }

        [TestCaseSource(typeof(DeleteByIndexNegativeTestSourceForException))]
        public void DeleteByIndexNegativeTest_WhenLengthEqualsZero_ShouldThrowException(int index, LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteByIndex(index));
        }
        #endregion

        #region DeleteLastNNumbersTest
        [TestCaseSource(typeof(DeleteLastNNumbersTestSource))]
        public void DeleteLastNNumbersTest(int n, LinkedList list, LinkedList expectedList)
        {
            list.DeleteLastNNumbers(n);
            LinkedList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteLastNNumbersNegativeTestSource))]
        public void DeleteLastNNumbersNegativeTest_WhenNLessZeroOrMoreLength_ShouldThrowArgumentOutOfRangeException(int n, LinkedList list)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => list.DeleteLastNNumbers(n));
        }
        #endregion

        #region DeleteFirstNNumbersTest
        [TestCaseSource(typeof(DeleteFirstNNumbersTestSource))]
        public void DeleteFirstNNumbersTest(int n, LinkedList list, LinkedList expectedList)
        {
            list.DeleteFirstNNumbers(n);
            LinkedList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFirstNNumbersNegativeTestSource))]
        public void DeleteFirstNNumbersNegativeTestSource_WhenNLessZeroOrMoreLength_ShouldThrowArgumentOutOfRangeException(int n, LinkedList list)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => list.DeleteFirstNNumbers(n));
        }
        #endregion

        #region DeleteByIndexNNumbersTest
        [TestCaseSource(typeof(DeleteByIndexNNumbersTestSource))]
        public void DeleteByIndexNNumbersTest(int index, int n, LinkedList list, LinkedList expectedList)
        {
            list.DeleteByIndexNNumbers(index, n);
            LinkedList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteByIndexNNumbersNegativeTestSourceForIndexOutOfRangeException))]
        public void DeleteByIndexNNumbersNegativeTest_WhenIndexLessZeroOrMoreLengthOrMoreLengthMinusN_ShouldThrowIndexOutOfRangeException(int index, int n, LinkedList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteByIndexNNumbers(index, n));
        }
        #endregion

        #region GetLengthTest
        [TestCaseSource(typeof(GetLengthTestSource))]
        public void GetLengthTest(LinkedList list, int expectedNumber)
        {
            int actualNumber = list.GetLength();

            Assert.AreEqual(expectedNumber, actualNumber);
        }
        #endregion
    }
}