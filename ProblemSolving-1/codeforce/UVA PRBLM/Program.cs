using System;

namespace UVA_PRBLM
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int a = 0;
            int d = 0;

            char[] cha = input.ToCharArray();

            for (int i = 0; i < n; i++)
            {
                if (cha[i]=='A')
                {
                    a++;
                }
                else
                {
                    d++;
                }
            }
            if (a > d) 
            {
                Console.WriteLine("Anton");
            }
            else if (d>a)
            {
                Console.WriteLine("Danik");
            }
            else
            {
                Console.WriteLine("Friendship");
            }


        }
    }
}
