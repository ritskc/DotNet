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

        public int Marks { get; set; }

        public static List<Student> GetAllStudents()
        {
            return new List<Student>{
                new Student{Id=1, Name="Rohit", Gender="Male", Marks=80},
                 new Student{Id=2, Name="Virat", Gender="Male", Marks=70},
                  new Student{Id=3, Name="Mithali", Gender="Female", Marks=60},
                   new Student{Id=4, Name="Harman", Gender="Female", Marks=65},
                    new Student{Id=5, Name="Hardik", Gender="Male", Marks=75},
                     new Student{Id=6, Name="Smiriti", Gender="Female", Marks=85},
            };
        }

    }
}
