using System;

namespace Mishka_and_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int count = 0;
            int count2 = 0;
            for (int i = 0; i <t; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                int m = int.Parse(input[0]);
                int c = int.Parse(input[1]);

                if (m>c)
                {
                    count++;
                }
                else if(m<c)
                {
                    count2++;
                }
                
            }
            if (count >count2)
            {
                Console.WriteLine("Mishka");
            }
            else if (count<count2)
            {
                Console.WriteLine("Chris");
            }
            else
            {
                Console.WriteLine("Friendship is magic!^^");
            }
        }
    }
}
