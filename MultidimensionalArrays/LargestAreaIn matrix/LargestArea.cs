using System;
using System.Linq;

class LargestArea
{
    static int counter = 1;
    
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
        Console.WriteLine(counter);

        PrintMatrix(matrix);
    }

    static void FindEquals(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (IsInMatrix(row + 1, col, matrix) && matrix[row, col] == matrix[row + 1, col])
                {
                    counter++;
                }
            }
        }
    }

    static bool IsInMatrix(int row, int col, int[,] matrix)
    {
        return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
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
