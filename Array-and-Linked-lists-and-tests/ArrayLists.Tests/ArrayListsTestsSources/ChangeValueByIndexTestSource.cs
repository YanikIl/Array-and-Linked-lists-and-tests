using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class ChangeValueByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            int value = 0;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 0, 2, 3, 4, 5 });
            yield return new object[] { index, value, list, expectedList };

            index = 4;
            value = 6;
            list = new ArrayList(new int[] { 1, -2, 2, 2, 5 });
            expectedList = new ArrayList(new int[] { 1, -2, 2, 2, 6 });
            yield return new object[] { index, value, list, expectedList };


            yield return new object[]
            {
                1,
                4,
                new ArrayList(new int[] { 2, 2 }),
                new ArrayList(new int[] { 2, 4}),
            };

        }
    }

}

