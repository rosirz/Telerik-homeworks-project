using System;
//Write a program that converts a binary number N to its decimal representation.

//Input

//On the only line you will receive a binary number - N
//There will not be leading zeros
//Output

//Print the decimal representation of N on a single line
//There should not be leading zeros
    class BinaryToDecimal
    {
        static long ConvertBinaryToDecimal (string Binary, int NumBase)
    {
        long Decimal = 0;
        foreach (var digit in Binary)
        {
            
           Decimal = Decimal*NumBase + (digit - '0');
            
        }
        return Decimal;
    }
        static void Main()
        {
        string Binary = Console.ReadLine();
        Console.WriteLine(ConvertBinaryToDecimal(Binary,2));
        }
    }

