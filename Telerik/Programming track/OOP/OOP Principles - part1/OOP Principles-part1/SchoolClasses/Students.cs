using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Students : People, IPeople, IStudents
    {
        private string classNumber;
        private Disciplines choosenSubject;

        public Students(string name) : base(name)
        {
            
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

        public Disciplines ChoosenSubject
        {
            get
            {
                return this.choosenSubject;
            }

            set
            {
                this.choosenSubject=value;
            }
        }
        public void ChooseMainSubject(Disciplines subject)
        {
            this.ChoosenSubject = subject;
        }
    }

    internal interface IStudents : IPeople
    {
        string ClassNumber { get; set; }
        Disciplines ChoosenSubject { get; set; }
        void ChooseMainSubject(Disciplines subject);

    }
}
