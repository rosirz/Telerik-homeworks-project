using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_3_5_plus_9_15
{
    public class StudentsWithMark6 
    {


        public StudentsWithMark6(string fullname, List<int> marks)
        {
            this.Fullname = fullname;
            this.Marks = marks;
        }


        public string Fullname { get; set; }
       
        public List<int> Marks { get; set; }
        public List<StudentsWithMark6> Students { get; set; }


    }
}
