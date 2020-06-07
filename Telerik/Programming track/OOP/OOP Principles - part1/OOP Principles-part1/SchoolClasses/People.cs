using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class People : IPeople
    {
        private string name;
        

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

        

        public People (string name)
        {
            this.Name = name;
            
        }

       
    }

    

    public interface IPeople
    {
        string Name { get; set; }
       
}
}
