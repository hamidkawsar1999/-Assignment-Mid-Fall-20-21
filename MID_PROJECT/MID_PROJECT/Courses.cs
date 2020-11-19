using System;
using System.Collections.Generic;
using System.Text;

namespace MID_PROJECT
{
   
  public  class Courses
    {
        private string Name;
        internal section[] Section;
        internal Faculty[] faculty;
        private double teachingHour;
        private int NOS;
      
       

         public string name
        {
            set { Name = value; }
            get { return Name; }
        }
        public double TeachingHour
        {
            set { teachingHour = value; }
            get { return teachingHour; }
        }

        public int numOfSec
        {
            set { NOS = value; }
            get { return NOS; }
        }

        public void showCourseInfo()
        {
            Console.WriteLine("Name of the course : "+ Name);
            Console.WriteLine("Teaching Hour: " + teachingHour);
            Console.WriteLine("Number OF Section :"+NOS);
         
           
        }
    }
}
