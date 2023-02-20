using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    internal class FizzBuzz
    {
        private string fizzBuzz(int number)
        {
           
           
                if (number %5==0 && number %3 == 0)
                {
                    return "FizzBuzz";
                }
                else if (number % 5 == 0)
                {
                    return "Buzz";
                }
                else if (number %3 == 0)
                {
                    return "Fizz";
                }
                else
                {
                    return number.ToString();
                }
           
            
        }
        public void printFizzBuzz (int numbersPerLine, int maxValue)
        {
           
                int counter = 1;
                string result = "";
                for (int i = 1; i <= maxValue; i++)
                {
                    
                    if (i == maxValue)
                    {
                        Console.WriteLine(result + fizzBuzz(i));
                    }
                    else if (counter <= numbersPerLine)
                    {
                        result += fizzBuzz(i)+ " ";
                        counter++;
                    }

                    else
                    {
                        Console.WriteLine(result);
                        counter = 2;
                        result = fizzBuzz(i) + " ";

                    }
                }
            
        }
    }
}
