using System;

namespace Problema11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N= ");
            int n = int.Parse(Console.ReadLine());
            int k,s,m,rev;
            s = 0;
            for(int i=0; i<n; i++)
            {
                rev = 0;
                k = int.Parse(Console.ReadLine());
                while(k!=0)
                {
                    m =k % 10;
                    rev = rev * 10 + m;
                    k = k / 10;
                    

                }
                
                s = s + rev;
            }
            Console.WriteLine(s);
        }
    }
}
