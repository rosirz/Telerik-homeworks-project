using System;
//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there is no such element.

//Input

//On the first line you will receive the number N - the size of the array
//On the second line you will receive N numbers sepated by spaces - the array
//Output

//Print the index of the first element that is larger than its neighbours or -1 if none are
    class FirstLargerThanNeighbours
    {
    static int CheckFirstNumberLargerThanNeighbours(int[] array)
    {
        
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                return i ;
            }
        }
        return -1;
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
        Console.WriteLine(CheckFirstNumberLargerThanNeighbours(array));
    }
}

