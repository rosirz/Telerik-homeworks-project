using System;
//Write a method that adds two polynomials. Represent them as arrays of their coefficients. Write a program that reads 
//two polynomials and prints their sum.

//Input

//On the first line you will receive the number N
//On the second line you will receive the first polynomial as coefficients separated by spaces
//On the third line you will receive the second polynomial as coefficients separated by spaces
//Output

//Print the sum of the polynomials
//Input   Output
//3
//5 0 1
//7 4 -3	12 4 -2
    class AddingPolynomials
    {
        static void Main()
        {
        int N = int.Parse(Console.ReadLine());
        string[] first = Console.ReadLine().Split(' ');
        string[] second = Console.ReadLine().Split(' ');
        Console.WriteLine(string.Join(" ", Sum(N, first,second)));

    }
    static int[] Sum (int N, string[] first, string[] second)
    {
        int[] firstPolynomials = CreateArrayOfDigits(N, first);
        int[] secondPolynomials = CreateArrayOfDigits(N, second);
        int[] sum = new int[N];
        for (int i = 0; i < N; i++)
        {
            sum[i] = firstPolynomials[i] + secondPolynomials[i];
        }
        return sum;
    }

    static int[] CreateArrayOfDigits (int N, string[] StringArray)
    {
        int[] ArrayOfDigits = new int[N];
        for (int i = 0; i < ArrayOfDigits.Length; i++)
        {
            ArrayOfDigits[i] = int.Parse(StringArray[i]);
        }
        return ArrayOfDigits;
    }
    
    }

