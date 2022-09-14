using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpProject
{
    public class Employee
    {
        int empid;
        string empname;
        float sal, allow;
        public Employee()
        {
            empid = 1;
            empname = "xyz";
            sal = 10000;
            allow = 500;
        }

        public Employee(int empid, string empname, float sal, float allow)
        {
            this.empid = empid;
            this.empname = empname;
            this.sal = sal;
            this.allow = allow;
        }
        public string CalculateSalary()

        {
            return $"Salary:{sal + allow}";

        }
        public string PrintValue()
        {
            return $"Employee Detail: {empid}/{empname}/{sal}/{allow}";
        }
    }
}