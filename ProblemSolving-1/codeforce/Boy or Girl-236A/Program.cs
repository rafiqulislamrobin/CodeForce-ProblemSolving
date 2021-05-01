using System;

namespace Boy_or_Girl_236A
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] z = input.ToCharArray();
            Array.Sort(z);
            int count = z.Length;

            for (int i = 0; i < input.Length; i++)
            {
                if (input.Length-1>i)
                {
                    if (z[i]==z[i+1])
                    {
                        count--;
                    }
                }
            }
            if (count%2!=0)
            {
                Console.WriteLine("IGNORE HIM!");
            }
            else
            {
                Console.WriteLine("CHAT WITH HER!");
            }
        }
    }
}
