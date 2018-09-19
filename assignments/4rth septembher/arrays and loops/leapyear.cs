using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_and_loops
{
    class leapyear
    {
       public void leap()
        {
            Console.WriteLine("enter the year");
            int year = int.Parse(Console.ReadLine());

            if (year % 400 == 0)
            {
                Console.WriteLine(" 400 leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("100 not a leap year");

            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("4 leap year");

            }
            else
          
             {
               Console.WriteLine("not a leap year");
             }

            Console.ReadKey();
        }
        
    }
}
