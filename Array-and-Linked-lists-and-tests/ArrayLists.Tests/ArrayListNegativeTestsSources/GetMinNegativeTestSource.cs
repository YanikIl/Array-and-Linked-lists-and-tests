using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class GetMinNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[]
            {
                new ArrayList(new int[] { })
            };
        }
    }

}