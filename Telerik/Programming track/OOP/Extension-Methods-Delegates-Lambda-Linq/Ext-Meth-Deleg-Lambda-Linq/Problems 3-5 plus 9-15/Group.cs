using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_3_5_plus_9_15
{
    public class Group
    {
        private int groupNumber;
        private string departmentName;

        public Group (int groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }

        public int GroupNumber { get; set; }
        public string DepartmentName { get; set; }
        public List<Group> Groups { get; set; }
    }
}
