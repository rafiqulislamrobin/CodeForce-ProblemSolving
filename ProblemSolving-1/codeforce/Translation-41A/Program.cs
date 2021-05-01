using System;

namespace Translation_41A
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();

            t =Reverse(t);
           
            if (s==t)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
        public static string Reverse(string t)
        {
            char[] charArray = t.ToCharArray();
            Array.Reverse(charArray);
            return new string (charArray);
        }
    }
}
