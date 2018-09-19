using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_and_loops
{
    class identity_matrix
    {
        public void identity()
        {

            Console.WriteLine("enter the number");
            int k = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < k; i++)
            {
                for(int j = 0; j < k; j++)
                {
                    if (i == j)
                    {
                        Console.Write(k);
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write(0);
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
