using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class IndexValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 3;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int expectedValue = 4;
            yield return new object[] { index, list, expectedValue };


            index = 2;
            list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            expectedValue = 2;
            yield return new object[] { index, list, expectedValue };


            yield return new object[]
            {
                0,
                new ArrayList(new int[] { 1, 2, 2 }),
                1
            };

            yield return new object[]
            {
                0,
                new ArrayList(new int[] { -2}),
                -2,
            };
        }
    }

}