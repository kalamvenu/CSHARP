using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7th_september
{
    static class details
    {
        public static string username = "hello";
        public static int userage = 40;
        public static DateTime userdob = DateTime.Now;
    }
    public class PersonalDetails
    {
        private int age;
        private string name;
        private DateTime dob;
        private int test;

         public PersonalDetails()
         {
         }
        public virtual void print()
        {
            Console.WriteLine("personal class is called"+test);
        }

        public int  propage
        {
            
            get { return details.userage; }
            set { details.userage = value; }

        }
        public string propname
        {
          get { return this.name; }
            set { this.name = value; }
      }
        public DateTime propdob
        {
           get { return this.dob; }
            set { this.dob = value; }
        }
        public int proptest
        {
            get { return this.test; }
            set { this.test = value; }
        }
        public PersonalDetails(int sendage , string sendname)
        {
           // Console.WriteLine("base class called");
            this.age = sendage;
            propname = sendname;
            propdob = DateTime.Now;
        }

        public PersonalDetails(int sendage, string sendname ,DateTime senddob)
        {
           // Console.WriteLine("base date class called");
            propage = sendage;
            propname = sendname;
            propdob = senddob;
        }
    }

    class TeacherDetails:PersonalDetails
    {
       
        
        public override void print()
        {
            Console.WriteLine("teachers  class is called");
            proptest = 44;
           
        }

        public TeacherDetails() : base(40,"venu"//,DateTime.Parse("10/10/2018")
            )
        {
        }
        public void Printdetails()
        {
            Console.WriteLine(propage);
            Console.WriteLine(propname);
            Console.WriteLine(propdob);
            Console.WriteLine(proptest);
        }
    }

    class StudentDetails:TeacherDetails
    {
        public string studentname;
        public int studentage;
        public DateTime studentdob;

        public override void print()
        {
            Console.WriteLine("student class is called");
        }
    }

    class Program
    {    
        static void Main(string[] args)
        {
           
            //Console.WriteLine("press 1 to get current date");
            //PersonalDetails t1;
            //int i = int.Parse(Console.ReadLine());
            //if (i == 1)
            //{
            //     t1 = new TeacherDetails();
            //    t1.print();
            //}
            //else
            //{
            //    t1 = new StudentDetails();
            //    t1.print();
            //}
           PersonalDetails p1 = new PersonalDetails();
           p1.print();
           
           PersonalDetails p2 = new TeacherDetails();
            p2.print();
           TeacherDetails p3 = new TeacherDetails();
           p3.print();
            PersonalDetails p4 = new StudentDetails();
            p4.print();
            TeacherDetails p5 = new StudentDetails();
          p5.print();
            StudentDetails p6 = new StudentDetails();
            p6.print();
            PersonalDetails p7 = new PersonalDetails();
            p7.print();
            Console.ReadLine();

        }       
    }
}
