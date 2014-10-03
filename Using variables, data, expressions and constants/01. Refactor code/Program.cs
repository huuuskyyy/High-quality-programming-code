namespace RefactorCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Size
    {
        private double width, height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Size GetRotatedSize(Size size, double rotatedFigureAngle)
        {
            double newSizeWidthCos =  Math.Abs(Math.Cos(rotatedFigureAngle)) * size.width;
            double newSizeWidthSin =  Math.Abs(Math.Sin(rotatedFigureAngle)) * size.height;
            double newSizeHeightCos = Math.Abs(Math.Sin(rotatedFigureAngle)) * size.width;
            double newSizeHeightSin = Math.Abs(Math.Cos(rotatedFigureAngle)) * size.height;

            double newWidth = newSizeWidthCos + newSizeWidthSin;
            double newHeight = newSizeHeightCos + newSizeHeightSin;

            Size newSize = new Size(newWidth, newHeight);

            return newSize;
        }
    }
}
