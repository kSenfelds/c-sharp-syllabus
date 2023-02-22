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
            Console.WriteLine(CalculateSalary(Kristaps));
            Rihards.basePay = 8.20m;
            Rihards.hoursWorked = 47;
            Console.WriteLine(CalculateSalary(Rihards));
            Reinis.basePay = 10.00m;
            Reinis.hoursWorked = 73;
            Console.WriteLine(CalculateSalary(Reinis));

        }
        public static string CalculateSalary(Employee employee)
        {

            if (employee.basePay < 8m || employee.hoursWorked > 60)
            {
                return "Error message";
            }

            if (employee.hoursWorked <= 40)
            {
                return ((decimal)employee.basePay * employee.hoursWorked).ToString();
            }

            return ((decimal)employee.basePay * 40m + (employee.basePay * 1.5m) * (employee.hoursWorked - 40m)).ToString();
        }
    }
    class Employee
    {
        public decimal basePay;
        public int hoursWorked;
       
    }
}