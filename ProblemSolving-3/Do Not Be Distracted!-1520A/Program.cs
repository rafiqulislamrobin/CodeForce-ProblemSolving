using System;

namespace Do_Not_Be_Distracted__1520A
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong t = ulong.Parse(Console.ReadLine());

            while (t != 0)
            {
                int count = 0;
                ulong n = ulong.Parse(Console.ReadLine());
                string xText = Console.ReadLine();

                char[] x = xText.ToCharArray();
                if (x.Length <= 1)
                {
                    Console.WriteLine("YES");
                }

                else
                {


                    for (ulong i = 0; i < n - 1; i++)
                    {
                        if (x[i] == x[i + 1])
                        {
                            continue;
                        }
                        else
                        {
                            for (ulong j = i + 2; j < n; j++)
                            {
                                if (x[i] == x[j])
                                {
                                    count++;
                                    break;
                                }
                            }
                        }
                        if (count > 0)
                        {
                            break;
                        }
                     

                    }
                    if (count>0)
                    {
                        Console.WriteLine("NO");
                    }
                    else
                    {
                        Console.WriteLine("YES");
                    }

              
                }
                t--;
            }
        }
    }
}
