using System;

namespace Team_231A
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int count1 = 0;
            
            for (int i = 0; i <input; i++)
            {
                int count2 = 0;
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j]=="1")
                    {
                        count2++;
                    }
                }
                if (count2>=2)
                {
                    count1++;
                }
            }
            Console.WriteLine(count1);
        }
    }
}
