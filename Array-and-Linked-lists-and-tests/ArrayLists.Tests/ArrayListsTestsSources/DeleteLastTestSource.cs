using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class DeleteLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 4 });
            yield return new object[] { list, expectedList };


            list = new ArrayList(new int[] { 1, -2, 2, 2, 5 });
            expectedList = new ArrayList(new int[] { 1, -2, 2, 2 });
            yield return new object[] { list, expectedList };


            yield return new object[]
            {
                new ArrayList(new int[] { 2, 2 }),
                new ArrayList(new int[] { 2 }),
            };

            yield return new object[]
            {
                new ArrayList(new int[] { 5}),
                new ArrayList(new int[] { }),
            };

            yield return new object[]
            {
                new ArrayList(new int[] { }),
                new ArrayList(new int[] { }),
            };
        }
    }

}
