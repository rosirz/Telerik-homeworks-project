using System;
//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. Print that sum.

//Input

//On the first line you will receive the numbers N and M separated by a single space
//On the next N lines there will be M numbers separated with spaces - the elements of the matrix
//Output

//Print the maximal sum of 3 x 3 square
class MaximalSum
{
    static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split(' ');//in order the numbers to be read only form one line, 
                                                         //we read them as an array of strings, separeted by white spase

        int n = int.Parse(numbers[0]);   //giving value to n and m
        int m = int.Parse(numbers[1]);
        //Console.WriteLine("{0} {1}", numbers[0],numbers[1]);
        int[,] matrix = new int[n, m];                         //creating empty matrix
        for (int row = 0; row < matrix.GetLength(0); row++) //fill the matrix
        {
            string[] RowAdd = Console.ReadLine().Split(' '); //first read the elements of the row again as a string
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = int.Parse(RowAdd[col]); //fill each element of the matrix with the values from the string
            }
        }
        int bestSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0)-2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                          matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                          matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (bestSum < sum)
                {
                    bestSum = sum;
                }
            }
        }
        Console.WriteLine(bestSum);
    }
}

