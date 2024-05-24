using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculator
{
    public class Rectangle
    {
        public double a { get; set; }
        public double b { get; set; }

        public double getCircumference()
        {
            return Math.Round(a + b + a + b, 4);
        }

        public double getArea()
        {
            return Math.Round(a * b, 4);
        }
    }
}
