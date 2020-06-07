using System;
//Write a method that counts how many times given number appears in a given array. Write a test program to check if 
//the method is working correctly.

//Input

//On the first line you will receive a number N - the size of the array
//On the second line you will receive N numbers separated by spaces - the numbers in the array
//On the third line you will receive a number X
//Output

//Print how many times the number X appears in the array
    class AppearanceCount
    {
    static int CountNumberInArray(int[] array, int b)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]==b)
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
        int X = int.Parse(Console.ReadLine());
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(readArray[i]);
        }
        Console.WriteLine(CountNumberInArray(array, X));
        } 
    }

