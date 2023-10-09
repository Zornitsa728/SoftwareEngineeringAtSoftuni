using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;
        public Family() 
        {
            this.people = new List<Person>();
        }

        public void AddMembers(Person member)
        {
            this.people.Add(member);
        }

        public List<Person> GetOldestMembers()
        {
            return people.Where(x => x.Age > 30).ToList();
        }
    }
}
