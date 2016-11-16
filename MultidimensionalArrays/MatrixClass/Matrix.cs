namespace MatrixClass
{
    using System;
    using System.Text;

    public class Matrix
    {
        private int[,] elements;
        private int rows;
        private int cols;

        public Matrix(int rowsCount, int colsCount)
        {
            this.RowsCount = rowsCount;
            this.ColsCount = colsCount;
            this.elements = new int[rowsCount, colsCount];
        }

        public int RowsCount
        {
            get
            {
                return this.rows;
            }
            set
            {
                this.rows = value;
            }
        }
        public int ColsCount
        {
            get
            {
                return this.cols;
            }
            set
            {
                this.cols = value;
            }
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.RowsCount != matrix2.RowsCount || matrix1.ColsCount != matrix2.ColsCount)
            {
                throw new InvalidOperationException("Cannot adding matrices with different dimensions");
            }

            Matrix result = new Matrix(matrix1.RowsCount, matrix1.ColsCount);
            for (int row = 0; row < matrix1.RowsCount; row++)
            {
                for (int col = 0; col < matrix1.ColsCount; col++)
                {
                    result[row, col] = matrix1[row, col] + matrix2[row, col];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.RowsCount != matrix2.RowsCount || matrix1.ColsCount != matrix2.ColsCount)
            {
                throw new InvalidOperationException("Cannot adding matrices with different dimensions");
            }

            Matrix result = new Matrix(matrix1.RowsCount, matrix1.ColsCount);
            for (int row = 0; row < matrix1.RowsCount; row++)
            {
                for (int col = 0; col < matrix1.ColsCount; col++)
                {
                    result[row, col] = matrix1[row, col] - matrix2[row, col];
                }
            }

            return result;
        }

       

        public int this[params int[] key]
        {
            get
            {
                return this.elements[key[0], key[1]];
            }
            set
            {
                this.elements[key[0], key[1]] = value;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            for (int row = 0; row < this.elements.GetLength(0); row++)
            {
                int[] currentRow = new int[this.elements.GetLength(1)];
                for (int col = 0; col < this.elements.GetLength(1); col++)
                {
                    currentRow[col] = this.elements[row, col];
                }
                output.Append(String.Join(" ", currentRow));
                output.Append(Environment.NewLine);
            }

            return output.ToString();
        }
    }
}
