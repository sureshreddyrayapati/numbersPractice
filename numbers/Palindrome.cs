using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers
{
    public class Palindrome
    {
        void cheskPoli(int x)
        {
            int temp = x,rev=0;
            while (x > 0)
            {
                int s = x % 10;
                rev = rev * 10 + s;
                x = x / 10;
            }
            if (temp == rev)
            {
                Console.WriteLine("Poindrome");
            }
            else
            {
                Console.WriteLine("Not a polindrome");
            }
        }
        void rangePloy(int x,int y)
        {
            for(int i = x; i <= y; i++)
            {
                int temp = i;
                int rev = 0;
                int k = i;
                while (k > 0)
                {
                    int d = k % 10;
                    rev= rev * 10 + d;
                    k = k / 10;
                }
                if (rev == temp)
                {
                    Console.Write(temp+" ");
                }
            }
        }
        void nearPolindrome(int x)
        {
            int lar = 0, bel = 0;
            for(int i=x+1; ; i++)
            {
                int temp = i;
                int rev = 0;
                int k = i;
                while (k > 0)
                {
                    int f= k % 10;
                    rev= rev * 10 + f;
                    k = k / 10;
                }
                if (rev == temp)
                {
                    lar = rev;
                    break;
                }
            }
            for(int i = x - 1; i > 0; i--)
            {
                int temo = i;
                int rev = 0;
                int k = i;
                while(k > 0)
                {
                    int g= k % 10;
                    rev= rev * 10 + g;
                    k = k / 10;
                }
                if (rev == temo)
                {
                    bel = rev;
                    break;
                }
            }
            //Console.WriteLine(lar+" "+bel);
            int a = lar - x;
            int b = x - bel;
            if (a == b)
            {
                Console.Write($"Near polindromes are {bel} and {lar}");
            }
            else if (a > b)
            {
                Console.Write("Near polindrome is "+bel);
            }
            else
            {
                Console.Write("near Polindrome is "+lar);
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            Palindrome x=new Palindrome();
            //x.cheskPoli(int.Parse(Console.ReadLine()));
            //x.rangePloy(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            //x.nearPolindrome(int.Parse(Console.ReadLine()));
        }
    }
}
