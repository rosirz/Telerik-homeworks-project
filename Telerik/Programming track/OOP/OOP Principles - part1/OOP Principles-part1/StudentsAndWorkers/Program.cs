using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student> {
            new Student ("Ivan","Petrov",3),
            new Student ("Dimitar","Petrov",2),
            new Student ("Petya","Ivanova",1),
            new Student ("Vanya","Petrova",1),
            new Student ("Nikolay","Petkov",2),
            new Student ("Mitko","Ivanov",3),
            new Student ("Petko","Dimitrov",3),
            new Student ("Gosho","Stoyanov",4),
            new Student ("Tosho","Nikolov",3),
            new Student ("Ivan","Draganov",3),
            };

            var sortedStudents = students
                                        .OrderBy(student => student.Grade)
                                        .Select(student => student);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}, grade {2}", student.FirstName, student.LastName, student.Grade);
            }
            Console.WriteLine();


            var workers = new List<Worker>
            {
                new Worker ("Ivan","Petrov",250,8),
                new Worker ("Dimitar","Petrov",300,8),
                new Worker ("Petya","Ivanova",200,4),
                new Worker ("Vanya","Petrova",400,8),
                new Worker ("Nikolay","Petkov",100,3),
                new Worker ("Mitko","Ivanov",250,4),
                new Worker ("Petko","Dimitrov",438,8),
                new Worker ("Gosho","Stoyanov", 326,4),
                new Worker ("Tosho","Nikolov",264,8),
                new Worker ("Ivan","Draganov",500,8),
                };

            var sorted = workers
                                .OrderBy(worker => worker.MoneyPerHour())
                                .Select(worker => worker);
            foreach (var worker in sorted)
            {
                Console.WriteLine("{0} {1}, money per hour: {2:F2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }
            Console.WriteLine();

            var merged = students.Concat<Human>(workers);
            var sortedMerged = merged
                                     .OrderBy(human => human.FirstName)
                                     .ThenBy(human => human.LastName);

            foreach (var person in sortedMerged)
            {
                Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
            }
                                                        

        }
    }
}
