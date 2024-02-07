using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers
{
    public class Program
    {
        void checkPrime(int x)
        {
            int c = 0;
            for(int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    c++;
                }
            }
            if (c == 2)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.Write("Not a prime number");
            }
        }
        void RangePrime(int x,int y)
        {
            int c1=0;
            for(int i = x; i <= y; i++)
            {
                int c = 0;
                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
                if (c == 2)
                {   
                    c1++;
                    if (c1 != 1)
                    {
                        Console.Write(",");
                    }
                    Console.Write(i);
                }
            }
            Console.Write(".");
            Console.WriteLine();
        }
        void numberOfPrime(int x)
        {
            int c1 = 0;
            for (int i = 1; ; i++)
            {
                int c = 0;
                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
                if (c == 2)
                {
                    c1++;
                    Console.Write(i+" ");
                    if (c1 == x)
                    {
                        break;
                    }
                }
            }
        }
        void nearPrime(int x)
        {
            
            int lar = 0;
            int be = 0;
            for(int i=x+1; ; i++)
            {
                int c1 = 0;
                for(int j = 1; j <= i; j++)
                {
                    if(i%j == 0)
                    {
                        c1++;
                    }
                }
                if (c1 == 2)
                {
                    lar = i;
                    break;
                }
            }
            for(int i = x-1; i > 0; i--)
            {
                int c1 = 0;
                for(int j=1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        c1++;
                    }
                }
                if(c1 == 2)
                {
                    be = i;
                    break;
                }
            }
            int a = lar - x;
            int b = x - be;
            if (a == b)
            {
                Console.WriteLine($"{be} and {lar} are near Prime numbers");
            }
            else if(a>b )
            {
                Console.Write($"{be} is near Prime Number To {x}  .");
            }
            else
            {
                Console.Write($"{lar} is Near Prime number to {x} .");
            }
        }
        void primePalindrome(int x)
        {
            for(int i=1;i<=x; i++)
            {
                int c = 0;
                int pal = i;
                int rev = 0;
                for(int j=1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
                if (c == 2)
                {
                    //Console.WriteLine(i);;
                    int temp = i;
                    while (temp > 0)
                    {
                        int n = temp % 10;
                        rev = rev * 10 + n;
                        temp = temp / 10;
                    }
                    if (rev == pal)
                    {
                        Console.WriteLine(pal);
                    }
                }
            }

        }
        void Primefib(int x,int y)
        {
            int a = 0, b = 1;
            while (a<=y)
            {
                if (a>=x)
                {
                    //Console.WriteLine(a);
                    int c1 = 0;
                    for (int i = 1; i <= a; i++)
                    {

                        if (a % i == 0)
                        {
                            c1++;
                        }
                    }
                    if (c1 == 2)
                    {
                        Console.WriteLine(a);
                    }
                }
                int c = a + b;
                a = b;
                b = c;
            }
        }
        static void Main(string[] args)
        {
            Program x=new Program();
            //x.checkPrime(int.Parse(Console.ReadLine()));
            //x.RangePrime(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            //x.numberOfPrime(int.Parse(Console.ReadLine()));
            //x.nearPrime(int.Parse(Console.ReadLine()));
            //x.primePalindrome(int.Parse(Console.ReadLine()));
            //x.Primefib(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }
    }
}
