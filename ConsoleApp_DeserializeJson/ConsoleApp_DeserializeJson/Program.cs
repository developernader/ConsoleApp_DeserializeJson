using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp_DeserializeJson
{
    class Program
    {
        public class Car
        {
            public string Name { get; set; }
            public string Model { get; set; }
        }
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public List<string> Courses { get; set; }
            public Car Car { get; set; }
        }


        static void Main(string[] args)
        {
            Student student = JsonConvert.DeserializeObject<Student>(File.ReadAllText(@"C:\Users\nader.saoudy\source\repos\ConsoleApp_DeserializeJson\ConsoleApp_DeserializeJson\json1.json"));
            Console.WriteLine($"Name =  {student.Name} \n Age= {student.Age} " +
                $"\n Car name = {student.Car.Name} " +
                $"\n Car model {student.Car.Model} \n" +
                $" Courses {student.Courses[0] } , {student.Courses[1]} , {student.Courses[2] }");
        }
    }
}
