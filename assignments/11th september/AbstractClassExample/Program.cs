using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11th_september.AbstractClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StaffManager StaffManager = new StaffManager();
            Manager Manager = new Manager();
            Staff Staff = new Staff();

            StaffManager.Salary = 100;
            StaffManager.Name = "xyz";
            StaffManager.Id = 1;
            StaffManager.Number = 12;
            Console.WriteLine(StaffManager.DisplaySalary());
            Console.WriteLine(StaffManager.DisplayName());
            Console.WriteLine(StaffManager.DisplayId());
            Console.WriteLine(StaffManager.Number);

            Manager.Salary = 140;
            Manager.Name = "abc";
            Manager.Id = 2;
            Manager.Number = 32;
            Console.WriteLine(Manager.DisplaySalary());
            Console.WriteLine(Manager.DisplayName());
            Console.WriteLine(Manager.DisplayId());
            Console.WriteLine(Manager.Number);

            Staff.Salary = 200;
            Staff.Name = "qwe";
            Staff.Id = 3;
            Staff.Number = 123;
            Console.WriteLine(Staff.DisplaySalary());
            Console.WriteLine(Staff.DisplayName());
            Console.WriteLine(Staff.DisplayId());
            Console.WriteLine(Staff.Number);

            Console.ReadLine();

        }
    }
}
