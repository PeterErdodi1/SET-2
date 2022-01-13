using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, a, b;
            bool ok = true;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            for (i=1; i<n; i++)
            {
                b = int.Parse(Console.ReadLine());
                if(a>b)
                {
                    ok = false;
                }
                a = b;
            }
            if(!ok)
            {
                Console.WriteLine("Nu este crescator");
            }
            else
            {
                Console.WriteLine("Este crescator");
            }    
        }
    }
}