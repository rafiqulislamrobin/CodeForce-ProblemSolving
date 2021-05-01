using System;

namespace Elephant_617A
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input %5==0)
            {
                Console.WriteLine(input/5);

            }
            else
            {
                Console.WriteLine((input/5)+1);
            }
           
        }
    }
}
