using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_6_7_and_17

{
    
    

    class Program

    {
        
        static void Main(string[] args)
        {
            //problem 6
            //Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
            //Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
            int[] numbers = new int[] { 5, 7, 15, 21, 42, 56, 84, 100 };
            var sorted = numbers.Where(number => number % 3 == 0 && number % 7 == 0);
            foreach (var number in sorted)
            {
                Console.WriteLine(number);
            }

            var sorted2 = from number in numbers
                          where number % 3 == 0 && number % 7 == 0
                          select number;
            foreach (var number in sorted2)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            //problem 17
            //Write a program to return the string with maximum length from an array of strings.
            //Use LINQ.
            string[] strings = new string[]
            {
                "Gosho",
                "Ivanka",
                "Lyubomira",
                "Vladislava",
                "Dobromir"
            };
            var strWithMaxLength = strings.OrderByDescending(str => str.Length).First();
            Console.WriteLine(strWithMaxLength);

        }
    }
}
