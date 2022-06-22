using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        public Classroom(int capacity)
        {
            Capacity = capacity;
            Students = new List<Student>();
        }
        public int Capacity { get; set; }
        public List<Student> Students { get; set; }
        public int Count => Students.Count;

        

     

        

        public string RegisterStudent(Student student)
        {
            if (Count<Capacity)
            {
                Students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }
        public string DismissStudent(string firstName, string lastName)
        {
            Student search = Students.FirstOrDefault(n => n.FirstName == firstName && n.LastName == lastName);
            if (search != null)
            {
                Students.Remove(search);
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return "Student not found";
            }
        }
        public string GetSubjectInfo(string subject)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine("Students:");
            List<Student> search = Students.Where(n => n.Subject == subject).ToList();
            if (search.Count == 0)
            {
                return "No students enrolled for the subject";
            }
            else
            {
            foreach (var item in search)
            {
                sb.AppendLine($"{item.FirstName} {item.LastName}");
            }    
            return sb.ToString();

            }
        }

        public int  GetStudentsCount()
        {
            return Count;
        }
       public Student GetStudent(string firstName, string lastName)
        {
            Student search = Students.FirstOrDefault(n => n.FirstName == firstName && n.LastName == lastName);
            if (search!= null)
            {
                return search;
            }
            return null;
        }

    }
}
