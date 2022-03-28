using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class GetMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int expectedMax = 5;
            yield return new object[] { list, expectedMax };

            list = new ArrayList(new int[] { 1, -2, 2, 2 });
            expectedMax = 2;
            yield return new object[] { list, expectedMax };


            yield return new object[]
            {
                new ArrayList(new int[] { 2, 2 }),
                2
            };


            yield return new object[]
            {
                new ArrayList(new int[] { -1}),
                -1
            };
        }
    }

}
