using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ext_Meth_Deleg_Lambda_Linq
{
    //Problem 2. IEnumerable extensions

    //Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
    //sum, product, min, max, average.


    public static class IEnunerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> list)
        {
            T result = (dynamic)0;
            foreach (var item in list)
            {
                result += (dynamic)item;
            }
            return result;
        }

        public static T Product<T> (this IEnumerable<T> list)
        {
            T result = (dynamic)1;
            foreach (var item in list)
            {
                result *= (dynamic)item;
            }
            return result;
        }
        public static T Min<T>(this IEnumerable<T> list)
        {
            T min = list.First();
            foreach (var item in list)
            {
                if (item<(dynamic)min)
                {
                    min = item;
                }
            }
            
            return min;
        }

        public static T Max<T>(this IEnumerable<T> list)
        {
            T max = list.First();
            foreach (var item in list)
            {
                if (item > (dynamic)max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> list)
        {
            T average = list.Sum()/(dynamic)list.Count();
            return average;
        }
    }
}
