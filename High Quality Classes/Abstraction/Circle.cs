using System;

namespace Abstraction
{
   public class Circle : RoundFigure
    {
        public Circle(double radius)
            :base(radius)
        {
            this.Radius = radius;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
