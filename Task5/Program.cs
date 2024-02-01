using System;

class Program
{
    static void Main()
    {
        
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        FindLargestInRowAndSmallestInColumn(matrix);
    }

    static void FindLargestInRowAndSmallestInColumn(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int maxInRow = matrix[i, 0];
            int colIndexOfMax = 0;

        
            for (int j = 1; j < cols; j++)
            {
                if (matrix[i, j] > maxInRow)
                {
                    maxInRow = matrix[i, j];
                    colIndexOfMax = j;
                }
            }

            
            bool isSmallestInColumn = true;
            for (int k = 0; k < rows; k++)
            {
                if (matrix[k, colIndexOfMax] < maxInRow)
                {
                    isSmallestInColumn = false;
                    break;
                }
            }

            
            if (isSmallestInColumn)
            {
                Console.WriteLine($"Element {maxInRow} at matrix[{i},{colIndexOfMax}] is the largest in its row and the smallest in its column.");
                return;
            }
        }

        
        Console.WriteLine("No such element exists.");
    }
}
