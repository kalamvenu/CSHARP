using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_and_loops
{
    class switch_case
    {
        public void charac()
        {

            Console.WriteLine("enter the character");

            string str = Console.ReadLine();
            char c = Convert.ToChar(Console.ReadLine());


            switch (c)
            {
                case '+':
                    Console.WriteLine("addition");
                    break;
                case '*':
                    Console.WriteLine("multiplication");
                    break;
                case '/':
                    Console.WriteLine("divisor");
                    break;
                case '%':
                    Console.WriteLine("modulus");
                    break;
                case '-':
                    Console.WriteLine("subtraction");
                    break;
                default:
                    Console.WriteLine("this is not a arthematic operator");
                    break;
            }

            switch (str)
            {
                case "++":
                    Console.WriteLine("increment");
                    break;
                case "--":
                    Console.WriteLine("decrement");
                    break;
                case "&&":
                    Console.WriteLine("and");
                    break;
                case "||":
                    Console.WriteLine("or");
                    break;
                case "!":
                    Console.WriteLine("not");
                    break;
                case "=":
                    Console.WriteLine("assignment");
                    break;
                case "==":
                    Console.WriteLine("equals");
                    break;
                case ">":
                    Console.WriteLine("greater than");
                    break;
                case "<":
                    Console.WriteLine("less than");
                    break;
                case ">=":
                    Console.WriteLine("greater than or equal to");
                    break;
                case "<=":
                    Console.WriteLine("less than or equal to");
                    break;
                default: Console.WriteLine("entered value is not a character");
                    break;
                
            }
        }
    }
}
