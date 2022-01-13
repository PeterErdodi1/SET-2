using System;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=  ");
            int i, n, nr, p, ne, z;
            p = z = ne = 0;
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr == 0)
                {
                    z++;
                }
                else if (nr > 0)
                {
                    p++;
                }
                else if (nr < 0)
                {
                    ne++;
                }

            }
            Console.WriteLine("Pozitiv =" + p);
            Console.WriteLine("Negativ =" + ne);
            Console.WriteLine("Zero =" + z);
        }
    }
}
