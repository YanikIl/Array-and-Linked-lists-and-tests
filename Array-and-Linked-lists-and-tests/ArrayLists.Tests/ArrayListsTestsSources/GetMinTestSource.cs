using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class GetMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int expectedMin = 1;
            yield return new object[] { list, expectedMin };

            list = new ArrayList(new int[] { 1, -2, 2, 2 });
            expectedMin = -2;
            yield return new object[] { list, expectedMin };


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
