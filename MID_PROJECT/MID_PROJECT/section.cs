using System;
using System.Collections.Generic;
using System.Text;

namespace MID_PROJECT
{
    class section
    {
        private string name;
        public Faculty teacher;
        public int assign;
        public string SecName
        {
            set { name = value; }
            get { return name; }
        }   

       public void showSectionInfo()
        {
            Console.WriteLine("Saction Name: "+name);
            if (assign != 0)
            {
                teacher.showfacultyinfo();
            }
        }

    }
}
