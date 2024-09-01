using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace AreaLib
{
    internal class RightTriangle : ATriangle, IGetArea
    {
        public double GetArea()
        {
            return ((side1 * side2) / 2);
        }
        public RightTriangle(double side1, double side2, double side3) : base(side1, side2, side3) { }
    }
}
