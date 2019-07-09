using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exceptions
{
    class Assignment4
    {
        public static void Main(string[] args)
        {
            string firstname = "";
            string lastname = "";
            Console.WriteLine("Enter FirstName");
            firstname = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            lastname = Console.ReadLine();
            Regex r = new Regex("^[a - z A - Z]");
            try
            {
                if ((!(r.IsMatch(firstname))) || (!(r.IsMatch(lastname))) || (firstname == String.Empty) || (lastname == String.Empty)){
                    throw new InvalidNameException();
                }
                else
                {
                    Console.WriteLine("Details Stored successfully!");
                }
            }
            catch(InvalidNameException e)
            {
                
                Console.WriteLine("The first and Last names must only have alphabets and should not be null");
                Console.WriteLine(e.Message);
            }
            
        }
    }
    public class InvalidNameException : Exception
    {
        public InvalidNameException()
        {
            Console.WriteLine("Please Enter a valid Name");
        }
    }
}
