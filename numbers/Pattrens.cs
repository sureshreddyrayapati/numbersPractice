using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers
{
    public class Pattrens
    {
        void LTriange(int x)
        {
            for(int i=1; i<=x; i++)
            {
                for(int j=1; j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        void ULTrinage(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <=x-i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        void DRTringe(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j<=x-i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        void URTringe(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= x - i ; j++)
                {
                    Console.Write(" ");
                }
                for(int j=1; j <= i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        void Triange(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || j == x)
                    {
                        Console.Write("*");
                    }
                    else if (i == 1 || i == x)
                    {
                        Console.Write("*");
                    }
                    else if (i == j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            Pattrens x = new Pattrens();
            //x.LTriange(5);
            //x.ULTrinage(5);
            //x.DRTringe(5);
            //x.URTringe(5);
            x.Triange(10);
            
        }
    }
}
