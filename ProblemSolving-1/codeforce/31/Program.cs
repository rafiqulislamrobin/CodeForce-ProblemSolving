using System;

namespace _31
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string inputs = Console.ReadLine();
            string[] x = inputs.Split(" ");

            int Crime = 0;
            int Police = 0;
            

            for (var i = 0; i < x.Length; i++)
            {
                int input = int.Parse(x[i]);
                if (input > 0)
                {
                    Police += input;

                }
                else if (Police > 0)
                {
                    Police--;
                }
                else
                    Crime++;
               
            }
            Console.WriteLine(Crime);
        }
    }
}
