using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_and_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello world";
            String strr = "hello world";
            string stri;

            bool b = string.Equals(str, "hello world");
            Console.WriteLine("equal or not {0}", b);

            stri=string.Copy(str);
            Console.WriteLine("string copied {0}", stri);

            str = string.Concat("hello",str);
            Console.WriteLine("string concatinated {0}", str);

            bool c = string.IsNullOrEmpty(str);
            Console.WriteLine("null or emptty {0}", c);

           str =  string.Join(str, "hello");
            Console.WriteLine("joined with existing {0}", str);

           str= string.Format("hello world {0}","venu");
            Console.WriteLine("formated {0}", str);

            string str2= string.Intern("world"+str);
            Console.WriteLine("interned {0}", str2);

            int i = str.CompareTo("hello world");
            Console.WriteLine("camparted {0}", i);

            bool d=str.Contains("5");
            Console.WriteLine("contains or not {0}", d);

           bool e= str.EndsWith("v");
            Console.WriteLine("end with  {0}", e);

           int o = str.IndexOf("l");
            Console.WriteLine("index is {0}", o);

            int p=str.Length;
            Console.WriteLine("length of the string is {0}", p);

            str=str.Remove(0,5);
            Console.WriteLine("removed {0}", str);

            str=str.ToUpper();
            Console.WriteLine("converted to upper case {0}", str);

            str=str.Replace('W', 'z');
            Console.WriteLine("replaced {0}",str);

            Console.ReadKey();
        }
    }
}
