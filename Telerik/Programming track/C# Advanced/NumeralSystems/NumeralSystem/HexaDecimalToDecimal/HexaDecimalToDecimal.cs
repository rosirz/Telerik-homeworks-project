using System;
//Write a program that converts a hexadecimal number N to its decimal representation.

//Input

//On the only line you will receive a hexadecimal number - N
//There will not be leading zeros
//Letters will be uppercase
//Output

//Print the decimal representation of N on a single line
//There should not be leading zeros
    class HexaDecimalToDecimal
    {
        static long ConvertToDecimalFromOtherNumSystem (string number, int NumBase)
    {
        long DecimalNumber = 0;
        
        foreach (var digit in number)
        {
            int digitvalue;
            if (char.IsDigit(digit))
            {
                digitvalue = digit - '0';
            }
            else
            {
                digitvalue = digit - 'A' + 10;
            }
            DecimalNumber = DecimalNumber * NumBase + digitvalue;

        }
        return DecimalNumber;
    }
        static void Main()
        {
        string number = Console.ReadLine();
        Console.WriteLine(ConvertToDecimalFromOtherNumSystem(number,16));
        }
    }

