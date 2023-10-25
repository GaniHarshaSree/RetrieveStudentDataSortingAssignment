using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieveStudentDataSorting
{
    public class StudentSorting : IComparer<StudentSorting>
    {
        public string Sname { get; set; }
        public string ClassName { get; set; }

        public int Compare(StudentSorting x, StudentSorting y)
        {
            StudentSorting s1 = x as StudentSorting;
            StudentSorting s2 = y as StudentSorting;
            return s1.Sname.CompareTo(s2.Sname);
        }
    }
}
