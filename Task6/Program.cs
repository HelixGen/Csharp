using System;


class Program {

    static int RandomGen(int from, int to) {
        Random rand = new Random();
        return rand.Next(from, to);
    }

    static void Main() {
        Console.WriteLine("Enter the number of rows i:");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of columns j:");
        int j = int.Parse(Console.ReadLine());

        int[,] arr = new int[i, j];
        List<int> elem = new List<int>();

        for (int row = 0; row < i; row++) {
            for (int column = 0; column < j; column++) {
                if (row == 0 && column == 0) {
                    arr[row, column] = RandomGen(0, 100);
                    elem.Add(arr[row, column]);
                    continue;
                }

                arr[row, column] = RandomGen(0, 100);
                while (elem.Contains(arr[row, column])) {
                    arr[row, column] = RandomGen(0, 100);
                }

                elem.Add(arr[row, column]);
            }
        }

      
        Console.WriteLine("Generated 2D array:");
        for (int row = 0; row < i; row++) {
            for (int column = 0; column < j; column++) {
                Console.Write(arr[row, column] + " ");
            }
            Console.WriteLine();
        }
    }
}