using System;

namespace CohesionAndCoupling
{
    public class Cube
    {
        private double width;
        private double height;
        private double depth;
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

        public double Depth
        {
            get
            {
                if (this.depth <= 0)
                {
                    throw new ArgumentException("Depth must be greater than 0!");
                }
                else
                {
                    return this.depth;
                }
            }
            set
            {
                this.depth = value;
            }

        }

        public Cube(double width, double height, double depth)
       {
           this.width = width;
           this.height = height;
           this. depth = depth;
       }

        public  double CalcVolume()
        {
            double volume = this.width * this.height * this.depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = UtilsCalculateDistance.CalcDistance3D(0, 0, 0, this.width, this.height, this.depth);
            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = UtilsCalculateDistance.CalcDistance2D(0, 0, this.width, this.height);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = UtilsCalculateDistance.CalcDistance2D(0, 0, this.width, this.depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = UtilsCalculateDistance.CalcDistance2D(0, 0, this.height, this.depth);
            return distance;
        }
    }
}
