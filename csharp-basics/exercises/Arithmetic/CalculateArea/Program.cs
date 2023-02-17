using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (GetMenu())
            {
                case 1: CalculateCircleArea(); break;
                    case 2: CalculateRectangleArea(); break;
                    case 3: CalculateTriangleArea(); break;
                    case 4: break;
            }
            Console.ReadLine();
        }

        public static int GetMenu()
        {

            int userChoice =0;
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            
                switch (keyboard.KeyChar)
                {
                    case '1': userChoice = 1; break;
                    case '2': userChoice = 2; break;
                    case '3': userChoice = 3; break;
                    case '4': userChoice = 4; break;
                    default: Console.WriteLine("Wrong input try again!"); userChoice = -1; break;
                }
           
            
            return userChoice;
        }

        public static void CalculateCircleArea()
        {

            Console.WriteLine("What is the circle's radius? ");
            decimal radius = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            Console.WriteLine("Enter length? ");
            decimal length = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter width? ");
            decimal width = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfTriangle(length, width));
        }

        public static void CalculateTriangleArea()
        {         
            Console.WriteLine("Enter length of the triangle's base? ");
            decimal ground = decimal.Parse(Console.ReadLine());       
            Console.WriteLine("Enter triangle's height? ");
            decimal height = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfRectangle(ground, height));
        }
    }
}
