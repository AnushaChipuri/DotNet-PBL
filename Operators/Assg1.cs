using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators2
{
    class Assg1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string s1 = Console.ReadLine();
            string s2="";
            int len = s1.Length;
            for(int i = len - 1; i >= 0; i--)
            {
                s2 = s2 + s1[i];
            }
            if (s1.Equals(s2))
                Console.WriteLine("Given string is palindrome");
            else
                Console.WriteLine("Given string is not a palindrome");
            Console.ReadKey();
        }
    }
}
