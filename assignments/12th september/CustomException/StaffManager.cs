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

        public void Bonus()
        {
           
            if (Salary == 0)
            {
                throw new EmployeeException("provide the salary");
            }

           
            else
            {
                throw new EmployeeException("correct");
            }
        }
        public void SalaryException(float bonus)
        {
            base.Bonus = bonus;

            if ((Salary * 10) / 100 < bonus)
            {
                throw new EmployeeException("incorrect salary");
            }

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
