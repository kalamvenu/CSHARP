using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] g = new int[12];

            while(true)
            {
                Console.WriteLine("enter name");
                Console.WriteLine("enter roll number");

                Console.WriteLine("enter grades");

                int k = int.Parse(Console.ReadLine());

                g[k]++;

                Console.WriteLine("do u want to enter another variable yes or no");
                string str = Console.ReadLine();
                if (str == "no")
                    break;
                
            } 
           

            int u=1;
            foreach (int j in g)
            {
                Console.WriteLine("grade{0}:{1}", u, j);
                u++;

            }
        }
    }
}
