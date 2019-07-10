using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Person
    {
      public  double sal=0.0;
    }

    class HourlyEmployee : Person
    {
        double HoursWorked;
        double PayPerHour = 120.0;
        public HourlyEmployee(int HoursWorked)
        {
        this.HoursWorked = HoursWorked;
        }
         public double HourlyEmployeeSal()
        {
            sal = PayPerHour * HoursWorked;
            return sal;
        }
    }

    class PermanentEmployee : Person
    {
        double BASIC;
        double HRA;
        double DA;
        double Tax;
        double NetPay;
        double TotalPay;
        public PermanentEmployee(double BASIC)
        {
            this.BASIC = BASIC;
            HRA = 0.15 * BASIC;
            DA = 0.1 * DA;
            Tax = (BASIC + HRA + DA) * 0.8;
            NetPay = (BASIC + HRA + DA) - Tax;
        }
        public double PermanentEmployeeSal()
        {
            sal = NetPay;
            return sal;
        }
    }
}
