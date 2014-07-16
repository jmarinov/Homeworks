using System;
using System.Globalization;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter hexadecimal value to convert: ");
        string hexNum = Console.ReadLine();
        long dec = long.Parse(hexNum, NumberStyles.HexNumber);
        Console.WriteLine(dec);
    }
}
