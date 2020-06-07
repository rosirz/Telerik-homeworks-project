using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
   public class Animal : IAnimal,  ISound

    {
        private string name;
        private int age;
        private Sex sex;

        public Animal (string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.sex = sex;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age=value;
            }
        }

        public virtual void MakeSound()
        {
            Console.WriteLine ("Make typical animal sound");
        }
    }

    internal interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }
    }
}
