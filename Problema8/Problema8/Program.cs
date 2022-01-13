using System;

namespace Problema8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N= ");
            int n;
            n = int.Parse(Console.ReadLine());
            int f1, f2, f3;
            f1 = 0;
            f2 = 1;
            f3 = 1;
            for(int i=2; i<=n; i++)
            {
                f3=f1+f2;
                f1 = f2;
                f2 = f3;

            }
            Console.WriteLine(f3);
        }
    }
}
