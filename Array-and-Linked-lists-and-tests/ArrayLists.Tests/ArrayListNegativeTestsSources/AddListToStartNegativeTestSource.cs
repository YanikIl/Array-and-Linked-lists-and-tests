using System.Collections;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class AddListToStartNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            ArrayList list = new ArrayList(new int[] { });
            ArrayList actuallist = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { list, actuallist };

        }
    }
}
