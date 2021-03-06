using System.Collections;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class IndexValueNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            int index = -1;
            ArrayList list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, list };

            index = 10;
            list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, list };

            index = 5;
            list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, list };
        }
    }
}

