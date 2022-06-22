using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BakeryOpenning
{
    public class Bakery
    {
        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Employees= new List<Employee>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Employee> Employees { get; set; }

        public int Count => Employees.Count;

        public void Add(Employee employee)
        {
            if (Count < Capacity)
            {
                Employees.Add(employee);
            }
        }
        public bool  Remove(string name)
        {
            Employee search = Employees.FirstOrDefault(n => n.Name == name);
            if (search == null)
            {
                return false;
            }
            Employees.Remove(search);
            return true;
        }
        public Employee GetOldestEmployee()
        {
            return Employees.OrderByDescending(n => n.Age).FirstOrDefault();
        }
        public Employee GetEmployee(string name)
        {
            return Employees.FirstOrDefault(n => n.Name == name);
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery { Name}:");
            foreach (var item in Employees)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
