using System;

namespace Methods
{
    public class Methods
    {
        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("All sides must be positive!");
            }
            else if (sideA+sideB < sideC || sideA + sideC < sideB || sideB + sideC < sideA)
            {
                throw new ArithmeticException("The sum of every two sides must be greater than the third one!");
            }

            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
            return area;
        }

        public static string NumberToDigit(int digit)
        {
            string digitToText;

            switch (digit)
            {
                case 0: digitToText = "zero"; break;
                case 1: digitToText = "one"; break;
                case 2: digitToText = "two"; break;
                case 3: digitToText = "three"; break;
                case 4: digitToText = "four"; break;
                case 5: digitToText = "five"; break;
                case 6: digitToText = "six"; break;
                case 7: digitToText = "seven"; break;
                case 8: digitToText = "eight"; break;
                case 9: digitToText = "nine"; break;
                default: throw new ArgumentException("Digit must be between 0 and 9!");
            }

            return digitToText;
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("No input entered!");
            }

            if (elements.Length == 1)
            {
                return elements[0];
            }

            int max = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        public static void FormatPrintNumber(double number, string format)
        {
            string toBePrint;

            if (format == "f")
            {
                toBePrint = String.Format("{0:f2}", number);
            }
            else if (format == "%")
            {
                toBePrint = String.Format("{0:p0}", number);
            }
            else if (format == "r")
            {
                toBePrint = String.Format("{0,8}", number);
            }
            else
            {
                throw new ArgumentException("Invalid format command!");
            }

            Console.WriteLine(toBePrint);
        }

        public static double CalculateDistance(double xPointOne,
                                               double yPointOne, 
                                               double xPointTwo, 
                                               double yPointTwo, 
                                               out bool isHorizontal,
                                               out bool isVertical)
        {
            isHorizontal = yPointOne == yPointTwo;
            isVertical = xPointOne == xPointTwo;

            double distance = Math.Sqrt(((xPointTwo - xPointOne) * (xPointTwo - xPointOne)) + ((yPointTwo - yPointOne) * (yPointTwo - yPointOne)));
            return distance;
        }

        public static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToDigit(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            
            FormatPrintNumber(1.3, "f");
            FormatPrintNumber(0.75, "%");
            FormatPrintNumber(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov"); 
            peter.OtherInfo = "From Sofia, born at 17.03.1992";
            Student stella = new Student("Stella", "Markova");
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
