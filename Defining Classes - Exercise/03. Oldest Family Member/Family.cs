namespace DefiningClasses
{
    using System.Collections.Generic;
    using System.Linq;
    

    public class Family
    {
        private List<Person> family;

        public Family()
        {
            family = new List<Person>();
        }
       

        public void AddMember(Person member)
        {
            this.family.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.family.OrderByDescending(m => m.Age).First();
        }
    }
}