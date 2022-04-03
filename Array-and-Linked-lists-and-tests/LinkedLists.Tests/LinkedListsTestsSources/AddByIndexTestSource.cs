using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Tests.LinkedListsTestsSources
{
    public class AddByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            int value = 3;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList expectedList = new LinkedList(new int[] { 3, 1, 2, 3, 4, 5 });
            yield return new object[] { index, value, list, expectedList };

            index = 1;
            value = 2;
            list = new LinkedList(new int[] { 1, 2, 2, 2, 5 });
            expectedList = new LinkedList(new int[] { 1, 2, 2, 2, 2, 5 });
            yield return new object[] { index, value, list, expectedList };
        }
    }
}
