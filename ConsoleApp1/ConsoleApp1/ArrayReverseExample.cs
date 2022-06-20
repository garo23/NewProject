using System;

class ArrayReverse
{
    public void ReversedArray()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int length = array.Length;
        int[] reversed = new int[length];

        for (int i = 0; i < length; i++)
        {
            reversed[length - i - 1] = array[i];
        }
        for(int i = 0; i < length; i++)
        {
            Console.Write(reversed[i] + " ");
        }
    }
}