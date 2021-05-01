using System;

namespace Chat_room_58A
{
    class Program
    {
        static void Main(string[] args)
        {
            string z = "hello";

            char[] ch = z.ToCharArray();

            int x = 0;

            string input = Console.ReadLine();
            char[] inp = input.ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (x<5)
                {
                    if (ch[x] == inp[i])
                    {
                        x += 1;
                    } 
                }
            }
            if (x==5)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
