using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib
{
    public class Area
    {
        /// <summary>
        /// Тип фигуры
        /// </summary>
        public enum Shape
        {
            Triangle,
            Circle
        }
        /// <summary>
        /// Расчёт площади фигуры
        /// </summary>
        /// <param name="shape">Тип фигуры</param>
        /// <param name="a">Сторона 1</param>
        /// <param name="b">Сторона 2</param>
        /// <param name="c">Сторона 3</param>
        /// <param name="r">Радиус</param>
        /// <returns>Площадь фигуры</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static double GetArea (Shape shape, double a = 0, double b = 0, double c = 0, double r = 0)
        {
            switch (shape)
            {
                case Shape.Triangle:
                    Sort();
                    if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                    {
                        return (a*b)/2;
                    }
                    else {
                        double p = (a + b + c) / 2;
                        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    }
                case Shape.Circle:
                    return Math.Pow(r, 2) * 3.14d;
                default:
                    throw new NotImplementedException();
            }
            void Sort()
            {
                double[] mas = {a, b, c};
                Array.Sort(mas);
                a = mas[0]; b = mas[1]; c = mas[2];
            }
        }
    }
}
