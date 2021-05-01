using System;

namespace New_Year_and_Hurry_750A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            int highestTime = 240;
            int problemTime = 0;
            int count = 0;

            highestTime =highestTime-k;

            for (int i = 1; i <=n; i++)
            {
                
                if ((problemTime + i * 5)<=highestTime)
                {
                    problemTime = problemTime + i * 5;
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
