using System;

namespace MID_PROJECT
{
    class Program
    {
        static void Main(string[] args)
        {     
            int deptNo = 0;
             
            Console.WriteLine("       create depertment depertment:\n\n ");
            Depertment ob = new Depertment();         
           
            ob.NOC = 5;
            ob.NameofDpt = "MAth";
            ob.showDeptInfo();
            
            string[] sec = { "A", "B", "C", "D", "E", "F", "G" };
            double[] teachingHour = { 6,5,4.3,5,6};
            int[] seclist = {4,5,4,3,2};

            //set course information for depertment <ob>
        //  Console.WriteLine("\n\n       set course information for depertment <ob>\n\n ");
            ob.courselist = new Courses[5];
            for(int i = 0; i < 5; i++)
            {
                ob.courselist[i] = new Courses();
                ob.courselist[i].name = "MATH " + (i + 1);
                ob.courselist[i].TeachingHour = teachingHour[i];
                ob.courselist[i].numOfSec = seclist[i];
            }

           

            //creating section and add them to the course
            int x = 0;
            while (x < 5)
            {
                ob.courselist[x].Section = new section[ob.courselist[x].numOfSec];
                for(int i=0;i< ob.courselist[x].numOfSec; i++)
                {
                    ob.courselist[x].Section[i] = new section();
                    ob.courselist[x].Section[i].SecName = sec[i];
                   
                  
                }
                x++;
            }
            /*
            //show course and section info
            for (int i = 0; i < 5; i++)
            {
                ob.courselist[i].showCourseInfo();

                for (int j = 0; j < ob.courselist[i].Section.Length; j++)
                {
                    ob.courselist[i].Section[j].showSectionInfo();
                }
                Console.WriteLine();
            }
            */
            //Create faculty and add them as a teacher in the section.
            // If the faculty has already 21 hours of weekly load it will restrict to add more
           

            string[] facultyList = { "TANVIR AHMED", " ABUL HASNAT ", " MD. SHAHARIAR PARVEZ ", "FARHANA AFROZ", "DR. MD. RAZIB HAYAT KHAN" };
            string[] facultyIdList = { "19477001", "19477401", "19477011", "19477041", "19477021" };

            Faculty[] facultyArray = new Faculty[5];
            for (int i=0;i<5;i++)
            {
                facultyArray[i] = new Faculty();
                facultyArray[i].Fname = facultyList[i];
                facultyArray[i].ID = facultyIdList[i];
                
            }

          

            for(int i = 0; i < 5; i++)
            {
                facultyArray[i].sectionList = new section[ob.courselist[i].Section.Length];
                int k = 0;
                for (int j = 0; j < ob.courselist[i].Section.Length; j++)
                {
                 

                    if (ob.courselist[i].Section[j].assign == 0)
                    {
                        if(facultyArray[i].HourperWeek < 21)
                        {
                            facultyArray[i].HourperWeek = facultyArray[i].HourperWeek + ob.courselist[i].TeachingHour;
                            ob.courselist[i].Section[j].teacher = new Faculty();

                            ob.courselist[i].Section[j].teacher.Fname = facultyArray[i].Fname;
                            ob.courselist[i].Section[j].teacher.ID = facultyArray[i].ID;
                            facultyArray[i].sectionList[j] = new section();
                            facultyArray[i].sectionList[j] = ob.courselist[i].Section[j];

                            ob.courselist[i].Section[j].assign = 1;
                            k++; 
                        }

                    }
                }

               


            }

            //View section details and faculty from course object.
            Console.WriteLine("\n\n       iew section details and faculty from course object\n\n");
            for (int i = 0; i < 5; i++)
            {
                ob.courselist[i].showCourseInfo();

                for (int j = 0; j < ob.courselist[i].Section.Length; j++)
                {
                    ob.courselist[i].Section[j].showSectionInfo();
                }
                Console.WriteLine();
            }

            // View section details from teacher object.
            Console.WriteLine("\n\n       View section details from teacher object\n\n");
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < facultyArray[i].sectionList.Length; j++)
                {
                    facultyArray[i].sectionList[j].showSectionInfo();
                }
          }


            Console.ReadLine();
        }
    }
}
