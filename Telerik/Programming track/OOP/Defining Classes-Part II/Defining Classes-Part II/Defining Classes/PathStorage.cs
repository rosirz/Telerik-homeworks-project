using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    static class PathStorage
    {

        

        public static void GetLines()
        {
            string[] Line = System.IO.File.ReadAllLines(@"C:\Users\Rositsa\Documents\Telerik\Programming track\OOP\Defining Classes-Part II\Defining Classes-Part II\Text.txt");
            for (int i = 0; i < Line.Length; i++)
            {
               var line = Line[i].Split(',');
                
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);
                int z = int.Parse(line[2]);
                Point3D point = new Point3D(x, y, z);
                Path.AddPoint(point);
                          
            }
           
        }
    }
}
