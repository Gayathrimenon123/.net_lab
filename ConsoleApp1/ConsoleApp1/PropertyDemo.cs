using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        private string _EmpName;
        public string EmpName
        {
            set
            {
                _EmpName = value;
            }
            get { return _EmpName; }
        }
    }
    class PropertyDemo
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpName = "Sweaba";
            Console.WriteLine("Employee Name: " + emp.EmpName);
        }
    }
}
