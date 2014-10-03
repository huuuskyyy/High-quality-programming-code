using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class AngularFigure : Figure
    {
        private double width;
        private double height;

        public AngularFigure(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get
            {
                if (this.width <= 0)
                {
                    throw new ArgumentException("Width must be greater than 0!");
                }
                else
                {
                    return this.width;
                }
            }

            set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                if (this.height <= 0)
                {
                    throw new ArgumentException("Height must be greater than 0!");
                }
                else
                {
                    return this.height;
                }
            }

            set
            {
                this.height = value;
            }
        }

        public override double CalculatePerimeter()
        {
            return (this.width * this.width) + (this.height * this.height);
        }

        public override double CalculateSurface()
        {
            return this.height * this.width;
        }
    }
}
