using System;
//Write a method that returns the maximal element in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order. Write a program that sorts a given array.

//Input

//On the first line you will receive the number N - the size of the array
//On the second line you will receive N numbers separated by spaces - the array
//Output

//Print the sorted array
//Elements must be separated by spaces
class SortingArray
{

    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string[] numbers = Console.ReadLine().Split(' ');
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(numbers[i]);
        }
        
        Console.WriteLine(string.Join(" ",SortArray(array))); //ascending order
        //Console.WriteLine(string.Join(" ", array)); //descendng order
    }
    
    static int FindMaxElement(int[] array, int StartIndex)
    {
        int MaxElement = 0;
        int MaxIndex = 0;
        for (int i = StartIndex; i < array.Length; i++)
        {
            if (array[i] > MaxElement)
            {
                MaxElement = array[i];
                MaxIndex = i;
            }
        }
        array[MaxIndex] = array[StartIndex];
        array[StartIndex] = MaxElement;
        return MaxElement;
    }

    static int[] SortArray(int[] array)
    {
        int[] SortedArray = new int[array.Length];
        for (int i = 0; i <array.Length ; i++)
        {
            SortedArray[array.Length - 1 - i] = FindMaxElement(array, i);
        }
        return SortedArray;
        
    }
}

