using System;

namespace Helpful_Maths_339A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("+");

            char[] z = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                z[i] =Convert.ToChar( input[i]);
            }
            Array.Sort(z);
            string x = "";
            for (int i = 0; i < input.Length; i++)
            {
                x += z[i];
                if (i < input.Length - 1)
                {
                    x += "+";
                }
            }
            Console.WriteLine(x);
        }
    }
}
