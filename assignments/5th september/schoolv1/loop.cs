using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5th_september
{
    class loop
    {
       public int[] g = new int[12];
        public void whil()
        {
           

            while (true)
            {
                Console.WriteLine("enter name");

                string name = Console.ReadLine();
                Console.WriteLine("enter roll number");

                string roll = Console.ReadLine();

                Console.WriteLine("enter grades");

                int k = int.Parse(Console.ReadLine());

                g[k]++;

                Console.WriteLine("do u want to enter another variable yes or no");
                string str = Console.ReadLine();
                if (str == "no")
                    break;

            }
        

       

            int u = 1;
            foreach (int j in g)
            {
                Console.WriteLine("grade{0}:{1}", u, j);
                u++;

            }
        }
    }
}
