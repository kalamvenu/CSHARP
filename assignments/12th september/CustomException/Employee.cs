using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11th_september.AbstractClassExample
{
    public abstract class Employee
    {
        public int Id;
        public string Name;
        public int Salary;
        public float Bonus;

        public abstract int Number{ get;
            set;
        }


        public string DisplayName()
        {
            return Name;
        }

        public virtual int DisplaySalary()
        {
            return Salary;
        }

        public abstract int DisplayId();
        

    }
}
