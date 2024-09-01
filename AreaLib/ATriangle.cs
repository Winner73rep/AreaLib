using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib
{
    internal abstract class ATriangle
    {
        protected double side1;
        protected double side2;
        protected double side3;
        private static void Sort(ref double side1, ref double side2, ref double side3)
        {
            double[] mas = { side1, side2, side3 };
            Array.Sort(mas);
            side1 = mas[0]; side2 = mas[1]; side3 = mas[2];
        }
        private void Validate()
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0) throw new Exception("Сторона должна быть больше 0!");
            if (side3 >= side1 + side2) throw new Exception("Треугольник не существует!");
        }

        public ATriangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            Validate();
        }

        public static IGetArea CreateTriangle(double side1, double side2, double side3)
        {
            Sort(ref side1, ref side2, ref side3);
            if (Math.Pow(side3, 2) == Math.Pow(side2, 2) + Math.Pow(side1, 2))
            {
                return new RightTriangle(side1, side2, side3);
            }
            else
            {
                return new Triangle(side1, side2, side3);
            }
        }

    }
}
