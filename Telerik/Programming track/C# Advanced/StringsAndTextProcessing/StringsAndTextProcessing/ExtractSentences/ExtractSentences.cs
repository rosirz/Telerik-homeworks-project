using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that extracts from a given text all sentences containing given word.

//Input

//On the first line you will receive a string - the word
//On the second line you will receive a string - the text
//Output

//Print only the sentences containing the word on a single line
namespace ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            //string search = "[^A-Za-z0-9 ]" + word + "[^A-Za-z0-9 ]";
            string text = Console.ReadLine();
            StringBuilder newText = new StringBuilder();
            string[] sentences = text.Split('.');
            for (int i = 0; i<sentences.Length; i++)
            {
                sentences[i] = sentences[i].Trim();
                if (sentences[i].IndexOf(word)>0)
                {
                    StringBuilder separators = new StringBuilder();
                    foreach (char letter in sentences[i])
                    {
                        if (!Char.IsLetter(letter))
                        {
                            separators.Append(letter);
                        }
                    }
                    char[] splitSymbols = separators.ToString().ToCharArray();
                    string[] words = sentences[i].Split(splitSymbols,StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < words.Length; j++)
                    {
                        if (words[j]== word)
                    {
                        //sentences[i] = sentences[i].TrimStart();
                        newText.Append(sentences[i]+". ");
                    }
                    }
                    
                    //sentences[i] = sentences[i].TrimStart();
                    //newText.Append(sentences[i]);
                }
            }
            Console.WriteLine(newText.ToString());
        }
    }
}
