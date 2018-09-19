using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12th_september.Exception_Handling
{
    public class TestE
    {
        public int TNumber;
    }

    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }

    class Program
    {
       

        static void Main(string[] args)
        {

              

            List<User> Details = new List<User>()
            {
                new User{Name="xyz",Age=45 }
             };

         List<int> TestList = new List<int>()
           {
                10,
                12,
                13
           };

           List<string> TestString = new List<string>()
           {
                "abc",
                "xyz",
                "spd"
            };
            
            

            //TestE[] testEs = new TestE[3];
            //try
            //{
            //    try
            //    {
            //        testEs[1].TNumber = 22;
            //        testEs[2].TNumber = 22;
            //    }
              
            //    catch (Exception e1)
            //    {
            //        Console.WriteLine("nested catch");
            //        // throw new Exception ("Error from Main",e1);
            //        throw e1;

            //    }
            //    //catch(Exception e2)
            //    //{
            //    //    Console.WriteLine("2nd catch block");
            //    //}
            //    finally
            //    {
            //        Console.WriteLine("nested finally");
            //    }
                
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("system error");
            //    ExceptionC.ExceptionCatcher(e);
            //}
            //finally
            //{
            //    Console.WriteLine("finally block executed");
            //}
            Console.ReadLine();
        }

       
    }
}
