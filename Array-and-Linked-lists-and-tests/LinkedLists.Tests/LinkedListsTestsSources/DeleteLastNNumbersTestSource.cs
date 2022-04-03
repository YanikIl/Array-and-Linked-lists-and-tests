using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Tests.LinkedListsTestsSources
{
    public class DeleteLastNNumbersTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int n = 3;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList expectedList = new LinkedList(new int[] { 1, 2 });
            yield return new object[] { n, list, expectedList };


            n = 2;
            list = new LinkedList(new int[] { 1, 2, -2, 2, 5 });
            expectedList = new LinkedList(new int[] { 1, 2, -2 });
            yield return new object[] { n, list, expectedList };


            yield return new object[]
            {
                2,
                new LinkedList(new int[] { 1, 2, 2 }),
                new LinkedList(new int[] { 1}),
            };

            yield return new object[]
            {
                0,
                new LinkedList(new int[] { 5}),
                new LinkedList(new int[] { 5}),
            };

            yield return new object[]
            {
                1,
                new LinkedList(new int[] { 5}),
                new LinkedList(new int[] { }),
            };
        }
    }
}
