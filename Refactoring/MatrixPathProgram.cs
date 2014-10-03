using System;

namespace MatrixPath
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter matrix dimensions");
            int matrixDimensions = int.Parse(Console.ReadLine());
            Matrix matrix = new Matrix(matrixDimensions, matrixDimensions,0);
            int currentNumberToFillInMatrix = 1;
            int currentX = 0;
            int currentY = 0;
            int directionX = 1;
            int directionY = 1;
            string direction = "downRight";

            DrawPathMatrix.FillMatrixValues(ref currentX, ref currentY, ref currentNumberToFillInMatrix,
                                            ref matrix, ref directionX, ref directionY, ref direction);

            DrawPathMatrix.FindNextAvailableCell(matrix, out currentX, out currentY);
            directionX = 1; directionY = 1;
            currentNumberToFillInMatrix++;

            DrawPathMatrix.FillMatrixValues(ref currentX, ref currentY, ref currentNumberToFillInMatrix, 
                                            ref matrix, ref directionX, ref directionY, ref direction);    
            
            Console.WriteLine(matrix.ToString());
        }
    }
}
