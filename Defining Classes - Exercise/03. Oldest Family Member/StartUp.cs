namespace DefiningClasses
{
    using DefiningClasses;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Family family = new Family();

            int numberOfMembers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMembers; i++)
            {
                string[] memberInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string name = memberInfo[0];
                int age = int.Parse(memberInfo[1]);

               Person person = new Person(name,age);
                family.AddMember(person);
            }

            Person oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}