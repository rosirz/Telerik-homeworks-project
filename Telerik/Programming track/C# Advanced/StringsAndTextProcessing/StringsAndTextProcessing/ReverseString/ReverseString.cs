using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a string, reverses it and prints the result on the console.
//Input

//On the only line you will receive a string
//Output

//Print the string in reverse on a single line
namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            StringBuilder reverse = new StringBuilder();
            for (int i= str.Length-1; i >=0 ; i--)
            {
                reverse.Append(str[i]);
            }
            Console.WriteLine(reverse);
        }
    }
}
