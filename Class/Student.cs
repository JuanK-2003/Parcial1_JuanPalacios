using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgra3.models
{
    class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Student()
        {

        }

        public Student(string Id, string Name = "", string Address = "")
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
        }
    }
}
