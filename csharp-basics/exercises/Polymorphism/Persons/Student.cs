using System;

namespace Persons
{
    public class Student : Person
    {
        private double _gpa;

        public Student(string firstName, string lastName, string adress, int id, double gpa) : base(firstName, lastName, adress, id)
        {
            _gpa = gpa;
        }

        public override void Display()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Firstname);
            Console.WriteLine(Lastname);
            Console.WriteLine(Address);
            Console.WriteLine(_gpa);
        }
    }
}