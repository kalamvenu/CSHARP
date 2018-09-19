using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th_september
{
    class ObjectModel
    {
        public int age;
        public string name;
        public static string[] subj;
        public int[] marks;

        public string[] proper1
        {
            get { return subj; }
            set { subj = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
       
        }
    }
}
