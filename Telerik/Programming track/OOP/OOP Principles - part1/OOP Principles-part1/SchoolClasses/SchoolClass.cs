using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses 
{
    public class SchoolClass : ISchoolClass
    {
        private string classNumber;
        private List<Teachers> classTeachers =new List<Teachers>();
        private Disciplines mainSubject;
        private Disciplines secondarySubject;
        private List<Students> studentsInClass = new List<Students>();

        public SchoolClass(string classNumber)
        {
            this.ClassNumber = classNumber;
        }

        public string ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            set
            {
                this.classNumber=value;
            }
        }

        public List<Teachers> ClassTeachers
        {
            get
            {
                return this.classTeachers;
            }

            set
            {
                this.classTeachers=value;
            }
        }

        public Disciplines MainSubject
        {
            get
            {
                return this.mainSubject;
            }

            set
            {
                this.mainSubject=value;
            }
        }

        public Disciplines SecondarySubject
        {
            get
            {
                return this.secondarySubject;
            }

            set
            {
                this.secondarySubject=value;
            }
        }

        public List<Students> StudentsInClass
        {
            get
            {
                return this.studentsInClass;
            }

            set
            {
                this.studentsInClass=value;
            }
        }

        public void Print()
        {
            Console.WriteLine("Class Number: {0}", this.ClassNumber);
            Console.WriteLine("Teachers: ");
            foreach (var teacher in this.ClassTeachers)
            {
                teacher.Print();
                Console.WriteLine();
                
            }
            Console.WriteLine("Main subject: {0}, Secondary subject: {1};", this.MainSubject.Name, this.SecondarySubject.Name);
            Console.WriteLine("Number of students enrolled: {0};", this.StudentsInClass.Count);
            Console.WriteLine();
        }
        
    }

    public interface ISchoolClass
    {
        string ClassNumber { get; set; }
        List<Teachers> ClassTeachers { get; set; }
        Disciplines MainSubject { get; set;}
        Disciplines SecondarySubject { get; set; }
        List<Students> StudentsInClass { get; set; }

        void Print();
        

    }
}
