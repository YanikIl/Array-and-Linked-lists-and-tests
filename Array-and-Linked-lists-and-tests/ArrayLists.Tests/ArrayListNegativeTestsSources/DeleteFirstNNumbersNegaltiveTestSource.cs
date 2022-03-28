using System.Collections;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class DeleteFirstNNumbersNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            int n = 11;
            ArrayList list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { n, list };

            n = -1;
            list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { n, list };

            n = 6;
            list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { n, list };

        }
    }
}