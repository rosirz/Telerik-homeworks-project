using System;
//Write a program to convert hexadecimal numbers to binary numbers (directly).

//Input

//On the only line you will receive a decimal number - N
//There will not be leading zeros
//Letters will be uppercase
//Output

//Print the its binary representation on a single line
//There should not be leading zeros
class HexaDecimalToBinary
{
    static string ConvertHexadecimalToBinary(string HexNumber)
    {
        string Binary = "";
        foreach (var number in HexNumber)
        {
            string digit = "";
            switch (number)
            {
                case '0': digit = "0000"; break;
                case '1': digit = "0001"; break;
                case '2': digit = "0010"; break;
                case '3': digit = "0011"; break;
                case '4': digit = "0100"; break;
                case '5': digit = "0101"; break;
                case '6': digit = "0110"; break;
                case '7': digit = "0111"; break;
                case '8': digit = "1000"; break;
                case '9': digit = "1001"; break;
                case 'A': digit = "1010"; break;
                case 'B': digit = "1011"; break;
                case 'C': digit = "1100"; break;
                case 'D': digit = "1101"; break;
                case 'E': digit = "1110"; break;
                case 'F': digit = "1111"; break;

                default:
                    break;
            }
            Binary += digit;
        }
        int i = 0;
        while (Binary[i] == '0')
        {
            Binary = Binary.Remove(i, 1);

        }
        return Binary;
    }
    static void Main()
    {
        string HexNumber = Console.ReadLine();
        Console.WriteLine(ConvertHexadecimalToBinary(HexNumber));
    }
}

