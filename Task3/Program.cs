using System;
using System.Collections.Generic;

class Program {
   
    static int genRand(int n){
        Random rand = new Random();
        return rand.Next(n);
    }

    static void Main() {
        Console.WriteLine("Enter the position i");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position j");
        int j = int.Parse(Console.ReadLine());

        int[,] arr = new int[8, 8];
        List<int> elem = new List<int>();
        
        for (int row = 0; row < 8; row++) {
            for (int column = 0; column < 8; column++) {
                if ((Math.Abs((row + column) - (i + j)) == 3 || Math.Abs((row + column) - (i + j)) == 1) && row != i && column != j && Math.Abs(row - i) <= 2 && Math.Abs(column - j) <= 2) {
                    arr[row, column] = 1;
                    string numAsString = $"{row}{column}";
                    int numFromString = int.Parse(numAsString);
                    elem.Add(numFromString);
                }
                else if(row == i && column == j){
                    arr[row, column] = 2;
                }
                else{
                    arr[row, column] = 0;
                }
            }
        }

        for (int row = 0; row < 8; row++) {
            for (int column = 0; column < 8; column++) {
                Console.Write(arr[row, column] + " ");
            }
            Console.WriteLine();
        }

        int randomplaceStroke = genRand(elem.Count);
        Console.WriteLine($"horse has stoken from position {i}{j} to {elem[randomplaceStroke]} ");
    }
}