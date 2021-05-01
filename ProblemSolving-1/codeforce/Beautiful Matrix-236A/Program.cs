using System;

namespace Beautiful_Matrix_236A
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] x = new int[5][];
            int score = 0;
          
            for (int i = 0; i < 5; i++)
            {
                x[i] = new int[5];
                string[] input = Console.ReadLine().Split(" ");
                             
                for (int j = 0; j < 5; j++)
                {
                   
                    x[i][j] = int.Parse(input[j]);
                    if (x[i][j]==1)
                    {
                        score = Math.Abs(i - 2) + Math.Abs(j - 2);
                    }
                }
            }
            Console.WriteLine(score);

     

        }
    }
}
