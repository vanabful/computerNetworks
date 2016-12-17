using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace julije2
{
    class Program
    {
        static void Main(string[] args){
        
            string prvi = "11100101";
            string drugi = "11011";
            int counter = 0;
            string res = null;
            string zeros = null;
            string prvirev = Reverse(prvi);
            Program objekt = new Program();

            res = res + drugi[0];

            for (int j = 0; j < drugi.Length; j++)
            {
                zeros = zeros + "0";
            }
                for (int i = 0; i < drugi.Length - 1; i++)
                {
                    prvi = prvi + "0";
                }

            string rez = objekt.XOR(prvi, prvi, drugi, drugi.Length, zeros, res, drugi);
            Console.Write(rez + " ");
            rez = Reverse(rez);

            for (int i = 0; i < rez.Length; i++)
            {
                if (rez[i] == '\0')
                    counter++;
            }
            int startIndex = 0;
          
            string rezPoli = rez.Substring(startIndex + counter);
            
           // drugi = Reverse(drugi);
           

           /* Console.WriteLine("prvi polinom je:");
            objekt.PrintPolinom(prvirev);

            Console.WriteLine("drugi polinom je:");
            objekt.PrintPolinom(drugi);

            Console.WriteLine("rez polinom je:");
            objekt.PrintPolinom(rezPoli);*/

           
         
        }

        public string XOR(string prviBroj, string prvi, string drugi, int index, string zeros, string res, string drugiBroj){
        
            int lenght=0;
            char[] tempC = new char[10];
            
            char[] prviC = prvi.ToCharArray();
            char[] prviBrojC = prviBroj.ToCharArray();
            char[] drugiC = drugi.ToCharArray();
            int len = drugi.Length;

            for (int i = 0; i < len; i++)
            {
                if (prviC[i] == drugiC[i])
                    tempC[i] = '0';
                else
                    tempC[i] = '1';
            }

            
            
            string temp = new string (tempC);

            string newt= temp.Substring(1, temp.Length-1);

           
            

            
            char[] newtC = newt.ToCharArray();

            for (int k = 0; k < newtC.Length; k++){
                if (newtC[k] != '\0')
                    lenght++;
                else
                    break;
            } 
            
            while (lenght != len)
            {
                if (index == prviBroj.Length)
                {
                    index++;
                    break;
                }
                else
                {
                    newtC[lenght] = prviBrojC[index];
                    lenght++;
                    index++;
                    res = res + newt[0];
                }
            }

            string rez = new string(newtC);
            
            if (index == prviBroj.Length+1)
                return rez + " " + res;
            if (newtC[0] == 48)
                return XOR(prviBroj, rez, zeros, index, zeros, res, drugiBroj);
            if (newtC[0] == 49)
                return XOR(prviBroj, rez, drugiBroj, index, zeros, res, drugiBroj);
            else
                return prvi;

        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public void PrintPolinom(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '0')
                    Console.WriteLine("x^" + i + "+ ");
                else
                    continue;
            }
        }
    }
}
