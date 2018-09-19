using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11th_september.AbstractClassExample
{
    public class EmployeeException:Exception
    {
        public override string Message => base.Message;
        
        public EmployeeException(string e):base(e)
        {
           
        }
    }
}
