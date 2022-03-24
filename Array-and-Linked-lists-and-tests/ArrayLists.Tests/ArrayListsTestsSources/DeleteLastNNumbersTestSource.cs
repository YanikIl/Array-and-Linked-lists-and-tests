using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class DeleteLastNNumbersTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int n = 3;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2 });
            yield return new object[] { n, list, expectedList };


            n = 2;
            list = new ArrayList(new int[] { 1, 2, -2, 2, 5 });
            expectedList = new ArrayList(new int[] { 1, 2, -2});
            yield return new object[] { n, list, expectedList };


            yield return new object[]
            {
                2,
                new ArrayList(new int[] { 1, 2, 2 }),
                new ArrayList(new int[] { 1}),
            };

            yield return new object[]
            {
                0,
                new ArrayList(new int[] { 5}),
                new ArrayList(new int[] { 5}),
            };

            yield return new object[]
            {
                1,
                new ArrayList(new int[] { 5}),
                new ArrayList(new int[] { }),
            };
        }
    }

}
