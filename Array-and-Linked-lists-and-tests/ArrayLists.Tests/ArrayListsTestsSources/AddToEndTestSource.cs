using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class AddToEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 4, 5, 3});
            yield return new object[] { value, list, expectedList};


            value = 2;
            list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            expectedList = new ArrayList(new int[] { 1, 2, 2, 2, 5, 2 });
            yield return new object[] { value, list, expectedList};


            yield return new object[]
            {
                5,
                new ArrayList(new int[] { 1, 2, 2 }),
                new ArrayList(new int[] { 1, 2, 2, 5 }),
            };

            yield return new object[]
            {
                5,
                new ArrayList(new int[] { }),
                new ArrayList(new int[] { 5 }),
            };
        }
    }

}
