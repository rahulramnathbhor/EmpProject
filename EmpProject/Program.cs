using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine(employee.PrintValue());
          Employee employee2 = new Employee(1,"xyz",10000,500);
            Console.WriteLine(employee2.PrintValue());
        }
    }
}
