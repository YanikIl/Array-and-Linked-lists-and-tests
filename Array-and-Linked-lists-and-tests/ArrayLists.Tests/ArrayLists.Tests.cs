using NUnit.Framework;
using System.Collections;
using ArrayLists.Tests.ArrayListsTestsSources;

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
            list.AddByIndex(index, value);
            ArrayList actualList = list;

            Assert.AreEqual(expectedList, actualList);
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
        #endregion

        #region DeleteFirstTest
        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(ArrayList list, ArrayList expectedList)
        {
            list.DeleteFirst();
            ArrayList actualList = list;

            Assert.AreEqual(expectedList, actualList);
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
        #endregion

        #region DeleteLastNNumbersTest
        [TestCaseSource(typeof(DeleteLastNNumbersTestSource))]
        public void DeleteLastNNumbersTest(int n, ArrayList list, ArrayList expectedList)
        {
            list.DeleteLastNNumbers(n);
            ArrayList actualList = list;

            Assert.AreEqual(expectedList, actualList);
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
        #endregion

        #region DeleteByIndexNNumbersTest
        [TestCaseSource(typeof(DeleteByIndexNNumbersTestSource))]
        public void DeleteByIndexNNumbersTest(int index, int n, ArrayList list, ArrayList expectedList)
        {
            list.DeleteByIndexNNumbers(index, n);
            ArrayList actualList = list;

            Assert.AreEqual(expectedList, actualList);
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
        public void IndexValueTest(int index, ArrayList list)
        {
            int value = list.IndexValue(index);

            Assert.AreEqual(value, expectedValue);
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
        public void ReverseTest( ArrayList list, ArrayList expectedList)
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
        #endregion


        #region GetMinTest
        [TestCaseSource(typeof(GetMinTestSource))]
        public void GetMinTest(ArrayList list, int expectedMin)
        {
            int min = list.GetMin();

            Assert.AreEqual(expectedMin, min);
        }
        #endregion

        #region GetIndexByMaxTest
        [TestCaseSource(typeof(GetIndexByMaxTestSource))]
        public void GetIndexByMaxTest(ArrayList list, int expectedIndexMax)
        {
            int indexmax = list.GetIndexByMax();

            Assert.AreEqual(expectedIndexMax, indexmax);
        }
        #endregion

        #region GetIndexByMinTest
        [TestCaseSource(typeof(GetIndexByMinTestSource))]
        public void GetIndexByMinTest(ArrayList list, int expectedIndexMin)
        {
            int indexmin = list.GetIndexByMin();

            Assert.AreEqual(expectedIndexMin, indexmin);
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
        #endregion
    }
}