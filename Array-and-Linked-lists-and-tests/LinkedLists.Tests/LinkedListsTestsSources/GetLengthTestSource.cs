using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Tests.LinkedListsTestsSources
{
    public class GetLengthTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            int expectedNumber = 5;
            yield return new object[] { list, expectedNumber };


            list = new LinkedList(new int[] { 1, 2, -2, 5 });
            expectedNumber = 4;
            yield return new object[] { list, expectedNumber };


            yield return new object[]
            {
                new LinkedList(new int[] { 1 }),
                1,
            };

            yield return new object[]
            {
                new LinkedList(new int[] { }),
                0,
            };
        }
    }
}
