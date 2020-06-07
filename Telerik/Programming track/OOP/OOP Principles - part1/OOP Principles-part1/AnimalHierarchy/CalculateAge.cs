using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public static class CalculateAge
    {
        

        internal static void CalculateAgeOfAnimals(IEnumerable<Animal> animals)
        {
            double sum = 0;
            string name = "";
            foreach (var animal in animals)
            {
                sum += animal.Age;
                name = animal.GetType().Name;
            }
            double aver = sum / animals.Count();
            Console.WriteLine("Average age in {0} group is {1:F2} years",name , aver);

        }
    }
}
