using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_SnackyTheSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimens = Console.ReadLine().Split('x');
            int Rows = 0;
            int Cols = 0;
            if (dimens[0].Length > 1)
            {
                Rows = int.Parse(dimens[0]);//[0] - '0' * 10 + dimens[0][1] - '0';
            }
            else
            {
                Rows = dimens[0][0] - '0';
            }
            if (dimens[1].Length > 1)
            {
                Cols = int.Parse(dimens[1]);//[0] - '0' * 10 + dimens[1][1] - '0';
            }
            else
            {
                Cols = dimens[1][0] - '0';
            }
            char[,] den = new char[Rows, Cols];
            int entrCol = 0;
            for (int i = 0; i < Rows; i++)
            {
                string line = Console.ReadLine();
                if (i == 0)
                {
                    entrCol = line.IndexOf('s');
                }
                for (int j = 0; j < Cols; j++)
                {
                    den[i, j] = line[j];
                }
                line = string.Empty;
            }

            string[] direct = Console.ReadLine().Split(',');
            int SnackyR = 0;
            int SnackyC = entrCol;
            int SnackyL = 3;
            for (int i = 0; i < direct.Length; i++)
            {
                if (SnackyL <= 0)
                {
                    Console.WriteLine("Snacky will starve at [{0},{1}]", SnackyR, SnackyC);
                    return;
                }
                if (i >0 && (i+1) % 5 == 0)
                {
                    SnackyL -= 1;
                }
                if (direct[i] == "l")
                {
                    SnackyC -= 1;
                }
                if (direct[i] == "r")
                {
                    SnackyC += 1;
                }
                if (direct[i] == "u")
                {
                    SnackyR -= 1;
                }
                if (direct[i] == "d")
                {
                    SnackyR += 1;
                }
                if (SnackyC >= Cols)
                {
                    SnackyC = 0;
                }
                if (SnackyC<0)
                {
                    SnackyC = Cols - 1;
                }
                if (SnackyR >= Rows)
                {
                    Console.WriteLine("Snacky will be lost into the depths with length {0}", SnackyL);
                    return;
                }
                if (den[SnackyR, SnackyC] == '*')
                {
                    SnackyL += 1;
                    den[SnackyR, SnackyC] = '.';
                }
                
                if (den[SnackyR, SnackyC] == '#')
                {
                    Console.WriteLine("Snacky will hit a rock at [{0},{1}]", SnackyR, SnackyC);
                    return;
                }
            }
            if (SnackyR==0 && SnackyC==entrCol)
            {
                Console.WriteLine("Snacky will get out with length {0}", SnackyL);
            }
            else
            {
                Console.WriteLine("Snacky will be stuck in the den at [{0},{1}]",SnackyR,SnackyC);
            }

        }
    }
}
