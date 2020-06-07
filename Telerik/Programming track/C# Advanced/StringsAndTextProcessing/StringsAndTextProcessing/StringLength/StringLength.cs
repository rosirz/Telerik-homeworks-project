using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.

//Input

//On the only line you will receive a string
//Output

//Output a string with length 20
namespace StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());
            
            if (text.Length<20)
            {
                while (text.Length<20)
                {
                    text.Append('*');
                    int length = text.Length;
                }
            }
            Console.WriteLine(text.ToString());
        }
    }
}
