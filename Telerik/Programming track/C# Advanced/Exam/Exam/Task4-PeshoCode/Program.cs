using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_PeshoCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());
            StringBuilder textC = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                textC.Append(Console.ReadLine());
            }
            string text = textC.ToString();
            //"Software developers like to solve problems. If they are no problems handily available, they will create their own problems.";//
            int indexWord = text.IndexOf(word);
            int startSent = 0;
            int endSent = 0;
            for (int i = indexWord; i < (text.Length); i++)
            {
                if (text[i] == '.')
                {
                    for (int j = indexWord; j >= 0; j--)
                    {
                        if (text[j] == '.' || text[j] == '?')
                        {
                            startSent = j + 1;
                            break;
                        }
                    }
                    string Substr = text.Substring(startSent, indexWord - startSent);
                    //string[] RealChars = Substr.Split(' ');
                    int sum = Substr[0];
                    for (int k = 1; k < Substr.Length; k++)
                    {
                        if (Substr[k] != ' ')
                        {
                            if (char.IsLetter(Substr[k]))
                            {
                                sum += Substr[k] - 32;
                            }
                            else
                            {
                                sum += Substr[k];
                            }
                        }
                    }
                    Console.WriteLine(sum);
                    return;
                }
                if (text[i]=='?')
                {
                    endSent = i ;
                    string Substr = text.Substring(indexWord+word.Length, endSent-(indexWord + word.Length));
                    int sum = 0;
                    for (int k = 0; k < Substr.Length; k++)
                    {
                        if (Substr[k] != ' ')
                        {
                            if (char.IsLetter(Substr[k]))
                            {
                                sum += Substr[k] - 32;
                            }
                            else
                            {
                                sum += Substr[k];
                            }
                            
                        }
                    }
                    Console.WriteLine(sum);
                    return;
                }


            }


        }
    }
}
