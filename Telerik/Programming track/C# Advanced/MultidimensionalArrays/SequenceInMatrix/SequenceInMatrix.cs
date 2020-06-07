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
        int counterRow = 0;
        int counterColumn = 0;
        int counterDiagonalLeft = 0;
        int counterDiagonalRight = 0;
        int diagonal = 0;
        int longestRow = 1;
        int longestCol = 1;
        int longestDiagonalLeft = 1;
        int longestDiagonalRight = 1;
        int lamp1 = 0;
        int lamp2 = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {

            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1] && lamp1 == 0)
                {
                    counterRow++;
                    lamp1 = 1;
                }
                if (matrix[col, row] == matrix[col + 1, row] && lamp2 == 0)
                {
                    counterColumn++;
                    lamp2 = 1;
                }
                if (matrix[row, col] == matrix[row, col + 1] && lamp1 == 1)
                {
                    counterRow++;
                }
                if (matrix[col, row] == matrix[col + 1, row] && lamp2 == 1)
                {
                    counterColumn++;
                }
                if (matrix[row, col] != matrix[row, col + 1] && lamp1 == 1)
                {
                    if (longestRow < counterRow)
                    {
                        longestRow = counterRow;
                    }
                    lamp1 = 0;
                    counterRow = 0;
                }

                if (matrix[col, row] != matrix[col + 1, row] && lamp2 == 1)
                {
                    if (longestCol < counterColumn)
                    {
                        longestCol = counterColumn;
                    }
                    lamp2 = 0;
                    counterColumn = 0;
                }
            }
            if (longestRow < counterRow)
            {
                longestRow = counterRow;
            }
            if (longestCol < counterColumn)
            {
                longestCol = counterColumn;
            }
            counterRow = 0;
            counterColumn = 0;
            lamp1 = 0;
            lamp2 = 0;
        }
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - row - 1; col++)
            {
                if (matrix[row + col, col] == matrix[row + col + 1, col + 1] && lamp1 == 0)
                {
                    counterDiagonalLeft++;
                    lamp1 = 1;
                }
                if (matrix[row + col, n - col - 1] == matrix[row + col + 1, n - col - 2] && lamp2 == 0)
                {
                    counterDiagonalRight++;
                    lamp2 = 1;
                }
                if (matrix[row + col, col] == matrix[row + col + 1, col + 1] && lamp1 == 1)
                {
                    counterDiagonalLeft++;
                }
                if (matrix[row + col, n - col - 1] == matrix[row + col + 1, n - col - 2] && lamp2 == 1)
                {
                    counterDiagonalRight++;
                }
                if (matrix[row + col, col] != matrix[row + col + 1, col + 1] && lamp1 == 1)
                {
                    if (longestDiagonalLeft < counterDiagonalLeft)
                    {
                        longestDiagonalLeft = counterDiagonalLeft;
                    }
                    lamp1 = 0;
                    counterDiagonalLeft = 0;
                }
                if (matrix[row + col, n - col - 1] != matrix[row + col + 1, n - col - 2] && lamp2 == 1)
                {
                    if (longestDiagonalRight < counterDiagonalRight)
                    {
                        longestDiagonalRight = counterDiagonalRight;
                    }
                    lamp2 = 0;
                    counterDiagonalRight = 0;
                }
            }
            if (longestDiagonalLeft < counterDiagonalLeft)
            {
                longestDiagonalLeft = counterDiagonalLeft;
            }
            if (longestDiagonalRight < counterDiagonalRight)
            {
                longestDiagonalRight = counterDiagonalRight;
            }
            counterDiagonalLeft = 0;
            counterDiagonalRight = 0;
            lamp1 = 0;
            lamp2 = 0;
        }
        for (int row = 1; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - row - 1; col++)
            {
                if (matrix[col, col + row] == matrix[col + 1, col + row + 1] && lamp1 == 0)
                {
                    counterDiagonalLeft++;
                    lamp1 = 1;
                }
                if (matrix[col, n - row - col - 1] == matrix[col + 1, n - row - col - 2] && lamp2 == 0)
                {
                    counterDiagonalRight++;
                    lamp2 = 1;
                }
                if (matrix[col, col + row] == matrix[col + 1, col + row + 1] && lamp1 == 1)
                {
                    counterDiagonalLeft++;
                }
                if (matrix[col, n - row - col - 1] == matrix[col + 1, n - row - col - 2] && lamp2 == 1)
                {
                    counterDiagonalRight++;
                }
                if (matrix[col, col + row] != matrix[col + 1, col + row + 1] && lamp1 == 1)
                {
                    if (longestDiagonalLeft < counterDiagonalLeft)
                    {
                        longestDiagonalLeft = counterDiagonalLeft;
                    }
                    lamp1 = 0;
                    counterDiagonalLeft = 0;
                }
                if (matrix[col, n - row - col - 1] != matrix[col + 1, n - row - col - 2] && lamp2 == 1)
                {
                    if (longestDiagonalRight < counterDiagonalRight)
                    {
                        longestDiagonalRight = counterDiagonalRight;
                    }
                    lamp2 = 0;
                    counterDiagonalRight = 0;
                }
            }
            if (longestDiagonalLeft < counterDiagonalLeft)
            {
                longestDiagonalLeft = counterDiagonalLeft;
            }
            if (longestDiagonalRight < counterDiagonalRight)
            {
                longestDiagonalRight = counterDiagonalRight;
            }
            counterDiagonalLeft = 0;
            counterDiagonalRight = 0;
            lamp1 = 0;
            lamp2 = 0;
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

