using System;
//Write a program to convert the number N from any numeral system of given base s to any other numeral system of base d.

//Input

//On the first line you will receive the number s
//On the second line you will receive a number in base s - N
//There will not be leading zeros
//On the third line you will receive the number d
//Output

//Print N in base d
//There should not be leading zeros
//Use uppercase letters
    class OneSystemToAnyOther
    {
        static void Main()
        {
            int FirstSysBase = int.Parse(Console.ReadLine());
            string number = Console.ReadLine();
            int SecSysBase = int.Parse(Console.ReadLine());
            ulong DecimalNumber = ConvertToDecimalFromOtherNumSystem(number, FirstSysBase);
            Console.WriteLine(ConvertFromDecimalToAnotherNumSystem(DecimalNumber,SecSysBase));
         }

    static ulong ConvertToDecimalFromOtherNumSystem(string number, int NumBase)
    {
        ulong DecimalNumber = 0;

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
            DecimalNumber = DecimalNumber * (ulong)NumBase + (ulong)digitvalue;

        }
        return DecimalNumber;
    }

    static string ConvertFromDecimalToAnotherNumSystem(ulong number, int NumBase)
    {
        string ConvertedNumber = "";
        string HexDigits = "0123456789ABCDEF";
        do
        {
            ulong value = number % (ulong)NumBase;
            number /= (ulong)NumBase;
            char digit = HexDigits[(int)value];
            ConvertedNumber = digit + ConvertedNumber;
         }  while (number > 0);
        return ConvertedNumber;
    }
}


