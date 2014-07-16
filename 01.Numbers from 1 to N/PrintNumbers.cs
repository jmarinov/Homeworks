using System;

class PrintNumbers
{
    static void Main()
    {
        Console.WriteLine("Print numbers from 1 to n");
        Console.Write("Enter positive number n: ");
        int n = int.Parse(Console.ReadLine());
        int num = 1;
        while (num <= n)
        {
            Console.Write("{0} ", num);
            num++;
        }
        Console.WriteLine();
    }
}

