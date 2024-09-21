using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraiangleApp.Domain;

namespace TraiangleApp.Services
{
    public class TriangleClassifier
    {
        public string Classify(Triangle triangle)
        {
            if (triangle.SideA == triangle.SideB && triangle.SideB == triangle.SideC)
            {
                return "Equilateral";
            }
            else if (triangle.SideA == triangle.SideB || triangle.SideB == triangle.SideC || triangle.SideA == triangle.SideC)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}
