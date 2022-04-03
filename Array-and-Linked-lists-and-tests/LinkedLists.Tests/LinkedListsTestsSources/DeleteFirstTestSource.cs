using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Tests.LinkedListsTestsSources
{
    public class DeleteFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList expectedList = new LinkedList(new int[] { 2, 3, 4, 5 });
            yield return new object[] { list, expectedList };


            list = new LinkedList(new int[] { 1, -2, 2, 2, 5 });
            expectedList = new LinkedList(new int[] { -2, 2, 2, 5 });
            yield return new object[] { list, expectedList };


            yield return new object[]
            {
                new LinkedList(new int[] { 2, 2 }),
                new LinkedList(new int[] { 2 }),
            };

            yield return new object[]
            {
                new LinkedList(new int[] { 5}),
                new LinkedList(new int[] { }),
            };
        }
    }
}
