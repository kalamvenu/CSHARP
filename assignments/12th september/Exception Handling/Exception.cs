using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12th_september.Exception_Handling
{
     class ExceptionC:Exception
      {
        public static void ExceptionCatcher(Exception e)
        {
            Console.WriteLine(e);
        }

     }
} 
