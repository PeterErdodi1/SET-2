using System;

namespace Problema17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n= ");
            int n = int.Parse(Console.ReadLine());
            int k, o, t;
            bool ok = false;
            o = t = 0;
            for(int i=0; i<n; i++)
            {
                k = int.Parse(Console.ReadLine());
                if(i==0&&k==1)
                {
                    ok = true; ;
                    break;
                }
                if (k==1)
                {
                    o++;
                }
                if(k==0)
                {
                    t++;
                }
                if(k!=1)
                {
                    if (k != 0)
                    {
                        Console.WriteLine("Error, invalid numbers");
                        break;
                    }
                }
                if(i==(n-1)&&k==0)
                {
                    ok = true;
                }
            }
            if((!ok)&&o==t)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Nu este correct");
            }
        }
    }
}
