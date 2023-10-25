using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieveStudentDataSorting
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<StudentSorting> StudentData = new List<StudentSorting>();
            try
            {
                string path = "C:\\Users\\GANI HARSHA SREE\\source\\repos\\RetrieveStudentDataSorting\\RetrieveStudentDataSorting\\StudentDataSorting.txt";

                string[] student_data = File.ReadAllLines(path);

                foreach (string line in student_data)
                {
                    String[] data = line.Split(',');
                    if (data.Length >= 1)
                    {
                        StudentSorting student = new StudentSorting();
                        student.Sname = data[0];
                        student.ClassName = data[1];
                        StudentData.Add(student);
                    }
                }
                StudentSorting s = new StudentSorting();
                StudentData.Sort(s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("Display Student Data");
            foreach (var student in StudentData)
            {
                Console.WriteLine(student.Sname + " " + student.ClassName);
            }
            Console.WriteLine("=======================================");

            Console.WriteLine("Enter Name To Search :");
            string name = Console.ReadLine();

            StudentSorting sf = Search(StudentData, name);
            if (sf != null)
            {
                Console.WriteLine(sf.Sname + " " + sf.ClassName);
            }
            else
            {
                Console.WriteLine("Not Found.");
            }

            Console.ReadLine();
        }

        public static StudentSorting Search(List<StudentSorting> list, string name)
        {
            StudentSorting Student_found = list.Find(data => data.Sname == name);
            if (Student_found != null)
            {
                return Student_found;
            }
            else
            {
                return null;
            }
        }


    }
}
