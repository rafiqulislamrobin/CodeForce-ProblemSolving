using System;

namespace _30
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputs = Console.ReadLine();

            string[] inputSplits = inputs.Split(" ");

            int r = int.Parse(inputSplits[0]);
            int c = int.Parse(inputSplits[1]);

            for (var i = 1; i <= r; i++)
            {
                for(var j = 1; j <= c; j++)
                {
                    if (i % 2 != 0)
                    {
                       
                        Console.Write("#");
                    }
                    else
                    {
                        var temp = i/2;

                        if (temp % 2 != 0)
                        {

                            if (j == c)
                                Console.Write("#");
                            else
                                Console.Write(".");
                        }
                        else
                       
                        {

                            if (j == 1)
                                Console.Write("#");
                            else
                                Console.Write(".");
                        }


                    }


                }
                Console.WriteLine();
            }
        }
    }
}
