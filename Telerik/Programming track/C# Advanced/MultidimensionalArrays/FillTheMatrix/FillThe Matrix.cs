using System;
//Write a program that fills and prints a matrix of size (n, n) as shown below.

//Input

//On the first line you will receive the number N
//On the second line you will receive a character(a, b, c, d*) which determines how to fill the matrix
//Output

//Print the matrix
//Numbers on a row must be separated by a single spacebar
//Each row must be on a new line
    class FillTheMatrix
    {
        static void Main()
        {
        int number = int.Parse(Console.ReadLine());
        int[,] matrix = new int[number, number];
        string way = Console.ReadLine();

        int index = 1;
        int rowFirst = 0;
        int colFirst = 0;
        int rowMax = number - 1;
        int colMax = number - 1;
        
        if (way == "a")
        {
            for (int row = 0; row < matrix.GetLength(0); row++)            //1 5 9 13
            {                                                              //2 6 10 14
                for (int col = 0; col < matrix.GetLength(1); col++)        //3 7 11 15
                {                                                          //4 8 12 16
                    matrix[col, row] = index;
                    index++;
                }
            }

        }
        else if (way == "b")
        {
            for (int row = 0; row < matrix.GetLength(0); row++)                //1 8 9 16
            {                                                                  //2 7 10 15
                if (row % 2 == 0)                                              //3 6 11 14
                {                                                              //4 5 12 13
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[col, row] = index;
                        index++;
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[col, row] = index;
                        index++;
                    }

                }
            }

        }
        else if (way=="c")
        {
            for (int row = matrix.GetLength(0)-1; row >=0 ; row--)                  //7 11 14 16
            {                                                                       //4 8 12 15
                for (int col = 0; col < matrix.GetLength(1)-row; col++)             //2 5 9 13
                {                                                                   //1 3 6 10 
                    matrix[row+col, col] = index;
                    index++;
                }
            }
            for (int col = 1; col < matrix.GetLength(0); col++)
            {
                for (int row = 0; row < matrix.GetLength(1)-col; row++)
                {
                    matrix[row,col+row] = index;
                    index++;
                }
            }
        }

            
        else if (way=="d")                                                // 1 12 11 10
        {                                                                 // 2 13 16 9
                                                                          // 3 14 15 8
            do                                                            // 4 5 6 7
            {
                for (int i = rowFirst; i <= rowMax; i++)
                {
                    matrix[i, colFirst] = index++;//down
                }
                colFirst++;
                for (int i = colFirst; i <= colMax; i++)
                {
                    matrix[rowMax, i] = index++;//right
                }
                rowMax--;
                for (int i = rowMax; i >= rowFirst; i--)
                {
                    matrix[i, colMax] = index++;//up
                }
                colMax--;
                for (int i = colMax; i >= colFirst; i--)
                {
                    matrix[rowFirst, i] = index++;//left
                }
                rowFirst++;
            }
            while (index <= number * number);
        }


        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col < matrix.GetLength(1) - 1)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                else
                {
                    Console.Write("{0}", matrix[row, col]);
                }
            }
            Console.WriteLine();
        }

    }
    }

