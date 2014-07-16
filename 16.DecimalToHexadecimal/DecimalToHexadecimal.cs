using System;
using System.Globalization;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter decimal number to convert: ");
        long dec = long.Parse(Console.ReadLine());
        string hexStr = dec.ToString("X");
        long hex = long.Parse(hexStr, NumberStyles.HexNumber);
        Console.WriteLine(hexStr);
    }
}

