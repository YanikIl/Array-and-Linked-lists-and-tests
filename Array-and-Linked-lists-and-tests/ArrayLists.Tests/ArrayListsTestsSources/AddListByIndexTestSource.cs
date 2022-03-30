using System.Collections;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class AddListByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            ArrayList list = new ArrayList(new int[] { 2, 5 });
            ArrayList actuallist = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            ArrayList expectedlist = new ArrayList(new int[] { 2, 5, 1, 2, 2, 2, 5 });
            yield return new object[] { index, list, actuallist, expectedlist };

            index = 2;
            list = new ArrayList(new int[] { 5 });
            actuallist = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            expectedlist = new ArrayList(new int[] { 1, 2, 5, 2, 2, 5 });
            yield return new object[] { index, list, actuallist, expectedlist };

            index = 4;
            list = new ArrayList(new int[] { 5 });
            actuallist = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            expectedlist = new ArrayList(new int[] { 1, 2, 2, 2, 5, 5 });
            yield return new object[] { index, list, actuallist, expectedlist };

        }
    }
}
