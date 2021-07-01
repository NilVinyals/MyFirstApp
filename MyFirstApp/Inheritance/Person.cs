using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Inheritance
{
    public class Person
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person()
        {
            Guid = Guid.NewGuid();
        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public override bool Equals(object obj)
        {
            return obj is Person person && Name == person.Name && Surname == person.Surname; 
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Surname);

        }
    }
}
