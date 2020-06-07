using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Description

//Write a program that finds how many times a sub-string is contained in a given text(perform case insensitive search).

//Input

//On the first line you will receive a string - the pattern
//On the second line you will receive a string - the text
//Output

//Print a number on a single line
//The number of occurrences
namespace SubstringInText
{
    class SubstringInText
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();
            int startind = 0;
            int ind = 0;
            int counter = 0;
            while (startind<text.Length)
            {
                ind = text.IndexOf(pattern,startind, StringComparison.OrdinalIgnoreCase);
                startind = ind + 1;
                if (ind == -1)
                {
                   break;
                }
                else
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
