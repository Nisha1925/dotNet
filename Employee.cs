using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmpClassLib
{
    public class Employee : Person
    {
        public int EmpId { get; set; }
        public int Salary { get; set; }
        public Employee(string ename, int eage, string eemail, int salary, int empId) : base(ename, eage, eemail)
        {
            this.EmpId = empId;
            this.Salary = salary;

        }
        public override void PrintData()
        {
            Console.WriteLine("I have overridden your data");
        }
        public void AssignTask()
        {
            if(EmpId == 1001)
            {
                Console.WriteLine($"Hi {this.Name}, you are assigned with Coding task");
            }        }
        public void AssignTask(int eID, int pCode)
        {
            if(EmpId==1001 && pCode == 2001)
            {
                Console.WriteLine($"The employee {this.EmpId} is assigned with a different project. Contact Manager.");
            }
        }
    }
    public class PhoneNum : Phone
    {
        public int Number { get; set; }
        public override void ContactDeet()
        {
            Console.WriteLine($"Heya {this.Number}");
        }
    }
}
