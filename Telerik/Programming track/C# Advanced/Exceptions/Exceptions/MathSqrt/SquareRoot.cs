using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a number and calculates and prints its square root.

//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.Use try-catch-finally block.
//Input

//On the only line you will receive a real number
//Output

//Print the square root of the number or Invalid number on the first line
//Use 3 digits of precision
//Print Good bye on the second line
namespace MathSqrt
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                if (number<0)
                {
                    Console.WriteLine("Invalid number");
                }
                else { Console.WriteLine("{0:f3}", Math.Sqrt(number)); }
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid number");
            }
            
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
