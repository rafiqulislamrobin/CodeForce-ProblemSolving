using System;

namespace In_Search_of_an_Easy_Problem_1030A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool z = true;


            string[] input = Console.ReadLine().Split(" ");

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=="1")
                {
                    z = false;
                }
            }
            if (z == true)
            {
                Console.WriteLine("EASY");
            }
            else
            {
                Console.WriteLine("HARD");
            }
            
        }
    }
}
