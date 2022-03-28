using System.Collections;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class GetIndexByMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int expectedIndexMax = 0;
            yield return new object[] { list, expectedIndexMax };


            yield return new object[]
            {
                new ArrayList(new int[] { 2, 2 }),
                0
            };


            yield return new object[]
            {
                new ArrayList(new int[] { -1}),
                0
            };

            yield return new object[]
            {
                new ArrayList(new int[] { -1, 3, -2}),
                2
            };
        }
    }

}
