using System;
//Write a method GetMax() with two parameters that returns the larger of two integers. Write a program that reads 3 integers 
//from the console and prints the largest of them using the method GetMax().

//Input

//On the first line you will receive 3 integers separated by spaces
//Output

//Print the largest of them
class GetMax
    {
    static int GetMaxOf (int a, int b)
    {
        return  Math.Max(a, b);
    }
        static void Main(string[] args)
        {
        string[] numbers = Console.ReadLine().Split(' ');
        int temp = GetMaxOf(int.Parse(numbers[0]), int.Parse(numbers[1]));
        int max = GetMaxOf(temp, int.Parse(numbers[2]));
        Console.WriteLine(max);
    }
    }

