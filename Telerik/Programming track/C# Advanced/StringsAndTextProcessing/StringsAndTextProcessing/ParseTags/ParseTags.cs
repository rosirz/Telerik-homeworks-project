using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> 
//to upper-case.

//Input

//On the only line you will receive a string - the text
//Output

//Print the changed string on one line
namespace ParseTags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string upperStart = "<upcase>";
            string upperEnd = "</upcase>";
            StringBuilder newText = new StringBuilder();
            for (int startInd = 0; startInd < text.Length; startInd++)
            {
                int startUpp = text.IndexOf(upperStart, startInd, StringComparison.OrdinalIgnoreCase);
                int endUpp = text.IndexOf(upperEnd,startInd,StringComparison.OrdinalIgnoreCase);
                if (startUpp == -1 || endUpp == -1)
                {
                    newText.Append(text.Substring(startInd));
                    break;
                }
                else
                {
                    newText.Append(text.Substring(startInd, startUpp - startInd));
                    string subString = text.Substring(startUpp + upperStart.Length, endUpp - (startUpp+upperStart.Length));
                    string Upper = subString.ToUpper();
                    newText.Append(Upper);
                    startInd = endUpp + upperEnd.Length-1;
                    
                }
            }
            newText = newText.Replace(upperStart, "");
            newText = newText.Replace(upperEnd, "");
            Console.WriteLine(newText.ToString());
        }
    }
}
