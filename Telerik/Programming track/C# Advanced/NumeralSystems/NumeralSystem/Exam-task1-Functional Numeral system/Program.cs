using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exam_task1_Functional_Numeral_system
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = {',',' ' };
            string[] input = Console.ReadLine().Split(separators,StringSplitOptions.RemoveEmptyEntries);
            string separated = SepateEachDigit(input);
            string[] code = separated.Split(',');




            long[] numbers = new long[code.Length];
           
            for (int i = 0; i < code.Length; i++)
            {
              
                numbers[i] = ConvertToDecimal(code[i], 16);
            }
            BigInteger product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            Console.WriteLine(product);

        }

        static string SepateEachDigit (string[] input)
        {
            string separated = "";
            StringBuilder digit = new StringBuilder();
            StringBuilder allDigits = new StringBuilder();
            string[] Values = { "ocaml", "haskell", "scala", "f#", "lisp", "rust", "ml", "clojure", "erlang", "standardml", "racket", "elm", "mercury", "commonlisp", "scheme", "curry" };
            int startindex = 0;
            int endindex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < Values.Length; j++)
                {
                    endindex = input[i].IndexOf(Values[j]);
                    if (endindex > 0) { 
                        digit.Append(input[i].Substring(startindex, endindex - startindex)+",");
                        startindex = endindex;
                    }
                    if (j==Values.Length-1)
                    {
                        digit.Append(input[i].Substring(startindex, (input[i].Length  - startindex)));
                    }
                }
                startindex = 0;
                string[] convert = digit.ToString().Split(',');
                
                string Hex = "";
                Hex = ToHexadecimal(convert);
                if (i<input.Length-1)
                {
                    allDigits.Append(Hex + ",");
                }
                else { allDigits.Append(Hex); }
                
                digit = digit.Clear();
            }
            
            separated = allDigits.ToString();
            return separated;
        }

        static string ToHexadecimal(string[] code)
        {
            string Hexadecimal = "";
            
            foreach (var number in code)
            {
                string digit = "";
                switch (number)
                {
                    case "ocaml": digit = "0"; break;
                    case "haskell": digit = "1"; break;
                    case "scala": digit = "2"; break;
                    case "f#": digit = "3"; break;
                    case "lisp": digit = "4"; break;
                    case "rust": digit = "5"; break;
                    case "ml": digit = "6"; break;
                    case "clojure": digit = "7"; break;
                    case "erlang": digit = "8"; break;
                    case "standardml": digit = "9"; break;
                    case "racket": digit = "A"; break;
                    case "elm": digit = "B"; break;
                    case "mercury": digit = "C"; break;
                    case "commonlisp": digit = "D"; break;
                    case "scheme": digit = "E"; break;
                    case "curry": digit = "F"; break;

                    default:
                        break;
                }
                Hexadecimal += digit;
            }

            return Hexadecimal;
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
