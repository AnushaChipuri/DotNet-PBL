using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public double Salary { get; set; }
        public Employee(string EmployeeName, int EmployeeID, double Salary)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeName = EmployeeName;
            this.Salary = Salary;
        }
    }
    class EmployeeDAL
    {
        ArrayList al = new ArrayList();

        public bool AddEmployee(Employee e)
        {
            bool status = false;

            if (e != null)
            {
                al.Add(e);
                status = true;
            }


            return status;
        }

        public bool DeleteEmployee(int id)
        {
            bool status = false;
            foreach (Employee emp in al)
            {
                if (emp.EmployeeID == id)
                {
                    al.Remove(emp);
                    status = true;
                    break;
                }
            }
            return status;
        }

        public string SearchEmployee(int id)
        {
            string ename = "";
            foreach (Employee emp in al)
            {
                if (emp.EmployeeID == id)
                {
                    ename = emp.EmployeeName;
                }
            }
            return "Employee record found,Employee Name is" + ename;
        }

        public Employee[] GetAllEmployeeisList()
        {
            Employee[] earray = new Employee[al.Count];
            int i = 0;
            foreach (Employee e in al)
            {
                earray[i] = e;
                i++;
            }
            return earray;
        }

    }
    class ArrayListTest
    {
        static void Main(String[] args)
        {
            Employee e1 = new Employee("raj", 22, 20000);
            Employee e2 = new Employee("tarun", 10, 20500);
            Employee e3 = new Employee("ravi", 15, 30000);
            EmployeeDAL e = new EmployeeDAL();
            Console.WriteLine("Is Record Added: {0}", e.AddEmployee(e1));
            Console.WriteLine("Is Record Added: {0}", e.AddEmployee(e2));
            Console.WriteLine("Is Record Added: {0}", e.AddEmployee(e3));
            Console.WriteLine("Is Record Deleted: {0}",e.DeleteEmployee(15));
            Console.WriteLine(e.SearchEmployee(10));
            Employee[] earray = e.GetAllEmployeeisList();
            Console.WriteLine("EmployeeId     EmployeeName");
            foreach (Employee emp in earray)
            {
                Console.WriteLine("{0}                {1}",emp.EmployeeID,emp.EmployeeName);
            }
            Console.ReadKey();
        }
    }
}
