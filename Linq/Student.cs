using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Linq
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public static List<Student> GetAllStudents()
        {
            return new List<Student>{
                new Student{Id=1, Name="Rohit", Gender="Male"},
                 new Student{Id=2, Name="Virat", Gender="Male"},
                  new Student{Id=3, Name="Mithali", Gender="Female"},
                   new Student{Id=4, Name="Harman", Gender="Female"},
                    new Student{Id=5, Name="Hardik", Gender="Male"},
                     new Student{Id=6, Name="Smiriti", Gender="Female"},
            };
        }

    }
}
