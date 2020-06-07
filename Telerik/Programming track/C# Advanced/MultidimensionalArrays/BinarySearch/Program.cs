using System;
//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using 
//the method Array.BinSearch() finds the largest number in the array which is ≤ K.
class Program
    {
        static void Main()
        {
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        string[] readArray = Console.ReadLine().Split(' ');
        int K = int.Parse(Console.ReadLine());
        for (int i = 0; i < N-1; i++)
        {
            array[i] = int.Parse(readArray[i]);
        }
        Array.Sort(array);
        int index = Array.BinarySearch(array, K);
        Console.WriteLine(array[index-1]);
        }
    }

