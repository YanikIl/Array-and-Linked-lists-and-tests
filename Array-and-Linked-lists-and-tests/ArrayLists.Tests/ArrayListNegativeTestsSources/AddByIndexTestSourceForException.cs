using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class AddByIndexTestSourceForException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            int index = 9;
            int value = 1;
            ArrayList list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, value, list };

            index = -1;
            value = 1;
            list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, value, list };

            index = 5;
            value = 1;
            list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            yield return new object[] { index, value, list };

        }
    }
}
