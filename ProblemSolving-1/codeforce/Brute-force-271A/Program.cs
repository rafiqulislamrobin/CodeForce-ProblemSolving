using System;

namespace Brute_force_271A
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int y = 1 + int.Parse((input));
            input = y.ToString();

            char[] c = input.ToCharArray();
            bool z = true;

            do
            {
                if (c[0] == c[1] || c[0] == c[2] || c[0] == c[3] ||
                   c[1] == c[2] || c[1] == c[3] ||
                   c[2] == c[3])
                {
                     y = int.Parse(input);
                    y = y + 1;
                    input = y.ToString();
                    c = input.ToCharArray();
                    

                }
                else
                {
                    z = false;
                }
            } while (z == true);
            Console.WriteLine(y);

        }
    }
}
