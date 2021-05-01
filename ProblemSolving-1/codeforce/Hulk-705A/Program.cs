using System;

namespace Hulk_705A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

        
            for (int i = 1; i <=n; i++)
            {
               
                if (i % 2 != 0)
                {

                    if (i==n)
                    {
                        Console.Write("I hate it");
                    }
                    else
                    {
                        Console.Write("I hate that ");
                    }
                   
                }
                else
                {
                    if (i==n)
                    {
                        Console.Write("I love it");
                    }
                    else
                    {
                        Console.Write("I love that ");
                    }
                    
                }
                
               
              
            }
        }
    }
}
