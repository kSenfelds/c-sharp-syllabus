using System.Runtime.CompilerServices;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Kristaps = new Employee();
            Employee Rihards= new Employee();
            Employee Reinis = new Employee();
            Kristaps.basePay = 7.50m;
            Kristaps.hoursWorked = 35;
            Console.WriteLine(Kristaps.CalculateSalary());
            Rihards.basePay = 8.20m;
            Rihards.hoursWorked = 47;
            Console.WriteLine(Rihards.CalculateSalary());
            Reinis.basePay = 10.00m;
            Reinis.hoursWorked = 73;
            Console.WriteLine(Reinis.CalculateSalary());

        }
    }
    class Employee
    {
        public decimal basePay;
        public int hoursWorked;
       public string CalculateSalary ()
        {
            
            if (this.basePay <8m || this.hoursWorked > 60) 
            {
                return "Error message";
            }

            if (this.hoursWorked<=40)
            {
                return ((decimal)this.basePay*this.hoursWorked).ToString();
            }

            return ((decimal)this.basePay * 40m + (this.basePay * 1.5m) * (this.hoursWorked - 40m)).ToString();
        }
    }
}