using System;

class Program {
   
    static void Main() {
        Console.WriteLine("Enter the position i");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position j");
        int j = int.Parse(Console.ReadLine());

        int[,] arr = new int[8, 8];

        for (int row = 0; row < 8; row++) {
            for (int column = 0; column < 8; column++) {
               if(row == i && column == j){
                      arr[row,column]=2;
               }
             
             else if((column==j)||(row==i)||(Math.Abs(row-i)==Math.Abs(column-j))&&(row!=i)&&(column!=j)){
                   arr[row,column]=1;

             }

          else{
               arr[row,column]=0;


          }


        
        }

        
        }
       for (int row = 0; row < 8; row++) {
            for (int column = 0; column < 8; column++) {
                Console.Write(arr[row, column] + " ");
            }
            Console.WriteLine();
        }

    }
}
