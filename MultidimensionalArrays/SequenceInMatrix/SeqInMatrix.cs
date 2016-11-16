using System;
using System.Linq;

class SeqInMatrix
{
    static void Main()
    {
        //Read the input
        string[] dimensions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(dimensions[0]);
        int m = int.Parse(dimensions[1]);
        var matrix = new string[n, m];

        for (int row = 0; row < n; row++)
        {
            string[] currentRow = Console.ReadLine().Split(' ');
            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = currentRow[col];
            }
        }

        int maxCount = 1;
        int count = 1;
        //check rows
        for (int row = 0; row < n; row++)
        {
            string[] currentRow = new string[m];
            for (int col = 0; col < m; col++)
            {
                currentRow[col] = matrix[row, col];
            }
            int currentRowCount = FindMaxSeqInArray(currentRow);
            if (currentRowCount > maxCount)
            {
                maxCount = currentRowCount;
            }


        }

        //check cols
        for (int col = 0; col < m; col++)
        {
            string[] currentCol = new string[n];
            for (int row = 0; row < n; row++)
            {
                currentCol[row] = matrix[row, col];
            }
            int currentColCount = FindMaxSeqInArray(currentCol);
            if (currentColCount > maxCount)
            {
                maxCount = currentColCount;
            }


        }
       
        //scan right diagonals
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                count = 1;
                for (int i = row, j = col; i < matrix.GetLength(0) - 1 && j < matrix.GetLength(1) - 1; i++, j++)
                {
                    if (matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }

                //scan left diagonals
                for (int i = row, j = col; i < matrix.GetLength(0) - 1 && j > 0; i++, j--)
                {
                    if (matrix[i, j] == matrix[i + 1, j - 1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
            }
        }

                


        Console.WriteLine(maxCount);
        //PrintMatrix(matrix);
    }

    static int FindMaxSeqInArray(string[] arr)
    {
        int maxCount = 1;
        int currentCount = 1;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                currentCount++;
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            else
            {
                currentCount = 1;
            }
        }

        return maxCount;
    }

    static void PrintMatrix(string[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        for (int row = 0; row < n; row++)
        {
            var currentRow = new string[m];
            for (int col = 0; col < m; col++)
            {
                currentRow[col] = matrix[row, col];
            }
            Console.WriteLine(String.Join(" ", currentRow));
        }
    }
}
