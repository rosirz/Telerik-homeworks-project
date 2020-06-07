using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

//Input

//On the only input line you will receive a string
//Output

//Print the string without consecutive identical letters
namespace SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder newText = new StringBuilder();
            StringBuilder replace = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < text.Length-1; i++)
            {
                if (text[i] != text[i+1] && i < text.Length-2)
                {
                    newText.Append(text[i]);
                }
                if (text[i] != text[i + 1] && i == text.Length - 2)
                {
                    newText.Append(text[i]);
                    newText.Append(text[i + 1]);
                }
                if (text[i] == text[i + 1] && i == text.Length - 2)
                {
                    newText.Append(text[i]);
                }
                
            }
            Console.WriteLine(newText.ToString());
        }
    }
}
