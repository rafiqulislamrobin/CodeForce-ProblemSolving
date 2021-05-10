using System;

namespace Soft_Drinking_151A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x= Console.ReadLine().Split(' ');



            int n = int.Parse(x[0]);
            int k = int.Parse(x[1]);
            int l = int.Parse(x[2]);
            int c= int.Parse(x[3]);
            int d = int.Parse(x[4]);
            int p = int.Parse(x[5]);
            int nl = int.Parse(x[6]);
            int np = int.Parse(x[7]);


            int nlToast = (k * l) / nl ;
            int lemonSlice = c*d;
            int salt = p/np;


         
            
            
                int min1 = Math.Min(lemonSlice, salt);
                int min2 = Math.Min(nlToast, min1);
            
            

            Console.WriteLine(min2/n);
        }
    }
}
