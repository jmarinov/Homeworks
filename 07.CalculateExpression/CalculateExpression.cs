using System;
using System.Numerics;

class CalculateExpression
    {
        static void Main()
        {
            Console.WriteLine("Calculate N!/(K!*(N-K)! in range: (1 < K < N < 100)");
            Console.Write("Enter number N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter number K: ");
            int k = int.Parse(Console.ReadLine());

            BigInteger result = 1;
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger factorialNK = 1;
           

            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }

            for (int j = 1; j <= k; j++)
            {
                factorialK *= j;
            }

            for (int l = 1; l <= n - k; l++)
            {
                factorialNK *= l;
            }

            result = factorialN / (factorialK * factorialNK);

            Console.WriteLine(result);
        }
    }
