using System.Collections;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class IndexValueNegativeTestSourceForException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            int index = 1;
            ArrayList list = new ArrayList(new int[] { });
            yield return new object[] { index, list };

        }
    }
}
