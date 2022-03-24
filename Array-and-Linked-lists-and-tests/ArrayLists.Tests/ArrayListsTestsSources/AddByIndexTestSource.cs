using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class AddByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 0;
            int index = 3;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 3, 1, 2, 3, 4, 5 });
            yield return new object[] { value, index, list, expectedList };


            value = 1;
            index = 2;
            list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            expectedList = new ArrayList(new int[] { 1, 2, 2, 2, 2, 5 });
            yield return new object[] { value, index, list, expectedList };


            yield return new object[]
            {
                3,
                5,
                new ArrayList(new int[] { 1, 2, 2 }),
                new ArrayList(new int[] { 1, 2, 2, 5 }),
            };

            yield return new object[]
            {
                0,
                5,
                new ArrayList(new int[] { }),
                new ArrayList(new int[] { 5 }),
            };
        }
    }

}