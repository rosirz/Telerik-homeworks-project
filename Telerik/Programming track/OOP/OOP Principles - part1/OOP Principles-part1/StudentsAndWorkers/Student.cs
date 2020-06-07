using StudentsAndWorkers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class Student : Human, ISudent
    {
        private int grade;

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
               this.grade=value;
            }
        }
    }

    internal interface ISudent
    {
        int Grade { get; set; }
    }
}
