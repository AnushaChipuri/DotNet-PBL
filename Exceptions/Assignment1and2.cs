using System;

namespace Exceptions
{
    class Assignment1and2
    {
        public string sname = "";
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter student name");
                string sname = Console.ReadLine();
                Console.WriteLine("Enter student marks in subject1");
                int s1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter student marks in subject2");
                int s2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter student marks in subject3");
                int s3 = Int32.Parse(Console.ReadLine());
                if (s1 < 0 || s2 < 0 || s3 < 0)
                {
                    throw new NegativeNumberException();
                }
                Console.WriteLine(" Marks of student {0} in 3 subjets are:",sname);
                Console.WriteLine(" s1  s2  s3");
                Console.WriteLine(" {0}  {1}  {2}", s1, s2, s3);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(NegativeNumberException e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }
    }
    class NegativeNumberException : Exception
    {
        public NegativeNumberException()
        {
            Console.WriteLine("Subject Marks must be greater than 100");
        }
    }
}
