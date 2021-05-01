using System;

namespace _37
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splits = input.Split(" ");

            long distress = 0;

            long n = long.Parse (splits[0]);
            long x = long.Parse(splits[1]);

            for (var i =0;i<n; i++)
            {
                
                string ice = Console.ReadLine();
                string[] iceSplit = ice.Split(" ");

                long y = long.Parse(iceSplit[1]);
                char z = Convert.ToChar(iceSplit[0]);

                if (z == '+')
                {
                    if (x + y > 0)
                    {
                        x = x + y;
                    }
                    else if (x + y == 0)
                    {
                        x = x + y;
                    }
                    else
                        distress++;
                    
                }
                else
                {
                    if (x - y > 0)
                    {
                        x = x - y;
                    }
                    else if(x - y == 0)
                    {
                        x = x - y;
                    }
                    else
                        distress++;
                }
            }
            Console.WriteLine($"{x} {distress}");
               

        }
    }
}
