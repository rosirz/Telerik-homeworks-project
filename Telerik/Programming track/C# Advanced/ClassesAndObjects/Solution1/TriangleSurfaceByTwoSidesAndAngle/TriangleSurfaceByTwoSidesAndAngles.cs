using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write program that calculates the surface of a triangle by given two sides and an angle between them.

//Input

//On the first line you will receive the length of the first side of the triangle
//On the second line you will receive the length of the second side of the triangle
//On the third line you will receive the angle between the given sides
//Angle is given in degrees
//Output

//Print the surface of the rectangle with two digits of precision
namespace TriangleSurfaceByTwoSidesAndAngle
{
    class TriangleSurfaceByTwoSidesAndAngles
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine()); //length of the first side
            double b = double.Parse(Console.ReadLine()); //length of the second side
            double c = double.Parse(Console.ReadLine()); //value of angle c
            //radians = degrees * Math.PI / 180;
            //degrees = radians * 180 / Math.PI;

            double cInRadians = c * Math.PI / 180;
            double SinC = Math.Sin(cInRadians);
            double surface = (a * b * SinC)/ 2;
            Console.WriteLine("{0:f2}",surface);

    }
    }
}
