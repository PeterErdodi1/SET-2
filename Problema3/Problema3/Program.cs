using System;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N=   ");
            int i, n, s, p;
            s = 0;
            p = 1;
            n = int.Parse(Console.ReadLine());
            for(i=1; i<=n; i++)
            {
                s = s + i;
                p = p * i;

            }
            Console.WriteLine("Produs=   "+p);
            Console.WriteLine("Suma=   "+s);
        }
    }
}
