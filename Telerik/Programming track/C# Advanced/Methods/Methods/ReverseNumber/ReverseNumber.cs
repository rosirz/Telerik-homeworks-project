using System;
//Write a method that reverses the digits of a given decimal number.

//Input

//On the first line you will receive a number
//Output

//Print the given number with reversed digits
    class Program
    {
    static void ReverseDigitsOfNumber()
    {
        char[]  number = Console.ReadLine().ToCharArray();
        Array.Reverse(number);
        Console.WriteLine(number);

        //char[] a = new char[number.Length];
        //for (int i = 0; i < number.Length; i++)
        //{
        //    a[i] = number[i];
        //}
        //for (int i = 0; i < number.Length/2; i++)
        //{
        //    char n = a[i];
        //    a[i] = a[a.Length - 1 - i];
        //    a[a.Length - 1 - i] = n;

        //}
        //for (int i = 0; i < number.Length; i++)
        //{
        //    Console.Write("{0}",a[i]);
        //}
    }
        static void Main()
        {
        ReverseDigitsOfNumber();
        }
    }

