using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixPath;
using System.Linq;

namespace MatrixPathTests
{
    //I'm sorry, but I don't have time at the moment to write unit test for every method and property
    //I'm just added some unit test to test if matrix is generated correctly at all and if finds correct 
    //available free cells nearby
    //Needs to check JS Exams
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void TestIfMatrixWithDimensionFiveIsDrewCorrectly()
        {
            
            int matrixDimensions = 5;
            Matrix matrix = new Matrix(matrixDimensions, matrixDimensions, 0);
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

            Matrix shouldBeResultMatrix = new Matrix(5, 5);
            int[,] pattern = new int[,] {{1,13,14,15,16},
                                          {12,2,21,22,17},
                                          {11,23,3,20,18},
                                          {10,25,24,4,19},
                                          {9,8,7,6,5}};

            for (int i = 0; i < pattern.GetLength(0); i++)
            {
                for (int j = 0; j < pattern.GetLength(1); j++)
                {
                    shouldBeResultMatrix[i, j] = pattern[i, j];
                }
            }

            Assert.AreEqual(true, CompareMatrix(matrix, shouldBeResultMatrix), string.Format("Expected result that the matrix with dimension 5 is equal to the generated matrix with dimension 5. Returned {0}", CompareMatrix(matrix, shouldBeResultMatrix)));
        }

        public static bool CompareMatrix(Matrix matrix1, Matrix matrix2)
        {
            for (int i = 0; i < matrix1.Rows; i++)
			{
                for (int j = 0; j < matrix1.Columns; j++)
			    {
			        if(matrix1[i,j] != matrix2[i,j])
                    {
                        return false;
                    }
			    }
			}

            return true;
        }

        [TestMethod]
        public void TestIfReturnsFalseWhenNoAvailableNeighbourCellAvailable()
        {
            Matrix matrix = new Matrix(5, 5,0);
            int[,] pattern = new int[,] {{1,13,14,15,16},
                                          {12,2,21,22,17},
                                          {11,23,3,20,18},
                                          {10,0,24,4,19},
                                          {9,8,7,6,5}};

            for (int i = 0; i < pattern.GetLength(0); i++)
            {
                for (int j = 0; j < pattern.GetLength(1); j++)
                {
                    matrix[i, j] = pattern[i, j];
                }
            }

            Assert.AreEqual(false, DrawPathMatrix.IsAnyAvailableNeighbourCell(1, 3, matrix), string.Format("Exptected result false as there's no available free neightbour cell. Returned {0}", DrawPathMatrix.IsAnyAvailableNeighbourCell(1, 3, matrix)));
        }
        
        [TestMethod]
        public void TestIfReturnsTrueWhenDownCellAvailableNeighbour()
        {
            Matrix matrix = new Matrix(5, 5, 0);
            int[,] pattern = new int[,] {{1,13,14,15,16},
                                          {12,2,21,22,17},
                                          {11,0,3,20,18},
                                          {10,0,24,4,19},
                                          {9,8,7,6,5}};

            for (int i = 0; i < pattern.GetLength(0); i++)
            {
                for (int j = 0; j < pattern.GetLength(1); j++)
                {
                    matrix[i, j] = pattern[i, j];
                }
            }

            Assert.AreEqual(true, DrawPathMatrix.IsAnyAvailableNeighbourCell(1, 2, matrix), string.Format("Exptected result true as down cell is available free neightbour cell. Returned {0}", DrawPathMatrix.IsAnyAvailableNeighbourCell(1, 2, matrix)));
        }

        [TestMethod]
        public void TestIfReturnsTrueWhenDownLeftCellAvailableNeighbour()
        {
            Matrix matrix = new Matrix(5, 5, 0);
            int[,] pattern = new int[,] {{1,13,14,15,16},
                                          {12,2,21,22,17},
                                          {11,0,3,20,18},
                                          {0,10,24,4,19},
                                          {9,8,7,6,5}};

            for (int i = 0; i < pattern.GetLength(0); i++)
            {
                for (int j = 0; j < pattern.GetLength(1); j++)
                {
                    matrix[i, j] = pattern[i, j];
                }
            }

            Assert.AreEqual(true, DrawPathMatrix.IsAnyAvailableNeighbourCell(1, 2, matrix), string.Format("Exptected result true as down left cell is available free neightbour cell. Returned {0}", DrawPathMatrix.IsAnyAvailableNeighbourCell(1, 2, matrix)));
        }

        [TestMethod]
        public void TestIfReturnsTrueWhenRigthCellAvailableNeighbour()
        {
            Matrix matrix = new Matrix(5, 5, 0);
            int[,] pattern = new int[,] {{1,13,14,15,16},
                                          {12,2,21,22,17},
                                          {11,0,0,20,18},
                                          {10,10,24,4,19},
                                          {9,8,7,6,5}};

            for (int i = 0; i < pattern.GetLength(0); i++)
            {
                for (int j = 0; j < pattern.GetLength(1); j++)
                {
                    matrix[i, j] = pattern[i, j];
                }
            }

            Assert.AreEqual(true, DrawPathMatrix.IsAnyAvailableNeighbourCell(1, 2, matrix), string.Format("Exptected result true as right cell is available free neightbour cell. Returned {0}", DrawPathMatrix.IsAnyAvailableNeighbourCell(1, 2, matrix)));
        }
    }
}
