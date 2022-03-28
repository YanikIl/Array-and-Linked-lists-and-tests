using System.Collections;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class DeleteByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            int index = 11;
            ArrayList list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, list };

            index = -1;
            list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, list };


        }
    }
}
