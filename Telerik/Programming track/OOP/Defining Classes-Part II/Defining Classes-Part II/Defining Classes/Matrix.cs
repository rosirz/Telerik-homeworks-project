using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    class Matrix<T>
    {

        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.matrix = new T[row, col];

        }

        public T[,] matrix { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
        public T this[int row, int col]
        {
            get { return this.matrix[row, col]; }
            set { this.matrix[row, col] = value; }
        }


        public static Matrix<T> operator+ (Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);
            if (firstMatrix.Row != secondMatrix.Row || firstMatrix.Col != secondMatrix.Col)
            {
                throw new ArgumentException("The two matrices should be with the same dimensions");
            }
            for (int i = 0; i < firstMatrix.Row; i++)
            {
                for (int j = 0; j < firstMatrix.Col; j++)
                {
                    resultMatrix[i, j] = (dynamic)firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator- (Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);
            if (firstMatrix.Row != secondMatrix.Row || firstMatrix.Col != secondMatrix.Col)
            {
                throw new ArgumentException("The two matrices should be with the same dimensions");
            }
            for (int i = 0; i < firstMatrix.Row; i++)
            {
                for (int j = 0; j < firstMatrix.Col; j++)
                {
                    resultMatrix[i, j] = (dynamic)firstMatrix[i, j] - secondMatrix[i, j];
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator*(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.Row, secondMatrix.Col);
            dynamic sum;
            if (firstMatrix.Col != secondMatrix.Row)
            {
                throw new ArgumentException("The columns of the first matrix and the rows of the second matrix should be equal!");
            }
            else
            {
                for (int i = 0; i < firstMatrix.Row; i++)
                {
                    for (int j = 0; j < secondMatrix.Col; j++)
                    {
                        sum = 0;
                        for (int k = 0; k < firstMatrix.Col; k++)
                        {
                            sum += (dynamic)firstMatrix[i, k] * secondMatrix[k, j];
                        }
                        resultMatrix[i, j] = sum;
                    }

                }
            }
            return resultMatrix;
        }

        public static implicit operator bool (Matrix<T> matrix)
        {
            return matrix != null && matrix.Row > 0 && matrix.Col>0;
        }

        public void AddElement (T item, int row,int col)
        {
            this.matrix[row, col] = item;
        }

        public void PrintMatrix (Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    Console.Write(this.matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}

