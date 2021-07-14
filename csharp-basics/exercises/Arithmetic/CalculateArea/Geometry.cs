using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double areaOfCircle(decimal radius)
        {
            if (radius < 0)
            {
                throw new NotImplementedException();
            }
            double circleArea = Math.Round(Math.PI * Math.Pow((double)radius, 2),2);
            return circleArea;
        }

        public static double areaOfRectangle(decimal length, decimal width)
        {
            if (length < 0 || width < 0)
            {
                throw new NotImplementedException();
            }
            double rectangleArea = Math.Round((double)length * (double)width, 2);
            return rectangleArea;
        }

        public static double areaOfTriangle(decimal ground, decimal h)
        {
            if (ground < 0 || h < 0)
            {
                throw new NotImplementedException();
            }
            double triangleArea = Math.Round((double)ground * (double)h / 2, 2);
            return triangleArea;
        }
    }
}
