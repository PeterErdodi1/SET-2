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
            Console.WriteLine("N= ");
            int i, n,nr, t;
            t = 0;
            n = int.Parse(Console.ReadLine());

            StreamWriter secvente = new StreamWriter(@"..\..\Textfile1.txt");

            for (i = 0; i < n; i++)
            {
                nr = int.Parse(Console.ReadLine());
                secvente.WriteLine(nr);
            }
            secvente.Close();
            TextReader secvente1 = new StreamReader(@"..\..\Textfile1.txt");
            
            for (i = 0; i < n; i++)
            {
                nr = int.Parse(secvente1.ReadLine());
                if (i == nr)
                {
                    t++; ;
                }

            }
            Console.WriteLine(t);
        }
    }
}