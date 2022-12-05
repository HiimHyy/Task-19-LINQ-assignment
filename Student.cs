using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_19_LINQ_assignment
{
    internal class Student
    {
        public Student(string name, string address, DateTime dateOfBirth) 
        {
            Name = name;
            Address = address;
            DateOfBirth = dateOfBirth;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public override string ToString()
        {
            return String.Format("Name: {0}, Address: {1}, Date of Birth {2}", Name, Address, DateOfBirth.ToShortDateString());
        }
    }
}
