using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiFigure
{
    internal class AsciiFigure
    {
        private const int slash2 = 92; // => \
        private const int slash1 = 47; // => /
        private const int star = 42;   // => *

        public void printFigure(int lines)
        {
            int counter = 4;
            int length = (lines -1)*counter;
            for (int i =0; i<lines; i++)
            {
                string firstSlash = new string((char)slash1, length);
                string secondSlash = new string((char)slash2, length);
                string stars = new string ((char)star, counter*i);
                firstSlash = firstSlash.Substring(0, length - stars.Length)+stars;
                secondSlash = stars+secondSlash.Substring(0, length - stars.Length);
                Console.WriteLine(firstSlash + secondSlash);
            }
        }
    }
    
}
