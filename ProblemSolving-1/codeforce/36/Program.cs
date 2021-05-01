using System;

namespace _36
{
    class Program
    {
        static void Main(string[] args)
        {
            string cups = Console.ReadLine();
            string[] cupsSplits = cups.Split(" ");
            int a = int.Parse(cupsSplits[0]);
            int b = int.Parse(cupsSplits[1]);
            int c = int.Parse(cupsSplits[2]);


            string medals = Console.ReadLine();
            string[] medalsSplits = medals.Split(" ");
            int x = int.Parse(medalsSplits[0]);
            int y = int.Parse(medalsSplits[1]);
            int z = int.Parse(medalsSplits[2]);

            int n = int.Parse(Console.ReadLine());

            if ((((a + b + c + 4) / 5) + (x + y + z + 9) / 10) > n)
            {
                Console.WriteLine("NO");
            }
            else
                Console.WriteLine("YES");
        }
    }
