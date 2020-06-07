using System;
//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements 
//located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix 
//and prints its length.

//Input

//On the first line you will receive the numbers N and M separated by a single space
//On the next N lines there will be M strings separated with spaces - the strings in the matrix
//Output

//Print the length of the longest sequence of equal equal strings in the matrix
class SequenceInMatrix
{
    static void Main()
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
        int counterRow = 1;
        int counterColumn = 1;
        int counterDiagonalLeft = 1;
        int counterDiagonalRight = 1;
        int longestRow = 1;
        int longestCol = 1;
        int longestDiagonalLeft = 1;
        int longestDiagonalRight = 1;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {

            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    counterRow++;
                }
                else
                {
                    longestRow = Math.Max(longestRow, counterRow);
                    counterRow = 1;
                }
            }
            longestRow = Math.Max(longestRow, counterRow);
            counterRow = 1;
        }

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                if (matrix[row,col] == matrix[row+1,col])
                {
                    counterColumn++;
                }
                else
                {
                    longestCol = Math.Max(longestCol, counterColumn);
                    counterColumn = 1;
                }
            }
            longestCol = Math.Max(longestCol, counterColumn);
            counterColumn = 1;
        }

        int N = matrix.GetLength(0) - 1;
        int M = matrix.GetLength(1) - 1;
        for (int col = 0; col < M; col++)
        {
            for (int Maksrow = 0, Makscol = col; Maksrow < N && Makscol < M; Maksrow++, Makscol++)
            {
                if (matrix[Maksrow, Makscol] == matrix[Maksrow + 1, Makscol + 1])
                {
                    counterDiagonalLeft++;
                }
                else
                {
                    longestDiagonalLeft = Math.Max(longestDiagonalLeft, counterDiagonalLeft);
                    counterDiagonalLeft = 1;
                }
                if (matrix[Maksrow, M -Makscol] == matrix[Maksrow + 1, M - Makscol - 1])
                {
                    counterDiagonalRight++;
                }
                else
                {
                    longestDiagonalRight = Math.Max(longestDiagonalRight, counterDiagonalRight);
                    counterDiagonalRight = 1;
                }
            }
            longestDiagonalLeft = Math.Max(longestDiagonalLeft, counterDiagonalLeft);
            counterDiagonalLeft = 1;
            longestDiagonalRight = Math.Max(longestDiagonalRight, counterDiagonalRight);
            counterDiagonalRight = 1;
        }
        for (int row = 1; row < N; row++)
        {
            for (int Maksrow = row, Makscol = 0; Maksrow < N && Makscol < M; Maksrow++, Makscol++)
            {
                if (matrix[Maksrow, Makscol] == matrix[Maksrow + 1, Makscol + 1])
                {
                    counterDiagonalLeft++;
                }
                else
                {
                    longestDiagonalLeft = Math.Max(longestDiagonalLeft, counterDiagonalLeft);
                    counterDiagonalLeft = 1;
                }
                if (matrix[Maksrow, M-Makscol] == matrix[Maksrow + 1, M -Makscol - 1])
                {
                    counterDiagonalRight++;
                }
                else
                {
                    longestDiagonalRight = Math.Max(longestDiagonalRight, counterDiagonalRight);
                    counterDiagonalRight = 1;
                }
            }
            longestDiagonalLeft = Math.Max(longestDiagonalLeft, counterDiagonalLeft);
            counterDiagonalLeft = 1;
            longestDiagonalRight = Math.Max(longestDiagonalRight, counterDiagonalRight);
            counterDiagonalRight = 1;
        }

        int max = longestRow;
        if (longestCol > max)
        {
            max = longestCol;
        }
        if (longestDiagonalLeft > max)
        {
            max = longestDiagonalLeft;
        }
        if (longestDiagonalRight > max)
        {
            max = longestDiagonalRight;
        }
        Console.WriteLine(max);
    }
}

