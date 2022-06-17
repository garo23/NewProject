using System;

class Sum
{
    public void SumFrom1ToN()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int num = 1;
        int sum = 1;
        Console.Write("The sum 1");
        while (num < n)
        {
            num++;
            sum += num;
            Console.Write(" + " + num);
        }
        Console.WriteLine(" = " + sum);
    }
}