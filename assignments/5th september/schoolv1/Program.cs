using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5th_september
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] grad = new int[12];
            objects[] obj = new objects[1000];

            for (int i = 0; i < obj.Length; i++)
            {
                obj[i] = new objects();
                Console.WriteLine("enter name");
                obj[i].name = Console.ReadLine();
                Console.WriteLine("enter roll number");
                obj[i].rollnumber = int.Parse(Console.ReadLine());
                Console.WriteLine("enter grades");
                obj[i].grade = int.Parse(Console.ReadLine());
                if (obj[i].grade <= 12)
                {
                   
                    int l= grad[obj[i].grade - 1]++;
                    if (l > 22)
                    {
                        Console.WriteLine("max only 22 students in a class");
                        break;
                    }
                   
                }
                else Console.WriteLine("doesnt work");
                Console.WriteLine("do u want to enter another variable yes or no");
                string str = Console.ReadLine();
                if (str == "no")
                    break;

            }

            char[]u = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l' };
            int p = 0;
            foreach (int j in grad)
            {
                            
                Console.WriteLine("grade {0}:{1}", u[p++], j);
            }







            /*            loop l = new loop();
                        l.whil();

                        print p = new print();
                        p.prin();*/

            Console.ReadKey();

        }
    }
}
