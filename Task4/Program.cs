using System;

class Program
{
    static void Main()
    {
        int boardSize = 8;
        int[] queensPositions = new int[boardSize];

        Random randomGenerator = new Random();

       
        for (int i = 0; i < boardSize; i++)
        {
            queensPositions[i] = randomGenerator.Next(boardSize);
        }

       
        while (!IsNonAttackingPlacement(queensPositions))
        {
            for (int i = 0; i < boardSize; i++)
            {
                queensPositions[i] = randomGenerator.Next(boardSize);
            }
        }

       
        Console.WriteLine("Randomly Placed Queens (0-based indexing):");
        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                if (queensPositions[i] == j)
                {
                    Console.Write("Q ");
                }
                else
                {
                    Console.Write(". ");
                }
            }
            Console.WriteLine();
        }
    }

    static bool IsNonAttackingPlacement(int[] queensPositions)
    {
        for (int i = 0; i < queensPositions.Length; i++)
        {
            for (int j = i + 1; j < queensPositions.Length; j++)
            {
                if (queensPositions[i] == queensPositions[j] || Math.Abs(queensPositions[i] - queensPositions[j]) == Math.Abs(i - j))
                {
                    return false; 
                }
            }
        }
        return true; 
    }
}