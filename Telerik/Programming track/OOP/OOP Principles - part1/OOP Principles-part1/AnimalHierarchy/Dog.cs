using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Dog : Animal, ISound
    {
        
        public Dog(string name, int age, Sex sex) : base(name, age, sex)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bau-bau");
        }

    }
}
