namespace Persons
{
    public abstract class Person
    {
        public int Id;
        public string Firstname;
        public string Lastname;
        public string Address;

        public Person(string firstName, string lastName, string address, int id)
        {
            Id = id;
            Firstname = firstName;
            Lastname = lastName;
            Address = address;
        }

        public abstract void Display();

    }
}