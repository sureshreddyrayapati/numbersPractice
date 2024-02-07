using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace numbers
{
    public class AmstrongNumber
    {
        void checkAmstrong(int x)
        {
            int c = 0,amr=0;
            int temp = x;
            while (x > 0)
            {
                x = x / 10;
                c++;
            }
            x= temp;
            while(x > 0)
            {
                int h = x % 10;
                amr = amr + (int)Math.Pow(h, c);
                x=x / 10;
            }
            if (amr == temp)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not a Armstrong number");
            }
        }
        void RangeAmstromg(int x,int y)
        {
            int c1 = 0;
            for(int i = x; i <= y; i++)
            {
                int temp = i;
                int c=0,amr=0;
                while (i > 0)
                {
                    i = i / 10;
                    c++;
                }
                i = temp;
                while (i > 0)
                {
                    int f=i % 10;
                    amr=amr+(int)Math.Pow(f,c);
                    i=i / 10;
                }
                i=temp;
                if(amr == temp)
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
        void primeArmstrong(int x,int y)
        {
            int c2=0;
            for (int i = x; i <= y; i++)
            {
                int temp = i;
                int c = 0, amr = 0;
                while (i > 0)
                {
                    i = i / 10;
                    c++;
                }
                i = temp;
                while (i > 0)
                {
                    int f = i % 10;
                    amr = amr + (int)Math.Pow(f, c);
                    i = i / 10;
                }
                i = temp;
                if (amr == temp)
                {
                    int c1 = 0;
                    //Console.WriteLine(i);
                    for (int n = 1; n <= i; n++)
                    {
                        if (i % n == 0)
                        {
                            c1++;
                        }
                    }
                    if (c1 == 2)
                    {
                        c2++;
                        if (c2 != 1)
                        {
                            Console.Write(",");
                        }
                        Console.Write(i);
                    }
                }
            }
            Console.Write(".");
        }
        void decToBin(int x)
        {
            string bin = "";
            while (x > 0)
            {
                int r = x % 2;
                x = x / 2;
                bin = r + bin;
            }
            Console.Write(bin);
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            AmstrongNumber x= new AmstrongNumber();
            //x.checkAmstrong(int.Parse(Console.ReadLine()));
            //x.RangeAmstromg(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            //x.primeArmstrong(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            
        }
    }
}
