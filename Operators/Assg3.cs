using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Assg3
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("Enter any charecter");
            c = char.Parse(Console.ReadLine());
            if( (c >= 'A' && c <= 'Z')|| (c >= 'a' && c <= 'z'))
                Console.WriteLine("It is an alphabet");
            else if (c >= '0' && c <= '9')
                    Console.WriteLine("It is a didgit");
            Console.ReadKey();
        }
    }
}
