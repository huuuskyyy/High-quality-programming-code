using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class RoundFigure : Figure
    {
        private double radius;

        public double Radius
        {
            get
            {
                if (this.radius <= 0)
                {
                    throw new ArgumentException("Radius must be greater than 0!");
                }
                else
                {
                    return this.radius;
                }
            }
            set
            {
                this.radius = value;
            }

        }

        public RoundFigure(double radius)
        {
            this.radius = radius;
        }

        public override double CalculatePerimeter()
        {
            return Math.PI * this.radius;
        }

        public override double CalculateSurface()
        {
            return Math.PI * this.radius * this.radius;
        }
    }
}
