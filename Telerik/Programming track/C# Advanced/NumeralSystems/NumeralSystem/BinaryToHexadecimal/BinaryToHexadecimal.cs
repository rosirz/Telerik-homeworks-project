using System;
//Write a program to convert binary numbers to hexadecimal numbers (directly).

//Input

//On the only line you will receive a decimal number - N
//There will not be leading zeros
//Output

//Print the its binary representation on a single line
//There should not be leading zeros
//Use uppercase letters
class BinaryToHexadecimal
{
    static string ConvertBinaryToHexadecimal(string Binary)
    {
        string Hexadecimal = "";
        if (Binary.Length % 4 !=0)
        {
            int numberofZeros = 4 - (Binary.Length % 4);
            for (int i = 0; i < numberofZeros; i++)
            {
                Binary = 0 + Binary;
            }
        }
        string[] digits = new string[Binary.Length / 4];
        for (int i = 0, j = 0; j < digits.Length; i += 4, j++)
        {
            for (int k = 0; k < 4; k++)
            {
                digits[j] += Binary[i + k];
            }
        }
        foreach (var number in digits)
        {
            string digit = "";
            switch (number)
            {
                case "0000": digit = "0"; break;
                case "0001": digit = "1"; break;
                case "0010": digit = "2"; break;
                case "0011": digit = "3"; break;
                case "0100": digit = "4"; break;
                case "0101": digit = "5"; break;
                case "0110": digit = "6"; break;
                case "0111": digit = "7"; break;
                case "1000": digit = "8"; break;
                case "1001": digit = "9"; break;
                case "1010": digit = "A"; break;
                case "1011": digit = "B"; break;
                case "1100": digit = "C"; break;
                case "1101": digit = "D"; break;
                case "1110": digit = "E"; break;
                case "1111": digit = "F"; break;

                default:
                    break;
            }
            Hexadecimal += digit;
        }

        return Hexadecimal;
    }

    static void Main()
    {
        string Binary = Console.ReadLine();
        Console.WriteLine(ConvertBinaryToHexadecimal(Binary));
    }
}

