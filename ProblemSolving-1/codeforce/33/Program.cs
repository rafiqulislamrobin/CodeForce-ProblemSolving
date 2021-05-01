using System;

namespace _33
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] x = new string[n];

            int count = 0;
            int count2 = 0;
            for(var i=0; i < x.Length; i++)
            {
                x[i] = Console.ReadLine();
                string[] splits = x[i].Split('|');

                for (var j =0; j < splits.Length; j++)
                {
                    if (splits[j] == "OO")
                    {

                        count++;
                        splits[j] = "++";
                       
                    }
                }
            }
            if(count > 0)
            {
                Console.WriteLine("YES");
                for (var i = 0; i < x.Length; i++)
                {
                    string[] splits = x[i].Split('|');
                    for (var j = 0; j < splits.Length; j++)
                    {
                        if (count2 < 1)
                        {
                            if (splits[j] == "OO")
                            {


                                splits[j] = "++";

                                count2++;

                            }
                        }
                        if (j ==0)
                        {
                            Console.Write($"{splits[j]}|");
                        }
                        else
                            Console.Write(splits[j]);
                        
                      

                    }
                    Console.WriteLine();
                   
                }
            }
            else
                Console.WriteLine("NO");
        }
    }
}
