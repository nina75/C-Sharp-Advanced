using System;

class FillMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string letter = Console.ReadLine();
        switch (letter)
        {
            case "a":
                PrintMatrixA(n);
                break;
            case "b":
                PrintMatrixB(n);
                break;
            case "c":
                PrintMatrixC(n);
                break;
            case "d":
                break;
        }
    }

    static void PrintMatrixA(int len)
    {
        int[,] matrix = new int[len, len];
        int counter = 0;
        for (int col = 0; col < len; col++)
        {
            for (int row = 0; row < len; row++)
            {
                matrix[row, col] = ++counter;
            }
        }
        PrintMatrix(matrix);
    }

    static void PrintMatrixB(int len)
    {
        int[,] matrix = new int[len, len];
        int counter = 0;
        for (int col = 0; col < len; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < len; row++)
                {
                    matrix[row, col] = ++counter;
                }
            }
            else
            {
                for (int row = len - 1; row >= 0; row--)
                {
                    matrix[row, col] = ++counter;
                }
            }

        }
        PrintMatrix(matrix);
    }

    static void PrintMatrixC(int len)
    {
        int[,] matrix = new int[len, len];
        int counter = 0;
        int diagonalElements = 1;
        int row = len - 1;
        int col = 0;

        while (diagonalElements <= len)
        {
            for (int i = 0; i < diagonalElements; i++)
            {
                matrix[row, col] = ++counter;
                row++;
                col++;
            }
            row -= diagonalElements;
            col -= diagonalElements;
            diagonalElements++;
            row--;
        }
        diagonalElements -= 2;
        row = 0;
        col = 1;
        while (diagonalElements > 0)
        {
            for (int i = 0; i < diagonalElements; i++)
            {
                matrix[row, col] = ++counter;
                row++;
                col++;
            }
            row -= diagonalElements;
            col -= diagonalElements;
            diagonalElements--;
            col++;
        }
        PrintMatrix(matrix);
    }
    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int[] row = new int[matrix.GetLength(1)];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                row[j] = matrix[i, j];
            }
            Console.WriteLine(String.Join(" ", row));
        }
    }

}
