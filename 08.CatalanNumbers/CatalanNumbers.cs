using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Calculate Catalan Num in range: (1 < n < 100)");
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger catalanNum = (BigInteger)(Factorial(2 * n) / (Factorial(n + 1) * Factorial(n)));
        Console.WriteLine(catalanNum);
    }
    static BigInteger Factorial(BigInteger number)
    {
        BigInteger sum = 1;
        for (int i = 1; i <= number; i++)
        {
            sum *= i;
        }
        return sum;
    }
}


