using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace first_class
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int y;
          var k=54;
            Console.WriteLine("variable sixe is ");
            Console.WriteLine(Marshal.SizeOf(k));
            Console.WriteLine("enter a number");
            bool b = int.TryParse( Console.ReadLine(),out y);
            Console.WriteLine(b);
            Console.WriteLine(y);
           
            
            Program p = new Program();
            p.over(y);
           
          

            Console.ReadKey();
        }

        public void over(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public void over(int d)
        {
            d = d * 10;
            Console.WriteLine(d);
        }
        public void over(part g)
        {

        }
 
    }
    class part
    {
        public void sum()
        {
            Console.WriteLine("hello over");
        }
    }
 


}
