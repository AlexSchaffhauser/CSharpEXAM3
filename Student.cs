using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM3
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsRegistered { get; set; }

        public Student() { }
        public Student(int Id, string FirstName, string LastName, bool IsRegistered)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IsRegistered = IsRegistered;
        }
    }
}
