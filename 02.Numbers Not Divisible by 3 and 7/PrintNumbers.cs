using System;

class PrintNumbers
{
    static void Main()
    {
        Console.WriteLine("Print numbers from 1 to n - not divisible by 3 and 7");
        Console.Write("Enter positive number n: ");
        int n = int.Parse(Console.ReadLine());
        int num = 1;
        while (num <= n)
        {
            if ((num % 3 != 0) && (num % 7 != 0) )
            {
                Console.Write("{0} ", num);
            }
            num++;
        }
        Console.WriteLine();
    }
}

