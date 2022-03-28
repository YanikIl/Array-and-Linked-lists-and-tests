using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists.Tests.ArrayListsTestsSources
{
    public class DeleteByFirstValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 4, 5 });
            int expectedNumber = 2;
            yield return new object[] { value, list, expectedList, expectedNumber };


            value = 2;
            list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            expectedList = new ArrayList(new int[] { 1, 2, 2, 5 });
            expectedNumber = 1;
            yield return new object[] { value, list, expectedList, expectedNumber };


            yield return new object[]
            {
                5,
                new ArrayList(new int[] { 1, 2, 2 }),
                new ArrayList(new int[] { 1, 2, 2 }),
                -1
            };
        }
    }

}

