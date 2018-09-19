//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _5th_september.schoolv2
//{
//    class template
//    {
//        public string name;
//        public string[] subject= new string[6];
//        public int[] marks = new int[6];
//    }


//    //class subjectv2
//    //{
//    //    public string name;
//    //    public string[] subject = new string[6];
//    //    public int[] marks = new int[6];
//    //    student sted = new student();
//    //}

//    //class student
//    //{
//    //    public int[] highestm = new int[100];
//    //    public int[] msort = new int[100];
//    //    //public int highest;
//    //    public string[] hname = new string[100];
//    //    public int total;
//    //    public int highestmark;
//    //    public string name;
//    //    public string subj;
//    //}

//    //class subjects
//    //{
//    //    public string[] subject = new string[6];
//    //    static void Main(string[] args)
//    //    {
//    //        subjectv2[] temp = new subjectv2[100];
//    //        student[] stu = new student[100];
//    //        int i = 0;
//    //        int j = 0;
//    //        int m = 0;
//    //        int n = 0;
//    //        int o = 0;
//    //        temp[i] = new subjectv2();

//    //        for (int a = 1; a <= 6; a++)
//    //        {

//    //            Console.WriteLine("enter the subject  {0} ", a);

//    //            temp[o].subject[a - 1] = Console.ReadLine();

//    //        }
//    //        while (true)
//    //        {


//    //            Console.WriteLine("enter the students name");
//    //            temp[i].name = Console.ReadLine();
//    //            stu[i] = new student();
//    //            for (int a = 1; a <= 6; a++)
//    //            {
//    //                Console.WriteLine("enter {0} marks in {1} out of 100", temp[i].name, temp[0].subject[a - 1]);

//    //                temp[i].marks[a - 1] = int.Parse(Console.ReadLine());
//    //                //stu[i].total = stu[i].total + temp[i].marks[a - 1];

//    //                temp[i + 1] = new subjectv2();
//    //                stu[a] = new student();

//    //                if (i == 0)
//    //                {
//    //                    stu[a - 1].highestmark = temp[i].marks[a - 1];
//    //                    stu[a - 1].name = temp[i].name;
//    //                }
//    //                else
//    //                {
//    //                    if (stu[a - 1].highestmark < temp[i].marks[a - 1])
//    //                    {
//    //                        stu[a - 1].highestmark = temp[i].marks[a - 1];
//    //                        stu[a - 1].name = temp[i].name;
//    //                        Console.WriteLine("if loop entered");
//    //                    }

//    //                }




//    //                //if (i > 0)
//    //                //{
//    //                //    if (temp[i - 1].marks[a - 1] < temp[i].marks[a - 1])
//    //                //    {
//    //                //        stu[m].msort[n] = temp[i].marks[a - 1];
//    //                //        Console.WriteLine("copied success" + stu[m].msort[n]);
//    //                //        stu[m].hname[n] = temp[i].name;
//    //                //        n++;
//    //                //    }
//    //                //    else
//    //                //    {
//    //                //        stu[m].msort[n] = temp[i].marks[a - 1];
//    //                //        stu[m].hname[n] = temp[i].name;
//    //                //        n++;
//    //                //    }

//    //                //}
//    //                //else
//    //                //{
//    //                //    stu[m].msort[n] = temp[i].marks[a - 1];
//    //                //    stu[m].hname[n] = temp[i].name;
//    //                //    n++;
//    //                //}

//    //            }

//    //            i++;
//    //            Console.WriteLine("do u want to enter moere values yes or no");
//    //            string str = Console.ReadLine();


//    //            if (str == "no")
//    //                break;

//    //        }

//    //        //for (int q = 0;q<stu[m].msort.Length;q++)
//    //        //{
//    //        //    for(int w = q + 1; w < stu[m].msort.Length; w++)
//    //        //    {
//    //        //        if (stu[m].msort[q] < stu[m].msort[w])
//    //        //        {
//    //        //            int tamp = stu[m].msort[q];
//    //        //            stu[m].msort[q] = stu[m].msort[w];
//    //        //            stu[m].msort[w] = tamp;
//    //        //        }
//    //        //    }
//    //        //}

//    //        for (int a = 1; a <= 6; a++)
//    //        {

//    //            Console.WriteLine("highest marks in subj {0} is {1} for {2} corrected {3}and name {4}",
//    //                temp[0].subject[a - 1], stu[m].msort[a - 1], stu[m].hname[a - 1], stu[a - 1].highestmark, stu[a - 1].name);
//    //        }




//            Console.ReadKey();
//        }
//    }

//}
