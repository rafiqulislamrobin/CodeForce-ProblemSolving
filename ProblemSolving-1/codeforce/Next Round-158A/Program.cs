using System;

namespace Next_Round_158A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            int n = int.Parse(input[0]);
            int k = Convert.ToInt32(input[1]);

            string[] input2 = Console.ReadLine().Split(" ");
            int count = 0;

            for (int i = 0; i < input2.Length; i++)
            {
                int a = int.Parse(input2[i]);
                if (int.Parse(input2[k-1]) <= a && a> 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
