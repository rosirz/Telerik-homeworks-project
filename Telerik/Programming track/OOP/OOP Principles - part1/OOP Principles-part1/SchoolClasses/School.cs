using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class School : ISchool
    {
        private string name;
        private List<SchoolClass> classes = new List<SchoolClass>();
        private List<Teachers> allTeachers=new List<Teachers>();
        private List<Disciplines> allSubjects = new List<Disciplines>();
        private List<Students> allStudents = new List<Students>();

        public School(string name)
        {
            this.Name = name;
            this.Classes = classes;
            this.AllTeachers = allTeachers;
            this.AllSubjects = allSubjects;
            this.AllStudents = allStudents;
        }

        public List<SchoolClass> Classes
        {
            get
            {
                return this.classes;
            }

            set
            {
                this.classes=value;
            }
        }

        public List<Teachers> AllTeachers
        {
            get
            {
                return this.allTeachers;
            }

            set
            {
                this.allTeachers=value;
            }
        }

        public List<Disciplines> AllSubjects
        {
            get
            {
               return this.allSubjects;
            }

            set
            {
                this.allSubjects=value;
            }
        }

        public List<Students> AllStudents
        {
            get
            {
                return this.allStudents;
            }

            set
            {
                this.allStudents=value;
            }
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

        public void AddClass()
        {
            this.Classes.Add(new SchoolClass((classes.Count + 1).ToString("D4")));
        }

        public void AddSubject(Disciplines subject)
        {
            this.AllSubjects.Add(subject);
        }

        public void AddTeacher (Teachers teacher)
        {
            this.AllTeachers.Add(teacher);
        }

        public void AddStudent (Students student)
        {
            this.AllStudents.Add(student);
        }

        public bool TeacherToClass (Disciplines subject, Teachers teacher)
        {
            bool check = false;
            for  (int i=0; i<teacher.Subjects.Count; i++)
            {
                
                if(subject.Name == teacher.Subjects[i].Name)
                {
                    check= true;
                    break;
                }
                
            }
            return check;
        }

        public void SpreadTeachersToClasses(List<SchoolClass> classes, List<Teachers> teachers)
        {
            foreach (var newclass in classes)
            {
                foreach (var teacher in teachers)
                {
                    if (TeacherToClass(newclass.MainSubject,teacher))
                    {
                        newclass.ClassTeachers.Add(teacher);
                        break;
                    }
                }
                foreach (var teacher in teachers)
                {
                    if (TeacherToClass(newclass.SecondarySubject, teacher))
                    {
                        newclass.ClassTeachers.Add(teacher);
                        break;
                    }
                }
            }
        }

        public void StudentAttendClass(List<SchoolClass> classes, List<Students> students)
        {
            foreach (var student in students)
            {
                for (int i = 0; i < classes.Count; i++)
                {
                    if (student.ChoosenSubject == classes[i].MainSubject)
                    {
                        classes[i].StudentsInClass.Add(student);
                        student.ClassNumber = classes[i].ClassNumber;
                    }
                }
            }
        }
        public void DescribeShool()
        {
            Console.WriteLine("Welcome to {0}!", this.Name);
            Console.WriteLine();
            Console.WriteLine("We have {0} students in {1} classes", this.AllStudents.Count, this.Classes.Count);
            Console.WriteLine("We have {0} qualified teachers, experts in their area", this.AllTeachers.Count);
            Console.WriteLine("Please enter");
            Console.WriteLine("1 - for more information about teachers");
            Console.WriteLine("2 - for more information about disciplines");
            Console.WriteLine("3 - for more information about classes");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1)
            {
                foreach (var teacher in this.AllTeachers)
                {
                    teacher.Print();
                }
            }
            else if(choose == 2)
            {
                foreach (var subject in this.AllSubjects)
                {
                    subject.PrintDisciplines();
                }
            }
            else if (choose==3)
            {
                foreach (var newclass in this.Classes)
                {
                    newclass.Print();
                }
            }
            else
            {
                return;
            }
        }
    }

    public interface ISchool
    {
        string Name { get; set; }
        List<SchoolClass> Classes { get; set; }
        List<Teachers> AllTeachers { get; set; }
        List<Disciplines> AllSubjects { get; set; }
        List<Students> AllStudents { get; set; }

        void AddClass();
        void AddSubject(Disciplines subject);
        void AddTeacher(Teachers teacher);
        void AddStudent(Students student);
        bool TeacherToClass(Disciplines subject,Teachers teacher);
        void SpreadTeachersToClasses(List<SchoolClass> classes, List<Teachers> teachers);
        void StudentAttendClass(List<SchoolClass> classes,List<Students> students);
        void DescribeShool();
       
       
       
        
    }
}
