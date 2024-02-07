using System;
namespace numbers
{
    public class Fibonacci
    {
        void Feb(int x)
        {
            int a=0,b=1;
            while (a <= x)
            {
                Console.Write(a+" ");
                int c = a + b;
                a=b; b=c;
            }
            Console.WriteLine();
        }
        void NumberOfFib(int x)
        {
            int a =0;int b = 1,c1=0;
            for(int i=1;true; i++)
            {
                c1++;
                Console.Write(a + " ");
                if (c1 == x)
                {
                    break;
                }
                int c = a + b;
                a=b; b=c;
            }
            Console.WriteLine();
        }
        void RangeFib(int x,int y)
        {
            int a = 0, b = 1;
            while (a <= y)
            {
                if (a >= x)
                {
                    Console.Write(a+"  ");
                }
                int c = a + b;
                a = b;
                b = c;
            }
        }
        void checkNumber_IsFibnacci(int x)
        {
            int a = 0, b = 1,c1=0;
           for(int i = 0; i <= x; i++)
            {
                if (a == x)
                {
                    c1++;
                    Console.WriteLine("Number is fib");
                    break;
                }
                int c = a + b;
                a = b; b = c;

            }
            if (c1 == 0)
            {
                Console.WriteLine("Given number is not a fib");
            }
        }
        void nearFib(int x)
        {
            int left=0, right=0;
            int a = 0,b = 1;
            while (true)
            {
                if (a > x)
                {
                    right = a;
                    break;
                }
                else if(a<x)
                {
                    left = a;
                }
                int c = a + b;
                a = b; b = c;
            }
            int n1 = right - x;
            int n2 = x-left;
            if (n1 == n2)
            {
                Console.Write($"Both {left} and {right} are Near Fibonacci numbers to {x}");
            }
            else if (n1 > n2)
            {
                Console.WriteLine($"{left} is near fibonacci number to {x}");
            }
            else
            {
                Console.Write($"{right} is near fibonacci number to {x}");
            }
            Console.WriteLine();
        }
        void nonFib(int n)
        {
            int a = 0, b = 1, c = 0;
            for (int i = 0;i<=n ; i++)
            {
                if (i == c)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                else
                {
                  
                    Console.Write(i + " ");
                    
                }
            }
            Console.WriteLine();
        }
        void NOOf_nonFib(int n)
        {
            int a = 0, b = 1, c = 0,d=0;
            for(int i= 0; ; i++)
            {
                if (i == c)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                else
                {
                    d++;
                    Console.Write(i+" ");
                    if (d == n)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
        void nearnonFib(int n)
        {
            int a = 0, b = 1, c = 0; int af = 0, bf = 0;

            if (n <= 3)
            {
                Console.WriteLine("Near non fibonacci is " + 4);
            }
            else if (n == 4)
            {
                Console.WriteLine("Near non fibonacci is " + 5);
            }
            else
            {
                for (int i = 0; ; i++)
                {
                    if (i == c)
                    {
                        c = a + b;
                        a = b;
                        b = c;
                    }
                    else
                    {
                        if (i > n)
                        {
                            af = i;
                            break;
                        }
                    }
                }
                for (int i = n - 1; ; i--)
                {
                    if (i == c)
                    {
                        c = a + b;
                        a = b;
                        b = c;
                    }
                    else
                    {
                        bf = i;
                        break;
                    }
                }
                //Console.WriteLine(af);
                //Console.WriteLine(bf);
                int k1 = af - n;
                int k2 = n-bf;
                if (k1 == k2)
                {
                    Console.Write($"Both {bf} and {af} are near non fibonacci numbers to {n}");
                }
                else if (k1 > k2)
                {
                    Console.Write($"{bf} near non fibonacci number to {n}");
                }
                else
                {
                    Console.Write($"{af} near non fibonacci number to {n}");
                }
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            Fibonacci x = new Fibonacci();
            //x.Feb(int.Parse(Console.ReadLine()));
            //x.NumberOfFib(int.Parse(Console.ReadLine()));
            //x.RangeFib(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            //x.checkNumber_IsFibnacci(int.Parse(Console.ReadLine()));
            //x.nearFib(int.Parse(Console.ReadLine()));
            //x.nonFib(int.Parse(Console.ReadLine()));
            //x.NOOf_nonFib(int.Parse(Console.ReadLine()));
            //x.nearnonFib(int.Parse(Console.ReadLine()));
        }
    }
}

