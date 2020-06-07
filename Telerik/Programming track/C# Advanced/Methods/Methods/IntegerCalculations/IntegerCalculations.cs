using System;
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
//Use variable number of arguments. Write a program that reads 5 elements and prints their minimum, maximum, 
//average, sum and product.

//Input

//On the first line you will receive 5 numbers separated by spaces
//Output

//Print their minimum, maximum, average, sum and product
//Each on a new line
//The average value should be printed with two digits of precision
class IntegerCalculations
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int[] arrayOfNumbers = new int[numbers.Length];
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            arrayOfNumbers[i] = int.Parse(numbers[i]);
        }
        Console.WriteLine(MinValue(arrayOfNumbers));
        Console.WriteLine(MaxValue(arrayOfNumbers));
        Console.WriteLine("{0:f2}", Average(arrayOfNumbers));
        Console.WriteLine(Sum(arrayOfNumbers));
        Console.WriteLine(Product(arrayOfNumbers));
    }

    static int MinValue(int[] array)
    {
        int MinValue = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < MinValue)
            {
                MinValue = array[i];
            }
        }
        return MinValue;
    }

    static int MaxValue(int[] array)
    {
        int MaxValue = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > MaxValue)
            {
                MaxValue = array[i];
            }
        }
        return MaxValue;
    }

    static int Sum (int[] array)
    {
        int Sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Sum += array[i];
        }
        return Sum;
    }
    static double Average (int[] array)
    {
        double Sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Sum += array[i];
        }
        double average = (double) Sum / array.Length;
        return average;
    }

    static long Product(int[] array)
    {
        long Product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            Product *= array[i];
        }
        return Product;
    }
}

