using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write program that calculates the surface of a triangle by given its three sides.

//Input

//On the first line you will receive the length of the first side of the triangle
//On the second line you will receive the length of the second side of the triangle
//On the third line you will receive the length of the third side of the triangle
//Output

//Print the surface of the rectangle with two digits of precision
namespace TriangleSurface
{
    class TriangleSurface
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine()); //length of first side
            double b = double.Parse(Console.ReadLine()); //length of second side
            double c = double.Parse(Console.ReadLine()); //length of third side
            double p = (a + b + c) / 2;
            double temp = p * (p - a) * (p - b) * (p - c);
            double surface = Math.Sqrt(temp);
            Console.WriteLine("{0:f2}", surface);
        }
    }
}
