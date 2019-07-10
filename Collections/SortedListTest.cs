using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections1
{
    class Employee1
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public double Salary { get; set; }
        public Employee1(string EmployeeName, int EmployeeID, double Salary)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeName = EmployeeName;
            this.Salary = Salary;
        }
    }
    class EmployeeDAL1
    {
        SortedList al = new SortedList();

        public bool AddEmployee(Employee1 e)
        {
            bool status = false;

            if (e != null)
            {
                al.Add(e.EmployeeID, e.EmployeeName);
                status = true;
            }


            return status;
        }

        public bool DeleteEmployee(int id)
        {
            bool b = false;
            b = al.Contains(id);
            if (b == true) {
                al.Remove(id);
                return b;
            }
        
            else
                return b; 
        }

        public string SearchEmployee(int id)
        {
            bool b=al.Contains(id);
            if (b == true)
                return "Employee record Found";
            else
                return "Employee record not found";
        }

        public void GetAllEmployeeisList()
        {
            
            foreach(DictionaryEntry e in al)
            {
                Console.WriteLine("{0},{1}", e.Key, e.Value);
            }

        }

    }
    class SortedListTest
    {
        public static void Main(string[] args)
        {
            Employee1 e1 = new Employee1("raj", 22, 20000);
            Employee1 e2 = new Employee1("tarun", 10, 20500);
            Employee1 e3 = new Employee1("ravi", 15, 30000);
            EmployeeDAL1 e = new EmployeeDAL1();
            Console.WriteLine("Is Record Added: {0}", e.AddEmployee(e1));
            Console.WriteLine("Is Record Added: {0}", e.AddEmployee(e2));
            Console.WriteLine("Is Record Added: {0}", e.AddEmployee(e3));
            Console.WriteLine("Is Record Deleted: {0}", e.DeleteEmployee(15));
            //Console.WriteLine(e.SearchEmployee(10));
            e.GetAllEmployeeisList();
            Console.ReadKey();
           
        }
    }
}
