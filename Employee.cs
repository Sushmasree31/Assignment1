using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Employee
    {
        public int EmPID { get; set; } = 1234;
        public string EmpName { get; set; } = "sushmasree";
        public string EmpAddress { get; set; } = "Banglore";
    }
    class ClassDemo
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("The name is" + emp.EmpName);
            Employee temp = new Employee
            {
                EmPID = 123,
                EmpName = "Sree",
                EmpAddress = " Nellore",
            };
            Console.WriteLine($"The name of the Employee is{temp.EmpName} from {temp.EmpAddress}");

        }
    }
}

