using System;

class OddEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Odd and Even Product");
        Console.Write("Enter number sequence in one line divided by space N: ");
        string inputNumbers = Console.ReadLine();
        string[] numbers = inputNumbers.Split(' ');
        int evenProduct = 1;
        int oddProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = int.Parse(numbers[i]);

            if (i % 2 != 0)
            {
                evenProduct *= number;
            }
            else
            {
                oddProduct *= number;
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("Product of the odd elements is equal to the product of the even elements.\nProduct is: {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("Product of the odd elements is equal to the product of the even elements.\nOddProduct is: {0}\nEvenProduct is: {1}", oddProduct, evenProduct);
        }
    }

}

