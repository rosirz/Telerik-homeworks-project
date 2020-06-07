using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_3_5_plus_9_15
{
    class Program
    {

        static void Main(string[] args)
        {
            var students = new List<Student>();
            students.Add(new Student("Ivan", "Petkov", 20, 100005, "35926541533", "ipetkov@abv.bg", new List<int> { 5, 4, 6, 3, 2, 5 }, 3));
            students.Add(new Student("Nik", "Petrov", 21, 110006, "35942321053", "nperkov@mail.bg", new List<int> { 6, 4, 5, 5, 4, 3 }, 4));
            students.Add(new Student("Nadya", "Ivanova", 23, 123011, "0295318741", "nivanova@gmail.com", new List<int> { 3, 2, 6, 3, 2, 5 }, 2));
            students.Add(new Student("Vanya", "Sotirova", 25, 105606, "359888564321", "vsotirova@abv.bg", new List<int> { 5, 5, 4, 3, 2, 5 }, 5));
            students.Add(new Student("Dobri", "Todorov", 23, 121012, "359882100500", "dtodorov@email.bg", new List<int> { 2, 4, 6, 3, 2, 6 }, 2));
            students.Add(new Student("Petar", "Kolev", 19, 113015, "35929553243", "pkolev@yahoo.co.uk", new List<int> { 3, 4, 6, 3, 6, 5 }, 1));
            students.Add(new Student("Georgi", "Ivanov", 18, 103204, "35956864321", "givanov@abv.bg", new List<int> { 6, 4, 2, 3, 2, 5 }, 3));

            //problem 3
            //Write a method that from a given array of students finds all students whose first name is before its last name 
            //alphabetically.
            //Use LINQ query operators.

            //var FirstBeforeLast = from student in students
            //                      where student.FirstName.CompareTo(student.LastName) < 0
            //                      select student;
            var FirstBeforeLast = students
                                  .Where(student => student.FirstName.CompareTo(student.LastName) < 0)
                                  .Select(student => student);
            Console.WriteLine("Students which first name is before last name alphabetivally:");
            foreach (var item in FirstBeforeLast)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
            Console.WriteLine();

            //problem 4
            //Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
            var AgeBetween18and24 = students
                                    .Where(student => student.Age > 18 && student.Age < 24)
                                    .OrderBy(student => student.Age)
                                    .Select(student => student);
            Console.WriteLine("Students with age between 18 and 24:");
            foreach (var student in AgeBetween18and24)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Age);
            }
            Console.WriteLine();

            //problem 5
            //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name 
            //in descending order.
            //Rewrite the same with LINQ.
            var sorted = students.OrderByDescending(student => student.FirstName)
                                 .ThenByDescending(student => student.LastName);
            //var sorted2 = from student in students
            //              orderby student.LastName descending
            //              orderby student.FirstName descending
            //              select student;
            Console.WriteLine("Students sorted first by first name and then by last name in descending order:");
            foreach (var student in sorted)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
            Console.WriteLine();

            //problem 9
            //Select only the students that are from group number 2.
            //Use LINQ query. Order the students by FirstName.
            var studentsInGroup2 = students.
                                   Where(student => student.GroupNumber == 2)
                                   .OrderBy(student => student.FirstName)
                                   .Select(student => student);
            Console.WriteLine("Students from group 2 sorted by first name:");
            foreach (var student in studentsInGroup2)
            {
                Console.WriteLine("Name: {0} {1}, Group: {2}", student.FirstName, student.LastName, student.GroupNumber);
            }
            Console.WriteLine();

            //problem 10
            //Implement the previous using the same query expressed with extension methods.
            Console.WriteLine("Students from group 2 sorted by first name, using extension method:");
            Extension_methods.SortStudentsInGroup2(students);
            Console.WriteLine();

            //problem 11
            //Extract all students that have email in abv.bg.
            var studentsWithEmailInAbv = students
                                                  .Where(student => student.Email.Contains("abv.bg"))
                                                  .Select(student => student);
            Console.WriteLine("Students with emails in abv.bg:");
            foreach (var student in studentsWithEmailInAbv)
            {
                Console.WriteLine("Name: {0} {1}, Email: {2}", student.FirstName, student.LastName, student.Email);
            }
            Console.WriteLine();

            //problem 12
            //Extract all students with phones in Sofia.
            var StudentsWithPhonesInSofia = students
                                                    .Where(student => student.Phone.StartsWith("3592") || student.Phone.StartsWith("02"))
                                                    .Select(student => student);
            Console.WriteLine("Students with phones in Sofia:");
            foreach (var student in StudentsWithPhonesInSofia)
            {
                Console.WriteLine("Name: {0} {1}, Phone: {2}", student.FirstName, student.LastName, student.Phone);
            }
            Console.WriteLine();

            //problem 13
            //Select all students that have at least one mark Excellent (6) into a new anonymous class that has 
            //properties – FullName and Marks.
            var sortedByMark6 = students
                                .Where(student => student.Marks.Contains(6))
                                .Select(student => student);
            var StudentsWith6 = new List<StudentsWithMark6>();

            foreach (var student in sortedByMark6)
            {
                var studentToAdd = new StudentsWithMark6(Student.Fullname(student), student.Marks);
                StudentsWith6.Add(studentToAdd);
            }
            Console.WriteLine("Students who have mark 6");
            foreach (var student in StudentsWith6)
            {
                Console.WriteLine("Name: {0}, Marks: {1}", student.Fullname, PrintMarks(student.Marks));
            }
            Console.WriteLine();

            //problem 14
            //Write down a similar program that extracts the students with exactly two marks "2".
            //Use extension methods.
            Console.WriteLine("Students with two marks 2:");
            var studentsWith2 = Extension_methods.SortStudentsWithMark2(students);

            foreach (var student in studentsWith2)
            {
                Console.WriteLine("Name: {0} {1}, Marks: {2}", student.FirstName, student.LastName, PrintMarks(student.Marks));
            }
            Console.WriteLine();

            //problem 15 
            //Extract all Marks of the students that enrolled in 2006. 
            //(The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            var enrolledIn2006 = students
                                 .Where(student => student.FN.ToString().EndsWith("06"))
                                 .Select(student => student);
            Console.WriteLine("Marks of students enrolled in 2006:");
            foreach (var student in enrolledIn2006)
            {
                Console.WriteLine("Name: {0} {1}, Marks: {2}", student.FirstName, student.LastName, PrintMarks(student.Marks));
            }
            Console.WriteLine();

            //problem 16
            //Create a class Group with properties GroupNumber and DepartmentName.
            //Introduce a property GroupNumber in the Student class.
            //Extract all students from "Mathematics" department.
            //Use the Join operator.
            //var Groups = new List<Group>()
            //{
            //    new Group(1, "Physics"),
            //    new Group(2, "Mathematics"),
            //    new Group(3, "Chemistry"),
            //    new Group(4, "Programming"),
            //    new Group(5, "Biology"),
            //    new Group(6, "Linguistics")
            // };
            //var studentsInMathDepartment = from student in students
            //                               join grop in Groups
            //                               on student.GroupNumber
            //                               equals grop.GroupNumber
            //                               where grop.DepartmentName == "Mathematics"
            //                               select student;
            //foreach (var student in studentsInMathDepartment)
            //{
            //    Console.WriteLine("{0} {1}, {2}, {3}",student.FirstName,student.LastName,student.GroupNumber);
            //}


            //problem 18
            //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
            //Use LINQ.
            var studentsInGroups = from student in students
                                   group student by student.GroupNumber into newGroup
                                   orderby newGroup.Key
                                   select newGroup;

            Console.WriteLine("Students grouped by GroupNumber:");
            foreach (var group in studentsInGroups)
            {
                Console.WriteLine("Group: {0}", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("Name: {0} {1}", student.FirstName, student.LastName);
                }
            }
            Console.WriteLine();

            //problem 19 
            //Rewrite the previous using extension methods.
            Console.WriteLine("Students grouped by GroupNumber, using extension method:");
            Extension_methods.GroupByGroupNumber(students);

        }
        public static string PrintMarks(List<int> marks)
        {
            string Marks = string.Join(", ", marks);
            return Marks;
        }
    }
}
