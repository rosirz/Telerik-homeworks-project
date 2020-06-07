using System;
//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours 
//(when such exist). Write program that reads an array of numbers and prints how many of them are larger than their neighbours.

//Input

//On the first line you will receive the number N - the size of the array
//On the second line you will receive N numbers separated by spaces - the array
//Output

//Print how many numbers in the array are larger than their neighbours
    class LargerThanNeighbours
    {
    static int CheckNumberLargerThanNeighbours(int[] array)
    {
        int counter = 0;
        for (int i = 1; i < array.Length-1; i++)
        {
            if (array[i] > array[i-1] && array[i] > array[i+1])
            {
                counter++;
            }
        }
        return counter;
    }
        static void Main()
        {
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        string[] readArray = Console.ReadLine().Split(' ');
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(readArray[i]);
        }
        Console.WriteLine(CheckNumberLargerThanNeighbours(array));
        }
    }

