using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program:m
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            p.over();
            p.over(2);
            p.over(4, "yup");
            Console.ReadKey();
        }
    }
    class m:a
    {
       public void over(int i)
        {
            Console.WriteLine("overloaded");

        }
        public void over(int i,string j)
        {
            Console.WriteLine("third one is overloaded");
        }
    }

    class a
    {
        public void over()
        {
            Console.WriteLine("overloading");
        }
    }
}
