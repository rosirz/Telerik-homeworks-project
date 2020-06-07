using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exam_task1_var2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] ValuesCode = { "ocaml", "haskell", "scala", "f#", "commonlisp", "lisp", "rust", "standardml", "ml", "clojure", "erlang", "racket", "elm", "mercury", "scheme", "curry" };
            string[] ValuesHex = { "0", "1", "2", "3", "D", "4", "5", "9", "6", "7", "8", "A", "B",  "C",  "E", "F" };
            for (int i = 0; i < 16; i++)
            {
                input = input.Replace(ValuesCode[i], ValuesHex[i]);
            }
            char[] separators = { ',', ' ' };
            string[] Hex = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            long[] numbers = new long[Hex.Length];
            for (int i = 0; i < Hex.Length; i++)
            {
                numbers[i] = ConvertToDecimal(Hex[i], 16);
            }
            BigInteger product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            Console.WriteLine(product);

        }
        static long ConvertToDecimal(string number, int NumBase)
        {
            long DecimalNumber = 0;

            foreach (var digit in number)
            {
                int digitvalue;
                if (char.IsDigit(digit))
                {
                    digitvalue = digit - '0';
                }
                else
                {
                    digitvalue = digit - 'A' + 10;
                }
                DecimalNumber = DecimalNumber * NumBase + digitvalue;

            }
            return DecimalNumber;
        }
    }
}
