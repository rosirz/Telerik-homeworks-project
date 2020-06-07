using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probi
{
    class Fibonachi
    {
        public static long[] numbers;
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            numbers = new long[n + 2];
            numbers[1] = 1;
            numbers[2] = 1;

            long result = fib(n);
            Console.WriteLine(result);
        }

        public static long fib(int n)
        {
            if (numbers[n] == 0)
            {
                numbers[n] = fib(n - 1) + fib(n - 2);
            }
            return numbers[n];
               
        }
    }
}
