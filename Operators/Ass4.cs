using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Ass4
    {
        public static void Main(string[] args)
        {
            int n1, n2, occ= 0; ;
            Console.WriteLine("Enter any 2 values");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            while (n1 != 0)
            {
                int r = n1 % 10;
                if (r == n2)
                    occ++;
                n1 = n1 / 10;
            }
            Console.WriteLine("{0} (as {1} repeated {2} times in number1)",occ,n2,occ);
            Console.ReadKey();
        }
    }
}
