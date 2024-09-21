using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraiangleApp.Domain
{
    public class Triangle
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            if (!IsValidTriangle())
            {
                throw new ArgumentException("The provided sides do not form a valid triangle.");
            }
        }

        public bool IsValidTriangle()
        {
            return SideA > 0 && SideB > 0 && SideC > 0 &&
                   SideA + SideB > SideC &&
                   SideA + SideC > SideB &&
                   SideB + SideC > SideA;
        }
    }
}
