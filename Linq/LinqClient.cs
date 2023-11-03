using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Linq
{
    public static class LinqClient
    {
        public static void Get()
        {
            var filteredStudents = from students in Student.GetAllStudents()
                                   where students.Gender == "Male"
                                   select students;

            //var filteredStudents = Student.GetAllStudents().Where(x => x.Gender == "Female");


            foreach (var student in filteredStudents)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
