using System;

namespace Taxi_158B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] xText = Console.ReadLine().Split(' ') ;
            int[] x = new int[n];

            int taxi , c1 = 0, c2 = 0, c3 = 0, c4 = 0;



            for (int i = 0; i < n; i++)
            {
                x[i] = int.Parse(xText[i]);

                if (x[i] == 1)
                {
                    c1++;
                }
                if (x[i] == 2)
                {
                    c2++;
                }
                if (x[i] == 3)
                {
                    c3++;
                }
                if (x[i] == 4)
                {
                    c4++;
                }
            }

            taxi = c4;
            
            //group 4 clear

            while (c1!=0 &&c3!=0)
            {
                c1 = c1 - 1;
                c3 = c3 - 1;
                taxi = taxi + 1;
            }
            if (c3!=0 && c1==0)
            {
                taxi = taxi + c3;
                c3 = 0;
            }
            //group 3 clear

            taxi = taxi + (c2 / 2);
            if (c2%2!=0)
            {
                if (c1<=2)
                {
                    taxi = taxi + 1;
                    c1 = 0;
                    c2 = 0;
                }
                else
                {
                    c1 = c1 - 2; 
                    taxi+=1;
                    c2 = 0;
                }
            }
            //group 2 clear


            if (c1 != 0)
            {
                taxi = taxi + (c1 / 4);
                if (c1 % 4 != 0)
                {
                    taxi += 1;
                }
            }
            //group 1 clear
            Console.WriteLine(taxi);

        }
    }
}
