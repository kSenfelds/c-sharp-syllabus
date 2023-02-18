using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            if (radius<0)
            {
                Console.WriteLine("Negative value entered Area set to 0");
                return 0;
            }
            return Math.PI*(double)radius*2d;
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {

            if (length < 0 || width <0)
            {
                Console.WriteLine("Negative value entered Area set to 0");
                return 0;
            }
            
            return (double)(length * width);
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            if (ground < 0 || h<0)
            {
                Console.WriteLine("Negative value entered Area set to 0");
                return 0;
            }
            
            return (double)(ground*h*0.5m);
        }
    }
}
