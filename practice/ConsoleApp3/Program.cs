using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int k = int.Parse(Console.ReadLine());

            bool.Parse(1.ToString());
            Console.WriteLine(int.Parse(567.ToString()));

            checktf(k);

          

            Console.WriteLine();

            double d = 16.66;
            int i = (int)d;

            Console.WriteLine(i);
            Console.ReadKey();
        }
        public static void checktf(int b)
        {
            int a = b;

            if (Convert.ToBoolean(a))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("only 0 is false");
            }
        }
    }
}
