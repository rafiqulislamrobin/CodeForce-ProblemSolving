using System;
using System.Collections.Generic;
using System.Linq;

namespace Winner_Contest_2A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = 0;

            var dictionary = new Dictionary<string, int>();
            var datas = new List<string[]>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                datas.Add(input);

                string name = input[0];
                int numb = int.Parse(input[1]);
                if (dictionary.ContainsKey(name))
                {
                    dictionary[name] += numb;
                }
                else
                {
                    dictionary.Add(name, numb);
                }
            }
            m = dictionary.Select(e => e.Value).Max();



            var newDictionary = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] data = datas[i];
                string name = data[0];
                int numb = int.Parse(data[1]);

                if (newDictionary.ContainsKey(name))
                {
                    newDictionary[name] += numb;
                    if (newDictionary[name] >= m && dictionary[name] >= m)
                    {
                        Console.WriteLine(name);
                        Environment.Exit(0);
                    }
                }
                else
                {
                    newDictionary.Add(name, numb);
                    if (newDictionary[name] >= m && dictionary[name] >= m)
                    {
                        Console.WriteLine(name);
                        Environment.Exit(0);
                    }
                }
            }
        }

    }
}




