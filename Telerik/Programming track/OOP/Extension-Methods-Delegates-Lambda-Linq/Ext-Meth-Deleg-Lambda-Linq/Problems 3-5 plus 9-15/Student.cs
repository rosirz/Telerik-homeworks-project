using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_3_5_plus_9_15
{
    public class Student
    //Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
    {
        private string firstName;
        private string lastName;
        private int age;
        private int fN;
        private string phone;
        private string email;
        private List<int> marks;
        private int groupNumber;
        List<Student> students;

        public Student(string firstName, string lastName, int age, int fN, string phone, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FN = fN;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public int FN { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public List<int> Marks { get; private set; }
        public int GroupNumber { get; private set; }
        public List<Student> Students { get; private set; }

        

        public static string Fullname (Student student)
        {
            var fullName = new StringBuilder();
            fullName.Append(student.FirstName + " " + student.LastName);
            return fullName.ToString();
        }

        
    }

    
}
