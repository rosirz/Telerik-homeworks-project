using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> number = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> n = new List<int>();
            for(int i=0;i<number[0];i++)
            { n.Add(numbers[i]); }
            n.RemoveRange(0, number[1]);
            if (n.Contains(number[2]) == true) { Console.WriteLine("YES"); }
            else { Console.WriteLine("NO"); }
        }
    }
}
