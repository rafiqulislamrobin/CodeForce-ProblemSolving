using System;

namespace Sum_of_Round_Numbers_1352A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int count = 0, ten = 1;
                int[] arr = new int[6];
                int x= int.Parse(Console.ReadLine());

                for (int j = 0; j < 6; j++)
                {
                    arr[j] = x % 10;
                    x = x / 10;
                    if (arr[j]!=0)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);

                for (int j = 0; j < 6; j++)
                {
                    if (arr[j]!=0)
                    {
                        Console.Write($"{arr[j]*ten} ");
                    }
                    ten = ten * 10;
                }
                Console.WriteLine();
            }
        }
    }
}
