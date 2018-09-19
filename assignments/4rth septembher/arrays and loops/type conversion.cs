using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_and_loops
{
    class type_conversion
    {

        public void convert()
        {
            Console.WriteLine("enter a value");

            var a = Console.ReadLine();

            Console.WriteLine("choose the type of conversion \n int \n char \n " +
                "string \n bool\n double\n byte \n decimal ");

            string str = Console.ReadLine();

            switch (str)
            {
              
                case "int": int r = Convert.ToInt32(a);
                    Console.WriteLine(r);
                    break;

                case "char": char[] c = a.ToCharArray();
                    Console.WriteLine(c);
                    break;

                case "string": string s = Convert.ToString(a);
                    Console.WriteLine(s);
                    break;

                case "double": double d = Convert.ToDouble(a);
                    Console.WriteLine(d);
                    break;
                case "bool": bool b = Convert.ToBoolean(a);
                    Console.WriteLine(b);
                    break;

                case "byte": byte by = Convert.ToByte(a);
                    Console.WriteLine(by);
                    break;

                case "decimal": decimal de = Convert.ToDecimal(a);
                    Console.WriteLine(de);
                    break;
                
                default: Console.WriteLine("enter correct value");
                    break;

            }


            Console.ReadKey();
        }

    }
}
