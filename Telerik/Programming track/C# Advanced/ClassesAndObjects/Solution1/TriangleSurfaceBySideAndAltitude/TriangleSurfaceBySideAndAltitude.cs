using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write program that calculates the surface of a triangle by given a side and an altitude to it.

//Input

//On the first line you will receive the length of a side of the triangle
//On the second line you will receive the altitude to that side
//Output

//Print the surface of the rectangle with two digits of precision
namespace TriangleSurfaceBySideAndAltitude
{
    class TriangleSurfaceBySideAndAltitude
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine()); // the length of the side
            double h = double.Parse(Console.ReadLine()); //the length of the altitude
            double surface = (a * h) / 2;
            Console.WriteLine("{0:f2}",surface);
        }
    }
}
