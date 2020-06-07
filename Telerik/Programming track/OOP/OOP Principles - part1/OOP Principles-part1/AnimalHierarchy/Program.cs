using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new List<Dog>
            {
                new Dog ("Sharo", 5,Sex.Male),
                new Dog ("Rex",6,Sex.Male),
                new Dog ("Balkan", 3,Sex.Male)
            };

            var cats = new List<Cat>
            {
                new Cat("Pisi",4,Sex.Female),
                new Cat ("Shushi",2,Sex.Female),
                new Kitten ("Fifi",4),
                new Kitten ("Maci",2),
                new Tomcat ("Tom",5),
                new Tomcat ("Mark",2)

            };

            var frogs = new List<Frog>
            {
                new Frog ("Greeny", 1,Sex.Female),
                new Frog ("Loudy",2,Sex.Male)
            };

            CalculateAge.CalculateAgeOfAnimals(dogs);
            CalculateAge.CalculateAgeOfAnimals(cats);
            CalculateAge.CalculateAgeOfAnimals(frogs);

        }
    }
}
