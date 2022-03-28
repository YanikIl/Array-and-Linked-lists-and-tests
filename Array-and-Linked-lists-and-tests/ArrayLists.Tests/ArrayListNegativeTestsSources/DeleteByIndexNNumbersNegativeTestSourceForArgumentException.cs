using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists.Tests.ArrayListNegativeTestsSources
{
    public class DeleteByIndexNNumbersNegativeTestSourceForArgumentException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            int n = 11;
            ArrayList list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, n, list };

            index = 2;
            n = 11;
            list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, n, list };

        }
    }
}

