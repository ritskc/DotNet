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
            /*var filteredStudents = from students in Student.GetAllStudents()
                                   where students.Gender == "Male"
                                   select students;*/

            var filteredStudents = Student.GetAllStudents().Where(x => x.Gender == "Female").Select(x=>x.Id);


            foreach (var student in filteredStudents)
            {
                Console.WriteLine(student);
            }

            var filteredStudents1 = Student.GetAllStudents().Select(x => new { x.Name, x.Marks });
            foreach (var student in filteredStudents1)
            {
                Console.WriteLine($"{student.Name} has acheived {student.Marks}");
            }

            var filteredStudents2 = Student.GetAllStudents().Select(x => new {StudentName= x.Name, AchievedMarks= x.Marks });
            foreach (var student in filteredStudents2)
            {
                Console.WriteLine($"{student.StudentName} has acheived {student.AchievedMarks}");
            }

            var filteredStudents3 = Student.GetAllStudents().Select(x => new { StudentName = x.Name + " " + x.Gender, AchievedMarks = x.Marks });
            foreach (var student in filteredStudents3)
            {
                Console.WriteLine($"{student.StudentName} has acheived {student.AchievedMarks}");
            }

            Student.GetAllStudents().Where(x => x.Gender == "Male").Select(emp => new { emp.Name, emp.Gender, emp.Marks });

            var subjects = Student.GetAllStudents().SelectMany(x => x.Subjects).Distinct();

            foreach(var subject in subjects)
            {
                Console.WriteLine(subject);
            }

            var result = Student.GetAllStudents().SelectMany(x => x.Subjects, (student, subject) => new { student.Name, subject });

            foreach (var rs in result)
            {
                Console.WriteLine($"{rs.Name} - {rs.subject}");
            }

            Console.WriteLine("Students");
            var sts= Student.GetAllStudents().Where(x=>x.Gender=="Female").Select(sts => new { sts.Name, sts.Gender });

            foreach (var item in sts)
            {
                Console.WriteLine($"{item.Name} is {item.Gender}");
            }

            Func<List<string>, string> GetSubjectsFunc = GetSubjects;

            var sts1 = Student.GetAllStudents().Where(x => x.Gender == "Female").Select(sts => new { sts.Name, sts.Gender,  sub = GetSubjects(sts.Subjects)  });

            foreach (var item in sts1)
            {
                Console.WriteLine($"{item.Name} is {item.Gender} and enrolled in {item.sub} subjects");
            }

            var studentmarks = Student.GetAllStudents().Select(s => new 
            { 
                s.Name,
                examMarks = GetExamMarks(s.ExamResults)
            });

            Console.WriteLine("Here is the result");

            foreach (var item in studentmarks)
            {
                Console.WriteLine($"{item.Name} has obtained {item.examMarks}");
            }
        }

        public static string GetSubjects(List<string> marks)
        {
            return marks.Aggregate((a, b) => a + " , " + b);
        }

        public static string GetExamMarks(List<ExamResult> result)
        {
            var examresult = string.Empty;
            result.ForEach(r =>
            {
                examresult = examresult + Environment.NewLine +  r.Subject + " : " + r.mark;
            });
            return examresult;
        }

        public static void GetNumber()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //return numbers.Min();  returns min number
            Console.WriteLine($"Smallest even number is {numbers.Where(x => x % 2 == 0).Min()}"); // returns smallest min number;

            Console.WriteLine($"Total even number are {numbers.Where(x => x % 2 == 0).Count()}");

            Console.WriteLine($"Sum of  even number are {numbers.Where(x => x % 2 == 0).Sum()}");

            Console.WriteLine($"Average of  even number are {numbers.Where(x => x % 2 == 0).Average()}");

            string[] countries = { "India", "USA", "UK" };

            Console.WriteLine($"Shortest country name has {countries.Min(x => x.Length)} characters");

            Console.WriteLine($"Comma seperated country names are {countries.Aggregate((a, b) => a + " , " + b)}");

            Console.WriteLine($"Sum of the numbers w/o using sum functions is {numbers.Aggregate((number1, number2) => number1 + number2)}");

            Console.WriteLine($"Multiple of the numbers is {numbers.Aggregate((number1, number2) => number1 * number2)}");

            Console.WriteLine($"Multiple of the numbers * 10 is {numbers.Aggregate(10, (number1, number2) => number1 * number2)}");

            Func<int, bool> predicate = x=> x % 2 == 0;
            var evenNumbers = numbers.Where(predicate);

            evenNumbers = numbers.Where(x => IsEven(x));
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static void GetGroup()
        {
            var students = Student.GetAllStudents().OrderBy(s=>s.Name);
            var departments = Student.GetAllDepartments().OrderBy(d=>d.Name);

            var groupJoin = departments.GroupJoin(Student.GetAllStudents(), d => d.Id, s => s.DepartmentId,
                (department, student) => new { department, student });

            
            Console.WriteLine("Group join");

            foreach (var item in groupJoin)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Students in Department {item.department.Name}");
                foreach (var student in item.student)
                {
                    Console.WriteLine($"\t Student name: {student.Name} \t {student.Gender} ");
                }

                Console.WriteLine();
            }

            var innerJoin = students.Join(departments, e => e.DepartmentId, d => d.Id,
                (st, dt) => new {st,dt});

            Console.WriteLine("Inner join");
            foreach (var item in innerJoin)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Students in Department {item.dt.Name}");
                Console.WriteLine($"\t Student name: {item.st.Name} \t {item.st.Gender} ");

                Console.WriteLine();
            }

        }
    }
}

