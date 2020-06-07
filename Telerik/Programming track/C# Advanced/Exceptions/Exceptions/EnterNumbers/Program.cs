using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method ReadNumber(int start, int end) that enters an integer number in a given range ( start, end ).

//If an invalid number or non-number text is entered, the method should throw an exception.Using this method write a program that enters 
//10 numbers: a1, a2, ..., a10, such that 1 < a1< ... < a10< 100
//Input

//You will receive 10 lines of input, each consisted of an integer number
//a1
//a2
//...
//a10
//Output

//Print 1 < a1< ... < a10< 100
//Or Exception if the above inequality is not true
namespace EnterNumbers
{
    class Program
    {
        static bool ReadNumber(int number,int start, int end)
        {
            
                if (number <= start || number >= end)
                {
                   return false;
                }
            else
            {
                return true;
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[12];
            numbers[0] = 1;
            numbers[11] = 100;

            try
            {
                for (int i = 1; i < numbers.Length - 1; i++)
                {
                    var number = int.Parse(Console.ReadLine());
                    if (ReadNumber(number, numbers[i - 1], numbers[11]))
                    {
                        numbers[i] = number;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                Console.WriteLine(string.Join(" < ", numbers));
            }
            catch (FormatException)
            {

                Console.WriteLine("Exception");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
