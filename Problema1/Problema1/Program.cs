using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n =");
            int n, i,k,nr;
            n = int.Parse(Console.ReadLine());
            k = 0;
            for(i=1; i<=n; i++)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr % 2 == 0)
                {
                    k++;
                }
            }
            Console.WriteLine("numere pare >"+k);
        }
    }
}
