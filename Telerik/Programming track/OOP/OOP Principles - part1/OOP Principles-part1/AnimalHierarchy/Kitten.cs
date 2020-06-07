using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Kitten : Cat, ISound
    {
        private string v1;
        private int v2;

        public Kitten(string name, int age) : base(name, age, Sex.Female)
        {
            
        }

        

        public override void MakeSound()
        {
            base.MakeSound();
        }


    }

    
}
