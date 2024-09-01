using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib
{
    internal class Circle : IGetArea
    {
        private double radius;
        private void Validate() {
            if (radius <= 0) throw new Exception("Радиус должен быть больше 0!"); ;
        }
        public double GetArea()
        {
            return Math.Pow(radius, 2) * 3.14d;
        }
        public Circle(double radius) {
            this.radius = radius;
            Validate();
        }
    }
}
