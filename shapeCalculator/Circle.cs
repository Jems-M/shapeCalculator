using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculator
{
    public class Circle
    {
        public double radius { get; set; }

        public double getCircumference()
        {
            return Math.Round(radius * 2 * Math.PI, 4);
        }

        public double getArea()
        {
            return Math.Round(radius * radius * Math.PI, 4);
        }
    }
}
