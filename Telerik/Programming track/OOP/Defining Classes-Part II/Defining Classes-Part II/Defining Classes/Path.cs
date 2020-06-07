using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    public class Path
    {
       public static List<Point3D> PathHold = new List<Point3D>();

        //public void CreatePoints()
        //{
        //    PathHold = PathStorage.GetLines();
        //}

        public static void AddPoint(Point3D point)
        {
            PathHold.Add(point);
        }

        public static void PrintPoints(List<Point3D> pathHold)
        {
            for (int i = 0; i < pathHold.Count; i++)
            {
                Console.WriteLine(pathHold[i].ToString());
            }
        }

    }
}
