using System.Collections;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class BubbleSortAscendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { list, expectedList };


            yield return new object[]
            {
                new ArrayList(new int[] { 2, 2 }),
                new ArrayList(new int[] { 2, 2 }),
            };


            yield return new object[]
            {
                new ArrayList(new int[] { -1}),
                new ArrayList(new int[] { -1}),
            };

            yield return new object[]
            {
                new ArrayList(new int[] { -1, 3, -2}),
                new ArrayList(new int[] { -2, -1, 3}),
            };

            yield return new object[]
            {
                new ArrayList(new int[] { }),
                new ArrayList(new int[] { }),
            };
        }
    }
}
