using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("enter first number");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("the sum of 2 numbers is {0}", i + k);
            
            Console.WriteLine("the product of 2 numbers is {0}", i * k);
          
            Console.WriteLine("the remainder of 2 numbers is {0}",i % k);
     
            Console.WriteLine("the quetiont of 2 numbers is {0}", i / k);
            

            bool b = i == k ? true : false;
            Console.WriteLine("2 numbers are equal:{0}",b);


            int? a = null;
            int x = a ?? 0;
            Console.WriteLine(x);
            Console.WriteLine(a);


            bool u = i!=0 && k !=0;
            Console.WriteLine(u);


            bool y = i != 0 || k != 0;
            Console.WriteLine(y);


            bool t = i == 0 && k != 0;
            Console.WriteLine(t);

            bool w = i == 0 || k == 0;
            Console.WriteLine(w);

           bool q= i == k ? true : false;
            Console.WriteLine(" :{0}", b);

            if (i < k)
            {
                Console.WriteLine("greater");
            }
            else if (k < i)
            {
                Console.WriteLine("lesser");
            }
            else if (i <= k)
            {
                Console.WriteLine("greater or equals");
            }
            else if (k <= i)
            {
                Console.WriteLine("lseer or equals");
            }
            else
            {
                Console.WriteLine( "default" );
            }

            Console.WriteLine("i {0} k {1} i++ {2} k++ {3} ++i {4} ++k {5} i-- {6} --i {7} k-- {8} --k {9} "
                ,i,k,i++,k++,++i,++k,i--,--i,k--,--k);

            Console.Read();
        }
    }
}
