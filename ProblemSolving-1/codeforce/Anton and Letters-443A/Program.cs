using System;

namespace Anton_and_Letters_443A
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 0;

            char[] ch = input.ToCharArray();
            Array.Sort(ch);

            for (int i = 0; i < input.Length-1; i++)
            {
                if (ch[i]>=97 && ch[i]<=122)
                {
                    count++;
                    if (ch[i]==ch[i+1])
                    {
                        count--;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
