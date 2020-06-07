using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    public struct Point3D

    {
        private static readonly Point3D pointO = new Point3D(0, 0, 0);

        public int coordX { get; set; }
        public int coordY { get; set; }
        public int coordZ { get; set; }
        public static Point3D PointO {
            get {return pointO; }
             }


        public Point3D(int X, int Y, int Z)
        {
            this.coordX = X;
            this.coordY = Y;
            this.coordZ = Z;
        }

        public override string ToString()
        {
            StringBuilder Print3DPoint = new StringBuilder();
            Print3DPoint.Append(coordX + ", " + coordY + ", " + coordZ);
            return Print3DPoint.ToString();
        }
    }
}
