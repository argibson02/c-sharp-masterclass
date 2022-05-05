using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtables
{
    public class Student
    {
        // properties
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        // constructors
        public Student(int id, string name, float gpa)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = gpa;
        }
    }
}
