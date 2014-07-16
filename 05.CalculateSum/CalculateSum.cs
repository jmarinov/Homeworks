using System;

class CalculateSum
{
    static void Main()
    {
        Console.WriteLine("Calculate 1 + 1!/X + 2!/X2 + … + N!/XN");
        Console.Write("Enter positive number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter positive number x: ");
        int x = int.Parse(Console.ReadLine());
        long factorial = 1;
        long denominator = 1;
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            denominator *= x;
            double fraction = (double)factorial / denominator;
            sum += fraction;
        }
        Console.WriteLine("The sum is: {2:0.00000}", sum);
    }
}

