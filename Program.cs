using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ArrayPrat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(reverse());
            Console.WriteLine(code("Hello"));
            Console.WriteLine(angle(27, 59));
            Console.WriteLine(angle(45, 45));
            Console.WriteLine(angle(150, 30));
            Console.WriteLine(MyPi(5));
            Console.WriteLine(MyPi(4));
            Console.WriteLine(MyPi(15));
            int[] p = new int[] { 3, 4, 5, 5, 0, 1, 2, 5, 2, 7 };
            Console.WriteLine(phone(p));
        }
        static string reverse()
        {
            string x = Convert.ToString(150);
            int l = x.Length;
            StringBuilder reverse = new StringBuilder("", l); ;
            char z = 'f';
            l = x.Length - 1;
            
            for (int i = x.Length - 1; i >= 0; i--)
            {
                z = Convert.ToChar(x[i]);
                reverse.Append(z);
            }
            return Convert.ToString(reverse);
        }
        static string code(string word)
        {

            word = word.ToLower(); 
            string result = "";

            Dictionary<char, int> duplicate = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (duplicate.ContainsKey(word[i])) 
                    duplicate[word[i]]++;
                else 
                    duplicate.Add(word[i], 1);
            }
            foreach (char cha in word)
            {
                if (duplicate[cha] == 1) 
                    result = result + "(";
                else 
                   result += ")";
            }
            return result;
        }
        static string angle(int A1, int A2)
        {
            string A3 = "";
            if ((A1 + A2) == 90)
                A3 = "right";
            else if(A1 +A2 < 90)
                A3 = "acute";
            else
                A3 = "obtuse";
            return A3;
        }
        static double MyPi(int p1)
        {
            double pi = Math.Round(Math.PI, p1);
            return pi;
        }
        static string phone(int[] p)
        {
            StringBuilder num = new StringBuilder("", 14);
            for (int i = 0; i < p.Length; i++)
            {
                if (i == 0)
                {
                    num.Append('(');
                    num.Append(p[i]);
                }

                else if (i == 2)
                {
                    num.Append(p[i]);
                    num.Append(") ");
                }
                else if (i == 5)
                {
                    num.Append(p[i]);
                    num.Append("-");
                }
                else
                    num.Append(p[i]);
            }
            return Convert.ToString(num);
        }
         
    }
    
}
