using System;
//Write a program that shows the binary representation of given 16-bit signed integer number N (the C# type short).

//Input

//On the only line you will receive a decimal number - N
//Output

//Print the its binary representation on a single line
//There should be exactly 16 digits of output
    class BinaryShort
    {
        static void Main(string[] args)
        {
        int number = int.Parse(Console.ReadLine());
        
        if (number >= 0)
        {
            string BinShort = ConvertDecimalToBinary(number);
            int Length = 16 - BinShort.Length;
            for (int i = 0; i < Length; i++)
            {
                BinShort = 0 + BinShort;
            }
            Console.WriteLine(BinShort);
        }
        else
        {
            number = 32768 + number;
            string BinShort = ConvertDecimalToBinary(number);
            int Length = 16 - BinShort.Length-1;
            for (int i = 0; i < Length; i++)
            {
                BinShort = 0 + BinShort;
            }
            BinShort = 1+BinShort;
            Console.WriteLine(BinShort);
        }
       
        }

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
}

