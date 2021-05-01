using System;

namespace Games_268A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[n];
            string[] home = new string[n];
            string[] away = new string[n];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
               

                for (int j=0; j < n; j++)
                {
                    string[] temp = input[i].Split(" ");
                    home[i] = temp[0];
                    away[i] = temp[1];

                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (home[i]==away[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
