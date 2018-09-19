using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5th_september.schoolv2
{

    class student
    {
        public string name;
        public int rollno;
        public int[] marks = new int[100];
        

        
    }
    class subject
    {
        public string subj;

        public int higestmarks;

        public string highestname;

        public float percentage;

    }



    class subjects
    {
        static int total;
        static int b;
        static void Main(string[] args)
        {
            subject[] osubject = new subject[100];

            student[] ostudent = new student[100];

            for(int a= 0; a < 6; a++)
            {
                osubject[a] = new subject();

                Console.WriteLine("enter the subjects");

                osubject[a].subj = Console.ReadLine();


            }

            Console.WriteLine("enter students details");

            for(b = 0; b < 264; b++)
            {
                ostudent[b] = new student();

                Console.WriteLine("enter students name");

                ostudent[b].name = Console.ReadLine();

                total = 0;
                for(int c = 0; c < 6; c++)
                {
                    Console.WriteLine("enter marks for {0} in subj {1}", ostudent[b].name, osubject[c].subj);

                    ostudent[b].marks[c] = int.Parse(Console.ReadLine());

                    total = total + ostudent[b].marks[c];
                    

                    if (b == 0)
                    {
                        osubject[c].higestmarks = ostudent[b].marks[c];
                        osubject[c].highestname = ostudent[b].name;
                    }
                    
                    else if(ostudent[b].marks[c]> osubject[c].higestmarks)
                    {
                        osubject[c].higestmarks = ostudent[b].marks[c];
                        osubject[c].highestname = ostudent[b].name;
                    }

                    
                }


                osubject[b].percentage = total / 6;
               

                    Console.WriteLine("press 1 to exit ");

                string z = Console.ReadLine();
                if (z == "1") break;

            }
            for (int c = 0; c < 6; c++)
            {
                Console.WriteLine("{0} got highest marks of {1} in {2}", osubject[c].highestname, osubject[c].higestmarks, osubject[c].subj);

              

            }

           for (int d = 0; d <= b; d++)
            {
                Console.WriteLine("percentages for {0} is {1}",ostudent[d].name,osubject[d].percentage);
            }

            Console.ReadKey();
        }

    }
}
