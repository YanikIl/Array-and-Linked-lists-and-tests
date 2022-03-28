using System.Collections;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class GetIndexByMaxNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[]
            {
                new ArrayList(new int[] { })
            };
        }
    }

}
