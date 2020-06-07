using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, Sex sex) : base(name, age, sex)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Myau-u-u-u");
        }
    }
}
