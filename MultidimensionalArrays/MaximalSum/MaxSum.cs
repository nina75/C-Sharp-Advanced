using System;
using System.Linq;

class MaxSum
{
    static void Main()
    {
        //Read the input
        string[] dimensionsParts = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(dimensionsParts[0]);
        int m = int.Parse(dimensionsParts[1]);
        int[,] matrix = new int[n, m];

        for (int row = 0; row < n; row++)
        {
            int[] currentRow = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = currentRow[col];
            }
        }

        //Find max sum
        int maxSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                    + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                    + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }

        //Print the result
        Console.WriteLine(maxSum);

        //Test
        //PrintMatrix(matrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        for (int row = 0; row < n; row++)
        {
            var currentRow = new int[m];
            for (int col = 0; col < m; col++)
            {
                currentRow[col] = matrix[row, col];
            }
            Console.WriteLine(String.Join(" ", currentRow));
        }
    }
}
