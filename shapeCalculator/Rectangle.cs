using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculator
{
    internal class Rectangle
    {
        public double a { get; set; }
        public double b { get; set; }

        public double getCircumference()
        {
            return a + b + a + b;
        }

        public double getArea()
        {
            return a * b;
        }
    }
}
