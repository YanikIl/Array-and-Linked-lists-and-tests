using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Tests.LinkedListsNegativeTestsSources
{
    public class DeleteByIndexNNumbersNegativeTestSourceForIndexOutOfRangeException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            int n = 9;
            LinkedList list = new LinkedList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, n, list };

            index = -3;
            n = 3;
            list = new LinkedList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, n, list };

            index = 10;
            n = 2;
            list = new LinkedList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, n, list };

            index = 13;
            n = 6;
            list = new LinkedList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, n, list };

        }
    }
}
