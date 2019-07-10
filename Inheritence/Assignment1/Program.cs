using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployee pe = new PermanentEmployee(11500);
            Console.WriteLine("Permanent Employee sal:{0} ",pe.PermanentEmployeeSal());
            HourlyEmployee he = new HourlyEmployee(4);
            Console.WriteLine("Hourly Employee sal: {0}", he.HourlyEmployeeSal());
            Console.Read();
        }
    }
}
