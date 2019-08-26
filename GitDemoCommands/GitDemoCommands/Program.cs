using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemoCommands
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Console Application");

            Employee emp = new Employee();
            emp.Print();

            Console.ReadLine();
        }

        public class Employee
        {
           public void Print()
            {
                Console.WriteLine("Added Print method");
            }
        }
    }
}
