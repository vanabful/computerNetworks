using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dijeljenjePolinoma
{
    class Program
    {
        static void Main(string[] args)
        {
            string dividiend = "1101011";
            string divisor = "101";
            string quotient_and_remainder = null;
            Program objekt = new Program();

            quotient_and_remainder = objekt.Divide(dividiend, divisor);

            Console.WriteLine(quotient_and_remainder);
        }

        public string Divide(string dividiend, string divisor)
        {
            char[] remainder = new char[divisor.Length];
            string quotient = null;
            char[] dividentC = divident.ToCharArray();
            int i=0, j=0;

            for (i = 0; i < divisor.Length; i++)
                remainder[i] = dividentC[i];

            while (i < divident.Length + 1)
            {
                string remainderC = new string(remainder);
                if (remainder[0] == '0')
                    quotient = quotient + '0';
                else {
                    quotient = quotient + '1';
                    remainder = XOR(remainderC, divisor);
                }

                if (i == divident.Length)
                { 
                    int k=0;
                    if (remainder[k] == '\0')
                        remainder[k] = '0';
                    break;
                }
                else
                {

                    for (j = 0; j < divisor.Length - 1; j++)
                        remainder[j] = remainder[j + 1];
                    remainder[j] = dividentC[i];
                    i = i + 1;
                }
                   
            }

            string remainderS = new string(remainder);

            return quotient + " " + remainderS;
        }

        public char[] XOR(string divident, string divisor)
        {
            char[] remainder = new char[divisor.Length];
            for(int i=1; i<divisor.Length; i++)
            {
                if (divident[i] == divisor[i])
                    remainder[i] = '0';
                else
                    remainder[i] = '1';
            }

            return remainder;
            
        }
    }
}
