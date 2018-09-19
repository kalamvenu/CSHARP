using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5th_september.schoolv2
{
    class OverLoad
    {
        int i, j,k;
        public OverLoad():this(6,4,5,7)
        {
            Console.WriteLine("constructor overloaded");
        }

        public OverLoad(int i,int j)
        {
           
            Console.WriteLine("addition"+(i+j));
        }

        public OverLoad(int i, int j,int k,int l)
        {
          
           Console.WriteLine("multiplication" + i * j * k*l);
        }
        public void addition()
        {
            Console.WriteLine("addition called");
        }

        public OverLoad(OverLoad h)
        {
            OverLoad i = h;
            i.addition();
        }

            public static void Main(string[] args)
        {
          // OverLoad o = new OverLoad();

           OverLoad a = new OverLoad(4,4);

            OverLoad b = new OverLoad(a);


            Console.ReadKey();
        }
    }
}
