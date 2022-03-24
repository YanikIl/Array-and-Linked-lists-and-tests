using System;
using ArrayLists;
public class Class1
{
    static void Main()
    {
        int[] mas = new int[] { 5, 6, -4, 3, 2, 9 };
        ArrayList arrayLists = new ArrayList(mas);
        arrayLists.BubbleSortAscending();
        Console.WriteLine(arrayLists);
    }
}