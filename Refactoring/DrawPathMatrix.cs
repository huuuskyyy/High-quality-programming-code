using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixPath
{
    public static class DrawPathMatrix
    {
        public static bool IsAnyAvailableNeighbourCell(int currentX, int currentY, Matrix matrix)
        {
            if (IsLefCellAvailable(currentX, currentY, matrix) || IsUpLeftDiagonalCellAvailable(currentX, currentY, matrix)
                || IsUplCellAvailable(currentX, currentY, matrix) || IsUpRightDiagonalCellAvailable(currentX, currentY, matrix)
                || IsRightCellAvailable(currentX, currentY, matrix) || IsDownRightDiagonalCellAvailable(currentX, currentY, matrix)
                || IsDownCellAvailable(currentX, currentY, matrix) || IsDownLeftDiagonalCellAvailable(currentX, currentY, matrix))
            {
                return true;
            }

            return false;
        }

        private static bool IsDownLeftDiagonalCellAvailable(int currentX, int currentY, Matrix matrix)
        {
            if ((currentX - 1) > -1 && (currentY + 1) < matrix.Columns && matrix[currentX - 1, currentY + 1].Equals(matrix.DefaultVisitCellValue))
            {
                return true;
            }

            return false;
        }

        private static bool IsDownCellAvailable(int currentX, int currentY, Matrix matrix)
        {
            if ((currentY + 1) < matrix.Columns && matrix[currentX, currentY + 1].Equals(matrix.DefaultVisitCellValue))
            {
                return true;
            }

            return false;
        }

        private static bool IsDownRightDiagonalCellAvailable(int currentX, int currentY, Matrix matrix)
        {
            if ((currentX + 1) < matrix.Rows && (currentY + 1) < matrix.Columns && matrix[currentX + 1, currentY + 1].Equals(matrix.DefaultVisitCellValue))
            {
                return true;
            }

            return false;
        }

        private static bool IsRightCellAvailable(int currentX, int currentY, Matrix matrix)
        {
            if ((currentX + 1) < matrix.Rows && matrix[currentX + 1, currentY].Equals(matrix.DefaultVisitCellValue))
            {
                return true;
            }

            return false;
        }

        private static bool IsUpRightDiagonalCellAvailable(int currentX, int currentY, Matrix matrix)
        {
            if ((currentX + 1) < matrix.Rows && (currentY - 1) > -1 && matrix[currentX + 1, currentY - 1].Equals(matrix.DefaultVisitCellValue))
            {
                return true;
            }

            return false;
        }

        private static bool IsUplCellAvailable(int currentX, int currentY, Matrix matrix)
        {
            if ((currentY - 1) > -1 && matrix[currentX, currentY - 1].Equals(matrix.DefaultVisitCellValue))
            {
                return true;
            }

            return false;
        }

        private static bool IsUpLeftDiagonalCellAvailable(int currentX, int currentY, Matrix matrix)
        {
            if ((currentX - 1) > -1 && (currentY - 1) > -1 && matrix[currentX - 1, currentY - 1].Equals(matrix.DefaultVisitCellValue))
            {
                return true;
            }

            return false;
        }

        private static bool IsLefCellAvailable(int currentX, int currentY, Matrix matrix)
        {
            if ((currentX - 1) > -1 && matrix[currentX - 1, currentY].Equals(matrix.DefaultVisitCellValue))
            {
                return true;
            }

            return false;
        }

        public static void ChangeDirection(ref int directionX, ref int directionY, ref string direction)
        {
            string[] directions = { "downRight", "right", "topRight", "top", "topLeft", "left", "downLeft", "down" };
            int index = Array.IndexOf(directions, direction);
            int nextDirectionPosition = index + 1;

            if (nextDirectionPosition == directions.Length)
            {
                nextDirectionPosition = 0;
            }

            direction = directions[nextDirectionPosition];

            switch (direction)
            {
                case "downRight": directionX = 1; directionY = 1; break;
                case "right": directionX = 1; directionY = 0; break;
                case "topRight": directionX = 1; directionY = -1; break;
                case "top": directionX = 0; directionY = -1; break;
                case "topLeft": directionX = -1; directionY = -1; break;
                case "left": directionX = -1; directionY = 0; break;
                case "downLeft": directionX = -1; directionY = 1; break;
                case "down": directionX = 0; directionY = 1; break;
            }
        }

        public static void FindNextAvailableCell(Matrix matrixToCheck, out int x, out int y)
        {
            x = 0;
            y = 0;

            for (int i = 0; i < matrixToCheck.Rows; i++)
            {

                for (int j = 0; j < matrixToCheck.Rows; j++)
                {
                    if (matrixToCheck[i, j] == 0)
                    {
                        x = i;
                        y = j;
                        return;
                    }
                }
            }
        }

        public static void FillMatrixValues(ref int currentX, ref int currentY, ref int currentNumberToFillInMatrix, ref Matrix matrix, ref int directionX, ref int directionY, ref string direction)
        {
            while (true)
            {
                matrix[currentX, currentY] = currentNumberToFillInMatrix;

                if (!DrawPathMatrix.IsAnyAvailableNeighbourCell(currentX, currentY, matrix))
                {

                    break;
                }

                while (IsCoordinateInMatrix(currentX, currentY, directionX, directionY, matrix))
                {
                    DrawPathMatrix.ChangeDirection(ref directionX, ref directionY, ref direction);
                }

                currentX += directionX;
                currentY += directionY;
                currentNumberToFillInMatrix++;
            }
        }

        private static bool IsCoordinateInMatrix(int currentX, int currentY, int stepX, int stepY, Matrix matrix)
        {
            if (currentX + stepX >= matrix.Rows)
            {
                return true;
            }
            else if (currentX + stepX < 0)
            {
                return true;
            }
            else if (currentY + stepY >= matrix.Columns)
            {
                return true;
            }
            else if (currentY + stepY < 0)
            {
                return true;
            }
            else if (matrix[currentX + stepX, currentY + stepY] != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
