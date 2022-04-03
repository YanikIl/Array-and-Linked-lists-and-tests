using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Tests.LinkedListsNegativeTestsSources
{
    public class AddByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 9;
            int value = 1;
            LinkedList list = new LinkedList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, value, list };

            index = -1;
            value = 1;
            list = new LinkedList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, value, list };

            index = 5;
            value = 1;
            list = new LinkedList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, value, list };

            yield return new object[]
            {
                0,
                5,
                new LinkedList(new int[] { 1}),
                new LinkedList(new int[] { 5, 1 }),
            };
        }
    }
}
