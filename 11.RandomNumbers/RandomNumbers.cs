using System;

class RandomNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter Min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter Max: ");
        int max = int.Parse(Console.ReadLine());
        if (min <= max)
        {
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.Write(random.Next(min, max + 1) + " ");
            }

            Console.WriteLine();
        }
    }
}

