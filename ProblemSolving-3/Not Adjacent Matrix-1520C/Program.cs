using System;

namespace Not_Adjacent_Matrix_1520C
{
    class Program
    {
        static void Main(string[] args)
        {
            int t= int.Parse(Console.ReadLine());

            while (t!=0)
            {


                int n = int.Parse(Console.ReadLine());


                if (n == 1)
                {
                    Console.WriteLine("1");
                }
                else if (n == 2)
                {
                    Console.WriteLine("-1");
                }
                else
                {
                    int x = n * n;
                    int l = 1;
                    int k = 0;
                    if (x % 2 == 0)
                        x--;

                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            int p = 2 * k + 1;
                            if (p<=x)
                            {
                                Console.Write($"{p} ");
                                k++;
                            }
                            else
                            {
                                Console.Write($"{2*l} ");
                                l++;

                            }
                        }
                        Console.WriteLine();
                    }





                }

                t--;

            }
        }
    }
}
