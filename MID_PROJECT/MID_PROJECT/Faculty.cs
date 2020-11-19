using System;
using System.Collections.Generic;
using System.Text;

namespace MID_PROJECT
{
    class Faculty
    {
        private string name;
        public section[] sectionList;
        public string Fname
        {
            set { name = value; }
            get { return name; }
        }
        private string id;
        public string ID
        {
            set { id = value; }
            get { return id; }
        }
        public double HourperWeek;
     

        public void showfacultyinfo()
        {
            Console.WriteLine("teacher's name : "+name);
            Console.WriteLine("teacher's Id "+ id);
          

        }

    }

    
}
