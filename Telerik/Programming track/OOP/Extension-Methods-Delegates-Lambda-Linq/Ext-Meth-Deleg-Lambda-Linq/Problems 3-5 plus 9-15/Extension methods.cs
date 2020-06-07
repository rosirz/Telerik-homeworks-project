using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_3_5_plus_9_15
{
    public static class Extension_methods
    {
        public static void SortStudentsInGroup2 (List<Student> students)
        {
            var sorted = from student in students
                         where student.GroupNumber == 2
                         orderby student.FirstName
                         select student;
            foreach (var student in sorted)
            {
                Console.WriteLine("Name: {0} {1}, Group: {2}", student.FirstName, student.LastName, student.GroupNumber);
            }

                
        }
        public static List<Student> SortStudentsWithMark2 (List<Student> students)
        {
            var sorted = new List<Student>();
            int counter = 0;
            for (int i = 0; i < students.Count; i++)
            {
                for (int j = 0; j < students[i].Marks.Count; j++)
                {
                    
                    if (students[i].Marks[j]==2)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    sorted.Add(students[i]);
                    
                }
                counter = 0;
            }
            return sorted;
        }

        public static void GroupByGroupNumber(List<Student> students)
        {
            var studentsInGroups = from student in students
                                   group student by student.GroupNumber into newGroup
                                   orderby newGroup.Key
                                   select newGroup;

            
            foreach (var group in studentsInGroups)
            {
                Console.WriteLine("Group: {0}", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("Name: {0} {1}", student.FirstName, student.LastName);
                }
            }
            Console.WriteLine();
        }
    }
}
