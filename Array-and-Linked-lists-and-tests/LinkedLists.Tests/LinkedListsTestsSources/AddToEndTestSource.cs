using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Tests.LinkedListsTestsSources
{
    public class AddToEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList expectedList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 3 });
            yield return new object[] { value, list, expectedList };


            value = 2;
            list = new LinkedList(new int[] { 1, 2, 2, 2, 5 });
            expectedList = new LinkedList(new int[] { 1, 2, 2, 2, 5, 2 });
            yield return new object[] { value, list, expectedList };


            yield return new object[]
            {
                5,
                new LinkedList(new int[] { 1, 2, 2 }),
                new LinkedList(new int[] { 1, 2, 2, 5 }),
            };
        }
    }
}
