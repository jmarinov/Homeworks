using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter decimal number to convert: ");
        long dec = long.Parse(Console.ReadLine());
        long result;
        string binary = string.Empty;

        while (dec > 0)
        {
            result = dec % 2;
            dec /= 2;
            binary = result.ToString() + binary;
        }

        Console.WriteLine(binary);
    }
}

