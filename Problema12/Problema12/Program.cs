using System;

namespace Problema12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N= ");
            int n = int.Parse(Console.ReadLine());
            int a,count=0,b=0;
            bool ok=false;
            for(int i=0; i<n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a!=0)
                {
                    ok = true;
                }
                if(a==0)
                {
                    if(a==b)
                    {
                        ok = false;
                    }
                    if(ok)
                    {
                        count++;
                    }
                    
                }
                if(i==n-1)
                {
                    if(a!=0&&b==0)
                    {
                        count++;
                    }

                }
                b = a;
                
            }
            Console.WriteLine(count);
        }
    }
}
