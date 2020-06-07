using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that generates and prints to the console 10 random values in the range [100, 200].
namespace RandomNumbers
{
    class RandomNumbers
    {
        static void Main()
        {
            Random RandNumb = new Random (100);
            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine(RandNumb.Next(100,200));
            }
        }
    }
}
