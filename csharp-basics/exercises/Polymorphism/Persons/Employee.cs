using System;

namespace Persons
{
    internal class Employee : Person
    {
        private string _jobTitle;

        public Employee(string firstName, string lastName, string adress, int id, string jobTitle) : base(firstName, lastName, adress, id)
        {
            _jobTitle = jobTitle;
        }

        public override void Display()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Firstname);
            Console.WriteLine(Lastname);
            Console.WriteLine(Address);
            Console.WriteLine(_jobTitle);
        }
    }
}