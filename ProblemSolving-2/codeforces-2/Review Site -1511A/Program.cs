using System;

namespace Review_Site__1511A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse (Console.ReadLine());           
            for (int i = 0; i < n; i++)
            {
                int upVote = 0;
                int a = int.Parse(Console.ReadLine());
                string[] input = Console.ReadLine().Split(" ");

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == "1" || input[j] == "3")
                    {
                        upVote += 1;
                    }                   
                }                Console.WriteLine(upVote);
            }
        }
    }
}
