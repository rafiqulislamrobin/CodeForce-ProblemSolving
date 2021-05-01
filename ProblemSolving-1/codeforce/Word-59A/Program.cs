using System;

namespace Word_59A
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine() ;

            int upperCount = 0;
            int lowerCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    upperCount++;
                }
                else
                {
                    lowerCount++;
                }
            }
            if (lowerCount<upperCount)
            {
                input = input.ToUpper();
                Console.WriteLine(input);
            }
            else
            {
                input = input.ToLower();
                Console.WriteLine(input);
            }
        }
    }
}
