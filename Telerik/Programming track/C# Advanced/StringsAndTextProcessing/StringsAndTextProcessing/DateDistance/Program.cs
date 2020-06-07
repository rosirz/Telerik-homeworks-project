using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DateDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "d.mm.yyyy", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(Console.ReadLine(), "d.mm.yyyy", CultureInfo.InvariantCulture);
            //DateTime start = new DateTime(2016, 01, 05);
            //DateTime end = new DateTime(2016, 03, 05);
            TimeSpan distance = end.Subtract(start);
            Console.WriteLine("{0:dd} days",distance);
            
           
        }
    }
}
