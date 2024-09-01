using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib
{
    internal class Triangle : ATriangle, IGetArea
    {
        public double GetArea()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }
        public Triangle(double side1, double side2, double side3) : base(side1, side2, side3) { }
    }
}