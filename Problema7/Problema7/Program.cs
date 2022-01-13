using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Problema7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N= ");
            int n, nr, max, min, i;
            max = 0;
            n = int.Parse(Console.ReadLine());
            StreamWriter write = new StreamWriter(@"..\..\Textfile1.txt");
            for (i=1; i<=n; i++)
            {
                nr = int.Parse(Console.ReadLine());
                max = nr;
                write.WriteLine(nr);
                
            }
            write.Close();
            min = max;
            TextReader read = new StreamReader(@"..\..\Textfile1.txt");
            for (i = 1; i <= n; i++)
            {
                nr = int.Parse(read.ReadLine());
                if(nr<min)
                {
                    min = nr;
                }
                if(nr>max)
                {
                    max = nr;
                }
            }
            read.Close();
            Console.WriteLine(max);
            Console.WriteLine(min);
        }  
    }
}
