using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Tests.LinkedListsNegativeTestsSources
{
    public class DeleteByIndexNegativeTestSourceForException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            int index = 11;
            LinkedList list = new LinkedList(new int[] {});
            yield return new object[] { index, list };

        }
    }
}
