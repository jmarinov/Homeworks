using System;

class MatrixNumbers
{
    static void Main()
    {
        Console.WriteLine("Create Matrix Numbers: (1 ≤ n ≤ 20)");
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());

        for (int rows = 1; rows < n+1; rows++)
        {
            for (int cols = rows; cols <= (n+rows)-1; cols++)
            {
                Console.Write("{0} ", cols);
            }
            Console.WriteLine();
        }
    }
}

