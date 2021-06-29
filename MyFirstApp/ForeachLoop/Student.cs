using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.ForeachLoop
{
    class Student
    {
        public int StudentId { get; set; } // genera ua variable privada per sota, per fer-ho al instant escriure prop

        public String Name { get; set; }  // cntrol k + cntrol d per tabular bé tot

        public String Surname { get; set; }

        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Student student && StudentId == student.StudentId && Name == student.Name && Surname == student.Surname && Age == student.Age; 
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudentId, Name, Surname, Age);

        }

    }
}
