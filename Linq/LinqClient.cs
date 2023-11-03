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
    }
}

