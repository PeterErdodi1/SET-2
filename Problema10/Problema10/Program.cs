using System;

namespace Problema10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N= ");
            int n,a,b,max,maxcount,c;

            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            b = a;
            c = a;
            maxcount = 0;
            max = 0;
            for(int i=1; i<n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (b==a)
                {
                    maxcount++;
                }
                else if(c==b)
                {
                    maxcount++;
                    if(max<maxcount)
                    {
                        max = maxcount;
                    }
                    maxcount = 0;
                }
                if(i==n-1)
                {
                    if(c==a)
                    {
                        maxcount++;
                        if(max<maxcount)
                        {
                            max = maxcount;
                        }    
                    }
                }
                c = b;
                b = a;
                
            }
            Console.WriteLine(max);
        }
    }
}
