using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Teachers : People,IPeople, ITeachers
    {
        private List<Disciplines> subjects = new List<Disciplines>();

        public Teachers(string name) : base(name)
        {
        }

        public List<Disciplines> Subjects
        {
            get
            {
                return this.subjects;
            }

            set
            {
                this.subjects=value;
            }
        }

        public void AddSubject(Disciplines Subject)
        {
            this.Subjects.Add(Subject);
        }

        public void RemoveSubject(Disciplines Subject)
        {
            this.Subjects.Remove(Subject);
        }

        public void Print ()
        {
            Console.Write("Name: {0} Subjects: ", this.Name);
            foreach (var subject in Subjects)
            {
                Console.Write("{0}, ", subject.Name);
               
            }
            Console.WriteLine();
        }
    }

    internal interface ITeachers : IPeople
    {
         List<Disciplines> Subjects { get; set; }
         void AddSubject(Disciplines Subject);
         void RemoveSubject(Disciplines Subject);
         void Print();
         
    }
}
