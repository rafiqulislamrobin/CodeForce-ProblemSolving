using System;

namespace Anton_and_Polyhedrons_785A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                if (x== "Tetrahedron")
                {
                    count += 4;
                }
                else if (x== "Cube")
                {
                    count += 6;
                }
                else if (x== "Octahedron")
                {
                    count += 8;
                }
                else if (x== "Dodecahedron")
                {
                    count += 12;
                }
                else
                {
                    count += 20;
                }
            }
            Console.WriteLine(count);
            
        }
    }
}
