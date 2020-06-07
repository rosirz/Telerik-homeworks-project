using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void OddF(List<int> x)
        {
            foreach (var i in x)
            {
                if (x[i] % 2 != 0) Console.Write("{0} ",x[i]);
            }
        }
        static void EvenF(List<int> x)
        {
            foreach (var i in x)
            {
                if (x[i] % 2 == 0) Console.Write("{0} ", x[i]);
            }
        }
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string s;
            int a, b;
            do
            {
                s = Console.ReadLine();
                int n = s.Length;
                if (s.Contains("Delete")==true) { Console.WriteLine("1"); a = (int)(s[n - 1]); numbers.RemoveAll(x => x == a); }
                if (s.Contains("Insert") == true) { Console.WriteLine("2"); a = (int)(s[n - 1]); b = (int)(s[n - 3]); Console.WriteLine("2_2 {0},{1}",a,b); numbers.Insert(a, b); }
                if (s.Contains("Odd")) { Console.WriteLine("3"); OddF(numbers); break; }
                if (s.Contains("Even")) { EvenF(numbers); break; }
            } while (true);
        }
    }
}
