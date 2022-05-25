using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);
                if (!students.ContainsKey(name))
                {
                    students[name] = new List<decimal>();
                }
                students[name].Add(grade);

            }
            foreach (var name in students.Keys)
            {
                decimal avr = students[name]. Average();
                List<decimal> grades = students[name];
            string gr = string.Join(" ", grades.Select(x => x.ToString("f2")));

                Console.WriteLine($"{name} -> {gr} (avg: {avr:f2})");
            }
            //foreach (var student in students)
            //{
            //    Console.Write($"{student.Key} -> ");
            //    foreach (var grade in student.Value)
            //    {
            //        Console.Write($"{grade:F2} ");
            //    }
            //    Console.WriteLine($"(avg: {student.Value.Average():F2})");
            //}
        }
    }
}
