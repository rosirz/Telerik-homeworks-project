using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranica
{
    class Program
    {
        //static int s, n, k = 100000000;
        //public static int[] A;

        //public static void find (int p, int T,int m)
        //{
        //    int br;
        //    br = (s - T) / A[p];
        //    if (m+br < k)
        //    {
        //        if (T+br*A[p]==s)
        //        {
        //            k = m + br;
        //        }
        //        else if (p<n)
        //        {
        //            while (br>=0)
        //            {
        //                find(p + 1, T + br * A[p], m + br);
        //                br--;
        //            }
        //        }
        //    }
        //}
        static void Main(string[] args)
        {
            //1000 7
            //2 12 11 1 14 18 30
            int[] A = new int[7] {30,18,14,12,11,2,1 };
            int s = 1000;
            int n = 7;
            // find(0, 0, 0);
            int count = 0;
            int sum = 0;
            int tempCount = s/A[0];
            int minCount = s;
            for (int i = 0; i < A.Length; i++)
            {
                for (int k = tempCount; k >0; k--)
                {
                    tempCount = k;
                    sum += A[i] * tempCount;
                    count += tempCount;
                    if (sum == s)
                    {
                        break;
                    }
                    else
                    {
                        for (int j = i + 1; j < A.Length; j++)
                        {
                            tempCount = (s - sum) / A[j];
                            sum += A[j] * tempCount;
                            count += tempCount;
                            if (sum == s)
                            {
                                break;
                            }

                        }

                    }
                    if (count < minCount)
                    {
                        minCount = count;
                    }
                    count = 0;
                    sum = 0;
                }
            }
            Console.WriteLine(minCount);
        }
    }
}
