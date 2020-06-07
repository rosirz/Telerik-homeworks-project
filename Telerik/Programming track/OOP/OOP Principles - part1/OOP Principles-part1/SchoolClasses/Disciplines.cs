using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Disciplines : IDisciplines
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Disciplines (string name, int numberOfLectures = 10, int numberOfExercises = 20 )
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
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

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            set
            {
                this.numberOfLectures=value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }

            set
            {
                this.numberOfExercises=value;
            }
        }

        public void PrintDisciplines ()
        {
            Console.WriteLine("{0} - number of lectures: {1}, number of exercises: {2}", this.Name, this.NumberOfLectures, this.NumberOfExercises);
        }
    }

    public interface IDisciplines
    {
        string Name { get; set; }
        int NumberOfLectures { get; set; }
        int NumberOfExercises { get; set; }
        void PrintDisciplines();
    }
}
