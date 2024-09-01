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

        private static double GetCircleArea(double radius)
        {
            IGetArea shape = new Circle (radius);
            return shape.GetArea();
        }
        private static double GetTriangleArea(double side1, double side2, double side3)
        {
            IGetArea triangle = ATriangle.CreateTriangle(side1, side2, side3);
            return triangle.GetArea();
        }
        
        public static double GetAreaRunTime(Shape shape, double side1 = 0, double side2 = 0, double side3 = 0, double radius = 0)
        {
            switch (shape)
            {
                case Shape.Triangle:
                    return GetTriangleArea(side1, side2, side3);
                case Shape.Circle:
                    return GetCircleArea(radius);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
