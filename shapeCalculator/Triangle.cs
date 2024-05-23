using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculator
{
    public class Triangle
    {
        public double a {  get; set; }
        public double b { get; set; }
        public double c { get; set; }


        public double getCircumference()
        {
            return a + b + c;
        }

        public double getArea()
        {
            double s = (a + b + c) / 2;

            if (s <= 0)
            {
                return -1; //invalid triangle
            } else
            {
                return Math.Sqrt(s * (s-a) * (s-b) * (s-c));
            }

            
        }
    }
}
