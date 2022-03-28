using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists.Tests.ArrayListNegativeTestsSources
{
    public class DeleteByIndexNNumbersNegativeTestSourceForArgumentOutOfRangeException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 5;
            int n = -1;
            ArrayList list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, n, list };

        }
    }
}