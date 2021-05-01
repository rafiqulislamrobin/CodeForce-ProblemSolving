using System;

namespace Amusing_Joke_141A
{
    class Program
    {
        static void Main(string[] args)
        {
            string guest = Console.ReadLine();
            string host = Console.ReadLine();
            string door = Console.ReadLine();

            guest += host;

            char[] g = guest.ToCharArray();
            char[] d = door.ToCharArray();

            Array.Sort(g); Array.Sort(d);

            string newGuest = new string(g);
            string newDoor = new string(d);

            if (string.Compare(newGuest, newDoor)==0)
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
