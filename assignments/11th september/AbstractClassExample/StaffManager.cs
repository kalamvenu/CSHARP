using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11th_september.AbstractClassExample
{
    class StaffManager:Employee
    {
        
        public override int Number { get => Number;
            set => Number = value; 
        }

        public override int DisplaySalary()
        {
            return Salary + 50;
        }

        public override int DisplayId()
        {
            return Id;
        }

    }
}
