using System;
//Write a program that converts a decimal number N to its binary representation.

//Input

//On the only line you will receive a decimal number - N
//There will not be leading zeros
//Output

//Print the binary representation of N on a single line
//There should not be leading zeros
    class DecimalToBinary
    {
    static string ConvertDecimalToBinary(long number)
    {
        string Binary = "";
        do
        {
            int value = (int)(number % 2);
            number /= 2;
            Binary = value + Binary;
        } while (number > 0);
            return Binary;
    }
        static void Main()
        {
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(ConvertDecimalToBinary(number));
        }
    }
