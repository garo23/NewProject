using System;

class NumsAndTowns
{
    public void NumAndTown()
    {
        int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19 };
        foreach (int i in numbers)
        {
            Console.Write(" " + i);
        }
        Console.WriteLine();
        String[] towns = { "Sofia", "Plovdiv", "Varna", "Stara Zagora" };
        foreach(String town in towns)
        {
            Console.Write(" " + town);
        }
    }
}