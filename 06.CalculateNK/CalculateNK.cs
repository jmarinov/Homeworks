using System;
using System.Numerics;

class CalculateNK
{
    static void Main()
    {
        Console.WriteLine("Calculate N!/K! (1 < K < N < 100)");
        Console.Write("Enter positive number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter positive number K: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger result = 1;
        
        for (int i = k+1; i <= n; i++)
        {

             result = result * i;
          
        }
       Console.WriteLine("The number is: {0}", result);
    }
}

