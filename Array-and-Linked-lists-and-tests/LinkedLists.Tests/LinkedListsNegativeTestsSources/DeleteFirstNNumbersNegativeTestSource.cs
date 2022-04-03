using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Tests.LinkedListsNegativeTestsSources
{
    public class DeleteFirstNNumbersNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            int n = 11;
            LinkedList list = new LinkedList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { n, list };

            n = -1;
            list = new LinkedList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { n, list };

            n = 6;
            list = new LinkedList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { n, list };

        }
    }
}
