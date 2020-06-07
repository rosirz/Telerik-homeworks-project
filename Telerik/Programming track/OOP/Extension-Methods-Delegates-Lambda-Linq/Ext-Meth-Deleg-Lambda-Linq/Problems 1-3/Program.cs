using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ext_Meth_Deleg_Lambda_Linq
{
    


    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder extension method
            Console.WriteLine("StringBuilder extension method");
            string greeting = "Hi everyone!";
            StringBuilder StrBuild= new StringBuilder();
            StrBuild.Append(greeting);
            Console.WriteLine(StrBuild.Substring(3, 8));
            Console.WriteLine();

            //IEnumerable Extension methods
            Console.WriteLine("IEnumerable Extension methods");
            var list = Enumerable.Range(5, 10).ToList();
            Console.WriteLine("list => {0}", string.Join(", ", list));
            Console.WriteLine("The Sum of list is {0}",list.Sum());
            Console.WriteLine("The product of list is {0}", list.Product());
            Console.WriteLine("The Min of list is {0}", list.Min());
            Console.WriteLine("The Max of list is {0}", list.Max());
            Console.WriteLine("The Average of list is {0}", list.Average());
        }
    }
}
