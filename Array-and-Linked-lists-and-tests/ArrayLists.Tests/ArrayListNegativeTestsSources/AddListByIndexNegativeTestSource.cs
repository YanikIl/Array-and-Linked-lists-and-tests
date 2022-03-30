using System.Collections;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class AddListByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            ArrayList list = new ArrayList(new int[] { });
            ArrayList actuallist = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] {index, list, actuallist };

        }
    }
}