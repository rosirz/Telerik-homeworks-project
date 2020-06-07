using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    static class Distance
    {
       public static double DistanceBetweenPoints (Point3D first, Point3D second)
        {
            double distance = Math.Sqrt((second.coordX - first.coordX) * (second.coordX - first.coordX) +
                                        (second.coordY - first.coordY) * (second.coordY - second.coordY) +
                                        (second.coordZ - first.coordZ) * (second.coordZ - first.coordZ));
            return distance;
        }
    }
}
