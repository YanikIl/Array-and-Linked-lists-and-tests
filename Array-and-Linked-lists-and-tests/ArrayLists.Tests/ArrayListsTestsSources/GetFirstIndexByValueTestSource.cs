using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class GetFirstIndexByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 0;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int expectedIndex = -1;
            yield return new object[] { value, list, expectedIndex };


            value = 2;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            expectedIndex = 1;
            yield return new object[] { value, list, expectedIndex };


            value = 2;
            list = new ArrayList(new int[] { 1, 2, 3, 2, 2 });
            expectedIndex = 1;
            yield return new object[] { value, list, expectedIndex };

            yield return new object[]
            {
                5,
                new ArrayList(new int[] { 1, 2, 3, 4, 5, 5 }),
                4
        };
        }
    }

}

