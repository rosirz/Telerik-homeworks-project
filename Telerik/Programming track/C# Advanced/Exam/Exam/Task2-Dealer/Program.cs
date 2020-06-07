using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Dealer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cardSingns = { "2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "Tc", "Jc", "Qc", "Kc", "Ac",
                                    "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "Td", "Jd", "Qd", "Kd", "Ad",
                                    "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "Th", "Jh", "Qh", "Kh", "Ah",
                                    "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "Ts", "Js", "Qs", "Ks", "As"};
            string biggest = "1111111111111111111111111111111111111111111111111111";
            long b = ConvertBinaryToDecimal(biggest, 2);
            int N = int.Parse(Console.ReadLine());
            long result = 0;
            long resultRepeat = b;
            List<int> repeat = new List<int>();
            for (int i = 0; i < N; i++)
            {
                long hand = long.Parse(Console.ReadLine());
                result = hand | result;
                resultRepeat = hand & resultRepeat;
                string handB = Convert.ToString(hand, 2);
                string binary = Convert.ToString(hand, 2);
                int index = -1;
                //for (int j= 0; j < binary.Length; j++)
                //{

                //}
                for (int j = 0; j < binary.Length; j++)
                {
                    index = binary.IndexOf('1', index + 1);
                    if (index < 0)
                    {
                        break;
                    }
                    int place = binary.Length - 1 - index;
                    repeat.Add(place);
                }
                binary = String.Empty;
                //Console.WriteLine(binary);
            }
            repeat.Sort();
            List<int> evenRepeat = new List<int>();
            int counter = 1;

            for (int i = 0; i < repeat.Count - 1; i++)
            {
                if (repeat[i] == repeat[i + 1])
                {
                    counter++;
                }
                if (repeat[i] != repeat[i + 1] && counter > 1 && counter % 2 == 0)
                {
                    evenRepeat.Add(repeat[i]);
                    counter = 1;
                }
                if (repeat[i] != repeat[i + 1] && counter > 1 && counter % 2 != 0)
                {
                    counter = 1;
                }
            }


            StringBuilder cards = new StringBuilder();
            for (int i = 0; i < evenRepeat.Count; i++)
            {
                cards.Append(cardSingns[evenRepeat[i]] + " ");
            }

            if (result == b)
            {
                Console.WriteLine("Full deck");
                Console.WriteLine(cards);
            }
            else
            {
                Console.WriteLine("Wa wa!");
                Console.WriteLine(cards);
            }

        }
        static long ConvertBinaryToDecimal(string Binary, int NumBase)
        {
            long Decimal = 0;
            foreach (var digit in Binary)
            {

                Decimal = Decimal * NumBase + (digit - '0');

            }
            return Decimal;
        }
    }
}
