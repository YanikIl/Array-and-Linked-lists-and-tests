using System.Collections;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class AddListToEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            ArrayList list = new ArrayList(new int[] { 2, 5 });
            ArrayList actuallist = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            ArrayList expectedlist = new ArrayList(new int[] {1, 2, 2, 2, 5, 2, 5 });
            yield return new object[] { list, actuallist, expectedlist };

            list = new ArrayList(new int[] { 5 });
            actuallist = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            expectedlist = new ArrayList(new int[] { 1, 2, 2, 2, 5, 5 });
            yield return new object[] { list, actuallist, expectedlist };

        }
    }
}