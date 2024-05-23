using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculator
{
    internal class Circle
    {
        public double radius { get; set; }

        public double getCircumference()
        {
            return radius * 2 * Math.PI;
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }
    }
}
