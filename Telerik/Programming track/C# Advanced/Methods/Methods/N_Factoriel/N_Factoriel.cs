using System;
using System.Numerics;
//Write a method that multiplies a number represented as an array of digits by a given integer number. 
//Write a program to calculate N!.

//Input

//On the first line you will receive the number N
//Output

//Print N!
    class N_Factoriel
    {
        static void Main()
        {
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(Factoriel(N));
        }

    static BigInteger Factoriel(int N)
    {
        int[] numberAsArray = new int[N];
        for (int i = 1; i <= N; i++)
        {
            numberAsArray[i-1] = i;
        }
        BigInteger factoriel = 1;
        for (int j = 0; j < numberAsArray.Length; j++)
        {
            factoriel *= numberAsArray[j];
        }
        return factoriel;
    }
    }


