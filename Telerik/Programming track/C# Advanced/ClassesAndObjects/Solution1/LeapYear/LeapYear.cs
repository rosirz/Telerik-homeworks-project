using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a year from the console and checks whether it is a leap one.

//Hint: Use System.DateTime.

//Input

//On the only line you will receive a number - the year
//Output

//Print "Leap" or "Common" on a single line depending on the year
namespace LeapYear
{

    class LeapYear
    {
        static void Main()
        {
        int year = int.Parse(Console.ReadLine());
        bool IsLeap = System.DateTime.IsLeapYear(year);
            if (IsLeap)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
