using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number to convert: ");
        string binaryNum = Console.ReadLine();
        long dec = 0;
        for (int i = 0; i < binaryNum.Length; i++)
        {
            if (binaryNum[binaryNum.Length - i - 1] == '0')
            {
                continue;
            }
          dec += (long)Math.Pow(2, i);
        }

        Console.WriteLine(dec);
    }
}
