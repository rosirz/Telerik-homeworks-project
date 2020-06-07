using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that 
//reads these values from given string and calculates their sum. Write a program that reads a string of positive integers 
//separated by spaces and prints their sum.

//Input

//On the only line you will receive a string consisted of positive integers
//Output

//Print the sum of the integers
namespace SumIntegers
{
    

        
    class Program
    {
        static int Sum(string[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += int.Parse(numbers[i]);
            }
            return sum;
        }

        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
           
            Console.WriteLine(Sum(numbers));
        }
    }
}
