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

        public int DepartmentId { get; set; }

        public List<string> Subjects { get; set; }

        public List<ExamResult> ExamResults { get; set; }

        public static List<Student> GetAllStudents()
        {
            return new List<Student>{
                new Student{Id=1, Name="Rohit", Gender="Male", Marks=80, DepartmentId = 1, Subjects = new List<string>{"C#", "Ajax", ".Net"},
                    ExamResults = new List<ExamResult>{
                        new ExamResult { Subject="C#", mark=70 },
                        new ExamResult { Subject="Ajax", mark=80 },
                        new ExamResult { Subject=",Net", mark=90 },
                    },
                },
                 new Student{Id=2, Name="Virat", Gender="Male", Marks=70,DepartmentId = 2, Subjects = new List<string>{"C#", "Ajax", ".Net"},
                 ExamResults = new List<ExamResult>{
                        new ExamResult { Subject="C#", mark=56 },
                        new ExamResult { Subject="Ajax", mark=60 },
                        new ExamResult { Subject=",Net", mark=70 },
                    },},
                  new Student{Id=3, Name="Mithali", Gender="Female", Marks=60,DepartmentId = 3, Subjects = new List<string>{"C#", "Ajax", ".Net"},
                  ExamResults = new List<ExamResult>{
                        new ExamResult { Subject="C#", mark=40 },
                        new ExamResult { Subject="Ajax", mark=30 },
                        new ExamResult { Subject=",Net", mark=50 },
                    },},
                   new Student{Id=4, Name="Harman", Gender="Female", Marks=65, DepartmentId = 1,Subjects = new List<string>{"C#", "Ajax", ".Net", "Java"},
                   ExamResults = new List<ExamResult>{
                        new ExamResult { Subject="C#", mark=70 },
                        new ExamResult { Subject="Ajax", mark=70 },
                        new ExamResult { Subject=",Net", mark=70 },
                    },},
                    new Student{Id=5, Name="Hardik", Gender="Male", Marks=75,DepartmentId = 2, Subjects = new List<string>{"C#", "Ajax", ".Net"},
                    ExamResults = new List<ExamResult>{
                        new ExamResult { Subject="C#", mark=70 },
                        new ExamResult { Subject="Ajax", mark=70 },
                        new ExamResult { Subject=",Net", mark=70 },
                    },},
                     new Student{Id=6, Name="Smiriti", Gender="Female", Marks=85, DepartmentId = 3,Subjects = new List<string>{"C#", "Ajax", ".Net","Angular"},
                     ExamResults = new List<ExamResult>{
                        new ExamResult { Subject="C#", mark=70 },
                        new ExamResult { Subject="Ajax", mark=70 },
                        new ExamResult { Subject=",Net", mark=70 },
                    },},
            };
        }

        public static List<Department> GetAllDepartments()
        {
            return new List<Department>()
        {
            new Department{ Id= 1, Name="Engineering"},
            new Department{ Id= 2, Name="Maths"},
            new Department{ Id= 3, Name="Mechanical"},
            new Department{ Id= 4, Name="Electronics"},
        };

        }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ExamResult
    {
        public string Subject { get; set; }
        public int mark { get; set; }
    }
}
