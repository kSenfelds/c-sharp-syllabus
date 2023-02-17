using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static decimal AreaOfCircle(decimal radius)
        {
            if (radius<0)
            {
                Console.WriteLine("Negative value entered Area set to 0");
                return 0;
            }
            return (decimal)Math.PI*radius*2m;
        }

        public static decimal AreaOfRectangle(decimal length, decimal width)
        {
            if (length < 0 || width <0)
            {
                Console.WriteLine("Negative value entered Area set to 0");
                return 0;
            }
            return length*width;
        }

        public static decimal AreaOfTriangle(decimal ground, decimal h)
        {
            if (ground < 0 || h<0)
            {
                Console.WriteLine("Negative value entered Area set to 0");
                return 0;
            }
            return ground*h*0.5m;
        }
    }
}
