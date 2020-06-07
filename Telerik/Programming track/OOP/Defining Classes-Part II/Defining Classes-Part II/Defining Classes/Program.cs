using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //3D points
            Console.WriteLine("3D points");
            Console.WriteLine();

            var firstPoint = new Point3D(1, 1, 1); //create first 3D point
            var secondPoint = new Point3D(5, 3, 1); //create second 3D point
            Console.WriteLine(firstPoint.ToString());
            Console.WriteLine(Distance.DistanceBetweenPoints(firstPoint, secondPoint)); //calculate distance
            PathStorage.GetLines(); //load  coord of points from text file and save them in Path
            Path.PrintPoints(Path.PathHold); //print saved coords
            Console.WriteLine();

            //Generic
            Console.WriteLine("Generic List");
            Console.WriteLine();
            var newList = new GenericList<string>();
            Console.WriteLine(newList.ToString());
            for (int i = 0; i < 8; i++)//add + autogrow
            {
                newList.Add("element " + i);
            }
            Console.WriteLine(newList.ToString());
            newList.Remove(1); //remove
            Console.WriteLine(newList.ToString());
            newList.Add("element 9"); //add
            newList.Insert(3, "element 8"); //insert at given position + autogrow
            Console.WriteLine(newList.ToString());
            Console.WriteLine(newList.FindByValue("element 4")); //find element by value
            Console.WriteLine(newList.MinValue()); //min value
            Console.WriteLine(newList.MaxValue()); //max value
            Console.WriteLine();

            //matrix
            Console.WriteLine("Matrix");
            Console.WriteLine();
            var firstMatrix = new Matrix<int>(2, 3); //create first matrix
            var secondMatrix = new Matrix<int>(2, 3); //create second matrix
            var thirdMatrix = new Matrix<int>(3, 2); //create third matrix
           
            int value = 3;
            for (int i = 0; i < firstMatrix.Row; i++) // fill the first matrix
            {
                for (int j = 0; j < firstMatrix.Col; j++)
                {
                    firstMatrix.AddElement(value, i, j);
                    value += 2;
                }
            }
            int value2 = 5;
            for (int i = 0; i < secondMatrix.Row; i++) //fll the second matrix
            {
                
                for (int j = 0; j < secondMatrix.Col; j++)
                {
                    secondMatrix.AddElement(value2, i, j);
                    value2 += 3;
                }
            }
            int value3 = 10;
            for (int i = 0; i < thirdMatrix.Row; i++) //fill the third matrix
            {
                
                for (int j = 0; j < thirdMatrix.Col; j++)
                {
                    thirdMatrix.AddElement(value3, i, j);
                    value3 += 10;
                }
            }
            firstMatrix.PrintMatrix(firstMatrix); 
            Console.WriteLine();
            secondMatrix.PrintMatrix(secondMatrix);
            Console.WriteLine();
            thirdMatrix.PrintMatrix(thirdMatrix);
            Console.WriteLine();
            (firstMatrix + secondMatrix).PrintMatrix(firstMatrix + secondMatrix); //add first and second matrices
            Console.WriteLine();
            (firstMatrix - secondMatrix).PrintMatrix(firstMatrix - secondMatrix); //substract first and second matrices
            Console.WriteLine();
            (firstMatrix * thirdMatrix).PrintMatrix(firstMatrix * thirdMatrix); //multiply first and third matrices
            if (firstMatrix) //check if true
            {
                Console.WriteLine("true");
            }
        }
    }
}
