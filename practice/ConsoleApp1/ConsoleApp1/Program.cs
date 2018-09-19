using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program:goinherit
    {
        static void Main(string[] args)
        {
            int? a = null;
            int b = a ?? 0;
            Console.WriteLine("\"yup {0}", b);
            Console.WriteLine("write something");
            string read = Console.ReadLine();
            Console.WriteLine(read);
            Program p = new Program();

            int m = multiply();
            int k = p.add();

            p.Yupin();
            Console.WriteLine(k);
            Console.WriteLine(m);
            
            
            Console.ReadKey();

        }
        public override void Yupin()
        {
            base.Yupin();
        }

        int  add()
            {
            return 5;
              }

        static int multiply()
        {
            return 5;
        }

    }

    class goinherit
    {
        virtual public void Yupin()
        {
            Console.WriteLine("hello");
        }
    }
}
