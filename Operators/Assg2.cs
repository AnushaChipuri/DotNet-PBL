using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators2
{
    class Assg2
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter any 2 numbers");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 % 10 == n2)
                Console.WriteLine("The 2nd number is in units place of 1st number");
            else if((n1/10)%10==n2)
                Console.WriteLine("The 2nd number is in tens place of 1st number");
            else if ((n1 /100)% 10 == n2)
                Console.WriteLine("The 2nd number is in hundereds place of 1st number");
            Console.ReadKey();
        }

    }
}
