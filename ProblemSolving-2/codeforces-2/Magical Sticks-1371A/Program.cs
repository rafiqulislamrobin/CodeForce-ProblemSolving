using System;

namespace Magical_Sticks_1371A
{
    class Program
    {
        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());
            while (t != 0)
            {
                int n = int.Parse(Console.ReadLine());

                int stick = n;
         
                    if (stick % 2 == 0)
                    {
                        Console.WriteLine(stick/2);
                    }
                    else
                    {
                        Console.WriteLine((stick/2)+1);
                    }
                
                t--;
            }
        }
    }
}
