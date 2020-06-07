using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int maxcount = 1;
            int system = 0;
            for (int i = 2; i <= 9; i++)
            {
               string Convertednumber = ConvertFromDecimalToAnotherNumSystem(N, i);
                int[] Array = new int[Convertednumber.Length];
                for (int k = 0; k < Array.Length; k++)
                {
                    Array[k] = Convertednumber[k] - '0';
                }
                int digit = Array[K];
                int count = 0;
               
                for (int j = 0; j < Array.Length; j++)
                {
                    if (Array[j]==digit)
                    {
                        count++;
                    }
                }
                if (count>=maxcount)
                {
                    maxcount = count;
                    system = i;
                }
            }
            Console.WriteLine(system);
            Console.WriteLine(maxcount);
        }

        static string ConvertFromDecimalToAnotherNumSystem(int number, int NumBase)
        {
            string ConvertedNumber = "";
            string HexDigits = "0123456789ABCDEF";
            do
            {
                int value = number % NumBase;
                number /= NumBase;
                char digit = HexDigits[(int)value];
                ConvertedNumber = digit + ConvertedNumber;
            } while (number > 0);
            return ConvertedNumber;
        }
    }
}
