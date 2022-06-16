
/*
Description:
You have an array of numbers.
Your task is to sort ascending odd numbers but even numbers must be on their places.

Zero isn't an odd number and you don't need to move it. If you have an empty array, you need to return it.

Example

sortArray([5, 3, 2, 8, 1, 4]) == [1, 3, 2, 8, 5, 4]
*/

using System;
using System.Collections.Generic;

public class Kata
{
    public static int[] SortArray(int[] array)
    {
        List<int> oddlist = new List<int>();

        foreach (var number in array)
        {
            if (number % 2 != 0)
                oddlist.Add(number);
        }
        int[] odd = oddlist.ToArray();
        Array.Sort(odd);


        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                array[i] = odd[j];
                j++;
            }
        }
        return array;
    }
}
