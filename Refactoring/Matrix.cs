using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixPath
{
    public class Matrix
    {
        private int rows;
        private int columns;
        private int[,] matrix;
        private int defaultVisitCellValue;

        public int Rows
        {
            get
            {
                return this.rows;
            }
            set
            {
                if (value < 2)
                {
                    throw new ArgumentOutOfRangeException("You must enter at least 2 rows to form a matrix");

                }

                this.rows = value;
            }
        }

        public int Columns
        {
            get
            {
                return this.columns;
            }
            set
            {
                if (value < 2)
                {
                    throw new ArgumentOutOfRangeException("You must enter at least 2 columns to form a matrix");

                }

                this.columns = value;
            }
        }

        public int DefaultVisitCellValue
        {
            get
            {
                return this.defaultVisitCellValue;
            }
            set
            {
                this.defaultVisitCellValue = value;
            }
        }

        public int this[int x, int y]
        {
            get
            {
                return matrix[x, y];
            }
            set
            {
                matrix[x, y] = value;
            }
        }

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            this.matrix = new int[rows, columns];
        }

        public Matrix(int rows, int columns, int defaultVisitCellValue)
        {
            this.rows = rows;
            this.columns = columns;
            this.defaultVisitCellValue = defaultVisitCellValue;
            this.matrix = new int[rows, columns];
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int currRow = 0; currRow < rows; currRow++)
            {
                for (int currCol = 0; currCol < columns; currCol++)
                {
                    builder.Append(string.Format("{0,3}", matrix[currRow, currCol]));
                }

                builder.AppendLine();
            }

            return builder.ToString();
        }
    }
}
