using System;

class Symmetric
{
    public void SymmetricArr()
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Enter the values of the array:");

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        bool symmetric = true;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != array[n - i - 1])
            {
                symmetric = false;
                break;
            }
        }
        Console.WriteLine("Is symmetric? {0}", symmetric);
    }
}