using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new school and disciplines
             var school = new School("Mathematic school");
            string[] disciplines = "Mathematics,Informatics,Biology,Chemstry,English,German".Split(',').ToArray();
            for (int i = 0; i < disciplines.Length; i++)
            {
                school.AddSubject(new Disciplines(disciplines[i]));
            }
            //create teachers and add to school
            var teach1 = new Teachers("Mr. Kolev");
            teach1.AddSubject(school.AllSubjects[0]);
            teach1.AddSubject(school.AllSubjects[3]);
            school.AddTeacher(teach1);
            var teach2 = new Teachers("Mr. Ivanov");
            teach2.AddSubject(school.AllSubjects[1]);
            teach2.AddSubject(school.AllSubjects[2]);
            school.AddTeacher(teach2);
            var teach3 = new Teachers("Mrs. Dobreva");
            teach3.AddSubject(school.AllSubjects[4]);
            teach3.AddSubject(school.AllSubjects[5]);
            school.AddTeacher(teach3);
            var teach4 = new Teachers("Mr. Petrov");
            teach4.AddSubject(school.AllSubjects[1]);
            teach4.AddSubject(school.AllSubjects[5]);
            school.AddTeacher(teach4);

            //create students and add to school
            var stud1 = new Students("Pesho");
            stud1.ChooseMainSubject(school.AllSubjects[1]);
            school.AddStudent(stud1);
            var stud2 = new Students("Gosho");
            stud2.ChooseMainSubject(school.AllSubjects[0]);
            school.AddStudent(stud2);
            var stud3 = new Students("Penka");
            stud3.ChooseMainSubject(school.AllSubjects[1]);
            school.AddStudent(stud3);
            var stud4 = new Students("Vanya");
            stud4.ChooseMainSubject(school.AllSubjects[0]);
            school.AddStudent(stud4);
            var stud5 = new Students("Misho");
            stud5.ChooseMainSubject(school.AllSubjects[1]);
            school.AddStudent(stud5);
            var stud6 = new Students("Mitko");
            stud4.ChooseMainSubject(school.AllSubjects[0]);
            school.AddStudent(stud6);
            //create classes
            school.AddClass();
            school.AddClass();
            school.AddClass();
            //add subjects to each class
            for (int i = 0, j=school.AllSubjects.Count-1; i < school.Classes.Count; i++,j--)
            {
                school.Classes[i].MainSubject = school.AllSubjects[i];
                school.Classes[i].SecondarySubject = school.AllSubjects[j];
            }
            //set teachers to classes
            school.SpreadTeachersToClasses(school.Classes, school.AllTeachers);

            //spread students to classes
            school.StudentAttendClass(school.Classes, school.AllStudents);

            school.DescribeShool();
           



        }
    }
}
