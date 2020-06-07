﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age) : base(name, age, Sex.Male)
        {
        }

        public override void MakeSound()
        {
            base.MakeSound();
        }
    }
}
