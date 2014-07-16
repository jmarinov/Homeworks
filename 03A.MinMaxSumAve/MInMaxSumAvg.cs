using System;

class Program
{
    static void Main()
    {
        Console.Write("Insert number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert numbers: ");
        decimal[] numbers = new decimal[n];
        decimal min = decimal.MaxValue;
        decimal max = decimal.MinValue;
        decimal sum = 0;
        double avg = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            numbers[i] = num;
        }

        foreach (var num in numbers)
        {
            if (num > max)
                max = num;
            if (num < min)
                min = num;
            sum += num;
        }
       
        avg = (double)sum / n;
        Console.WriteLine("Numbers sum is {0}, Max number is {1}, Min number is {2}, Average is {3:0.00} ", sum, max, min, avg);
    }
}