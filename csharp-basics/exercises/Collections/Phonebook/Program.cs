using PhoneBook;
using System;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory phone1 = new PhoneDirectory();
            phone1.PutNumber("Kristaps", "29624436");
            phone1.PutNumber("Rihards", "29654332");
            phone1.PutNumber("Kristaps", "287");
            Console.WriteLine(phone1.GetNumber("Kristaps"));

            Console.ReadKey();
        }
    }
}
