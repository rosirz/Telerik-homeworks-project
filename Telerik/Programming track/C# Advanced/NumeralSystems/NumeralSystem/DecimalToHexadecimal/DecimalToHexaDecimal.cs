using System;
//Decimal to hexadecimal

//Description

//Write a program that converts a decimal number N to its hexadecimal representation.

//Input

//On the only line you will receive a decimal number - N
//There will not be leading zeros
//Output

//Print the hexadecimal representation of N on a single line
//There should not be leading zeros
//Use uppercase letters
class DecimalToHexaDecimal
{
    static string ConvertFromDecimalToAnotherNumSystem(long number, int NumBase)
    {
        string ConvertedNumber = "";
        string HexDigits = "0123456789ABCDEF";
        do
        {
            int value = (int)(number % NumBase);
            number /= NumBase;
            if (NumBase == 16)
            {
                char digit = HexDigits[value];
                ConvertedNumber = digit + ConvertedNumber;
            }
            else
            {
                ConvertedNumber = value + ConvertedNumber;
            }
        } while (number > 0);
        return ConvertedNumber;
    }
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(ConvertFromDecimalToAnotherNumSystem(number,16));
    }
}

