using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int min = int.MinValue, z = 0, k = 0;
            for (int i = 0; i < numbers.Count - 1; i++)
            { min = numbers[i]; k = i;
                for (int j = i + 1; j < numbers.Count; j++)
                { if (numbers[j] < min) { min = numbers[j]; k = j; } }
                z = numbers[i]; numbers[i] = numbers[k]; numbers[k] = z;
            }
            int n = numbers.Count;
            int h = numbers[0];
            Console.WriteLine(numbers[0]);
            int o = numbers.Count(x => x == h);
            Console.WriteLine("{0}->{1}", numbers[0], o);
            for (int i = 1; i < n; i++)
            {

                if (numbers[i] != numbers[i - 1])
                {
                    o = numbers.Count(x => x == numbers[i]);
                    Console.WriteLine("{0}->{1}", numbers[i], o);
                }
            }
        }
    }
}
