using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
//Write a program that converts a string to a sequence of C# Unicode character literals.

//Input

//On the only input line you will receive a string
//Output

//Print the string in C# Unicode character literals on a single line
namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder newText = new StringBuilder();
            foreach (var letter in text)
            {
               
                newText.AppendFormat("\\u{0:x4}", (int)letter);
                    
            }
            Console.WriteLine(newText.ToString());
        }
    }
}
