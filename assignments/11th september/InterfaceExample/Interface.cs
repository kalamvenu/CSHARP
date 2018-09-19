using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11th_september.InterfaceExample
{
    public interface IEmployee
    {
        void Package();
       
    }
    //public interface IStaff
    //{
    //    void Staff();
    //   
    //}
    //public interface IManager
    //{
    //    void Manager();
    //   
    //}


    class Inter:IEmployee
    {
        public void Package()
        {
            Console.WriteLine("calling package interface");
        }

        //void Manager()
        //{
        //    Console.WriteLine("calling Iemployee");
        //}

    

        //void IStaff.Staff()
        //{
        //    Console.WriteLine("calling staff");
        //}

        //void IEmployee.Package()
        //{
        //    Console.WriteLine("calling manager");
        //}
    }

    class InterFace
    {
        public string Name;
        public static void Main(string[] args)
        {

            //Inter Interf = new Inter();

            //Interf.Package();

            InterFace Interf = new InterFace { Name = "venu" };

            var author = new Tuple<string, string, int>("xyz", "ADO.NET Programming", 2003);


            Console.WriteLine(Interf.Name);

            Console.WriteLine("names are{0}{1}{2}",author.Item1,author.Item2,author.Item3);
           // InterFace interf = default(InterFace);

           // Console.WriteLine(interf);

            Console.ReadLine();
        }

        public Tuple <int,int> Test()
        {
            int x = 12;
            int t = 45;
            return Tuple.Create(x, t);
        }
    }

    

    
   
}
