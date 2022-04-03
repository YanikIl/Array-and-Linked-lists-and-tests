using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Tests.LinkedListsTestsSources
{
    public class DeleteByIndexNNumbersTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            int n = 3;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList expectedList = new LinkedList(new int[] { 4, 5 });
            yield return new object[] { index, n, list, expectedList };

            index = 2;
            n = 2;
            list = new LinkedList(new int[] { 1, 2, -2, 2, 5 });
            expectedList = new LinkedList(new int[] { 1, 2, 5 });
            yield return new object[] { index, n, list, expectedList };


            yield return new object[]
            {
                0,
                1,
                new LinkedList(new int[] { 1 }),
                new LinkedList(new int[] { }),
            };

            yield return new object[]
            {
                0,
                0,
                new LinkedList(new int[] { 5}),
                new LinkedList(new int[] { 5}),
            };
        }
    }
}
