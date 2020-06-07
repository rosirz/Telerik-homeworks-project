using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that replaces in a HTML document given as string all the tags <a href="URL">TEXT</a> with corresponding markdown notation [TEXT](URL).

//Input

//On the only input line you will receive a string
//Output

//Print the string with replaced tags
namespace ReplaceTags
{
    class ReplaceTag
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder newText = new StringBuilder();
            string openTag = "<a href=";
            int lengthOpenTag = openTag.Length;
            string closeTag = "</a>";
            int lengthCloseTag = closeTag.Length;
            for (int i = 0; i < text.Length; i++)
            {
                int startInd = text.IndexOf(openTag,i);
                int endInd = text.IndexOf(closeTag,i) + closeTag.Length;
                if (startInd<0 || endInd<0)
                {
                    newText.Append(text.Substring(i));
                    break;
                }
                newText.Append(text.Substring(i, startInd -i));
                string tag = text.Substring(startInd, endInd - startInd);
                //int startUrl = tag.IndexOf('"');
                //int endUrl = tag.IndexOf('"', startUrl+1);
               
                int startName = tag.IndexOf('>');
                int endName = tag.LastIndexOf('<');
                string Url = "("+ tag.Substring(openTag.Length + 1, startName-openTag.Length-1-1)+")";
                string Name = "["+tag.Substring(startName+1, endName - (startName+1))+"]";
                //newText.Append("[");
                newText.Append(Name);
                //newText.Append("](");
                newText.Append(Url);
                //newText.Append(") ");
                //string replace = "[" + Name + "](" + Url + ")";
                //text = text.Replace(tag, replace);
                i = endInd-1;
            }
            Console.WriteLine(newText.ToString());
        }
    }
}
