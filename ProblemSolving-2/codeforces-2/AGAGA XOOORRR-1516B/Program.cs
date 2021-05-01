using System;

namespace AGAGA_XOOORRR_1516B
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //int t = int.Parse(Console.ReadLine());

            //while (t != 0)
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    int sum = 0;

            //    string[] input2 = Console.ReadLine().Split(" ");
            //    int[] w = new int[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //        w[i] = int.Parse(input2[i]);
            //        sum = sum ^ w[i];
            //    }
            //    if (!sum)
            //    {

            //    }


            //t--;




            //}


            //Console.WriteLine(@"     /|");
            //Console.WriteLine(@"    / |");
            //Console.WriteLine(@"   /  |");
            //Console.WriteLine(@"  /   |"); 
            //Console.WriteLine(@" /    |");
            //Console.WriteLine(@"/_____|");
            int k = 0;
          
            for (int j = 0; j  < 6; j ++)
            {
                for (int i = k; i < 6; i++)
                {
                    Console.Write(" ");
                }
                
               
                
                    Console.Write("/");
                if (k<5)
                {
                    for (int i = 0; i < k; i++)
                    {
                        Console.Write(" ");
                    } 
                }
               else
                {
                    Console.Write("_____");
                }
                Console.WriteLine("|");
              

                k++;
            }
           
            
        }
    }
}
