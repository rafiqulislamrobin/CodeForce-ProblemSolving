using System;

namespace Tram_116A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int remaining = 0;
            int count=0;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                int passengerOut = int.Parse(input[0]);
                int passengerEnter = int.Parse(input[1]);
                

                remaining += (passengerEnter - passengerOut);
                for (int j = 0; j < remaining; j++)
                {
                    if (remaining>count)
                    {
                        count++;
                    }
                    
                }
            }
            Console.WriteLine(count);
        }
     
    }
}
