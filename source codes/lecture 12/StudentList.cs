using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_12
{
    public class StudentList
    {
        public List<string> lstStudents = new List<string>();

        public StudentList(List<string> lstVals)
        {
            lstStudents.AddRange(lstVals);
        }

        public StudentList()
        {
            lstStudents.Add("default");
        }
    }
}
