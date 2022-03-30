using System.Collections;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class AddListByIndexNegativeTestSourceForArgumentOutOfRangeException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = -1;
            ArrayList list = new ArrayList(new int[] { 2, 3});
            ArrayList actuallist = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, list, actuallist };


            index = 11;
            list = new ArrayList(new int[] { 2, 3 });
            actuallist = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, list, actuallist };

            index = 5;
            list = new ArrayList(new int[] { 2, 3 });
            actuallist = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, list, actuallist };
        }
    }
}
