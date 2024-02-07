using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers
{
    public class NumberConversions
    {
       void decimalToBinary(int x)
        {
            string bin = "";
            while (x > 0)
            {
                int n = x % 2;
                x = x / 2;
                bin = n + bin;
            }
            Console.WriteLine(bin);
            Console.WriteLine();
        }
        void DecimalToOct(int x)
        {
            string bin = "";
            while (x > 0)
            {
                int n = x % 8;
                x = x / 8;
                bin = n + bin;
            }
            Console.WriteLine(bin);
            Console.WriteLine();
        }
        string DecimalToHexa(int x)
        {
            string hex = "";
            while (x > 0)
            {
                int n= x % 16;
                 x = x / 16;
                if (n <= 9)
                {
                    hex = n + hex;
                }
                else
                {
                    hex = Convert.ToChar(n + 55) + hex;
                }
            }
            return hex;
        }
        void binaryToDecimal(string x)
        {
            int dec = 0;
            int p = 0;
            for(int i=x.Length-1;i>=0;i--)
            {
                char ch = x[i];
                int digit = ch - '0';
                dec = dec +digit* (int)Math.Pow(2, p);
                p++;
            }
            Console.WriteLine(dec);
        }
        int OctalToDecimal(string x)
        {
            int dec = 0;
            int p = 0;
            for (int i = x.Length - 1; i >= 0; i--)
            {
                char ch = x[i];
                int digit = ch - '0';
                dec = dec + digit * (int)Math.Pow(8, p);
                p++;
            }
            return dec;
        }
        int HexToDecimal(string x)
        {
            int dec=0; int p = 0;
            for(int i = x.Length - 1; i >= 0; i--)
            {
                char ch= x[i];  
                if(ch >= '0' && ch <= '9')
                {
                    int digit = ch - '0';
                    dec = dec + digit * (int)Math.Pow(16, p++);
                }
                else if (ch >= 'A' && ch <= 'F')
                {
                    int digit= ch - 55;
                    dec=dec+digit*(int)Math.Pow(16, p++);

                }else if(ch >= 'a' && ch <= 'f')
                {
                    int digit = ch - 87;
                    dec=dec+ digit*(int)Math.Pow(16,p++);
                }
            }
            return dec;
        }
        void OctalToHexa(string x)
        {
            string hex = "";
            int dec = 0;
            int p= 0;
            int oct=OctalToDecimal(x);
            hex = DecimalToHexa(oct);
            Console.WriteLine(hex);

        }
        public static void Main(string[] args)
        {
            NumberConversions x=new NumberConversions();
            //x.decimalToBinary(int.Parse(Console.ReadLine()));
            //x.DecimalToOct(int.Parse(Console.ReadLine()));
            //x.DecimalToHexa(int.Parse(Console.ReadLine()));
            //x.binaryToDecimal(Console.ReadLine());
            //x.OctalToDecimal(Console.ReadLine());
            //x.HexToDecimal(Console.ReadLine());
            //x.OctalToHexa(Console.ReadLine());
        }
    }
}
