using System.Collections;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class ChangeValueByIndexNegativeTestSourceForException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            int value = 5;
            ArrayList list = new ArrayList(new int[] { });
            ArrayList actuallist = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, value, list, actuallist };

        }
    }
}
